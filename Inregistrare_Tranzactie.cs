using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualBasic;
using System.Linq.Expressions;
using System.Drawing.Printing;

namespace PawContabilitate
{
    [Serializable]
    
    public partial class Inregistrare_Tranzactie : Form
    {
        internal event EventHandler SubmitPressed;
        internal static List<Tranzactie> tranzactii = new List<Tranzactie>();
        public Inregistrare_Tranzactie()
        {
            InitializeComponent();
        }

        private void Formular_Load(object sender, EventArgs e)
        {
            tBox_debitor.Text = "";
            tBox_creditor.Text = "";
            tBox_data.Text = "";
            tBox_val.Text = "";
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            Formular_Load(sender, e);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            try
            {
                

                if (tBox_debitor.Text == "")
                    throw new Exception("debitor-ul este necompletat");
                else
                    if (tBox_creditor.Text == "")
                    throw new Exception("creditor-ul este necompletat");
                else
                            if (tBox_val.Text == "")
                    throw new Exception("valoarea este necompletata");
                else
                                if (tBox_data.Text == "")
                    throw new Exception("data este necompletata");
               
                int debitor = Convert.ToInt32(tBox_debitor.Text);
                int creditor = Convert.ToInt32(tBox_creditor.Text);
                DateTime data = Convert.ToDateTime(tBox_data.Text);
                double val = Convert.ToDouble(tBox_val.Text);

               

                int ok = 2;
                    foreach (var x in Inregistrare_cont.conturi)
                    {
                        if (x.Numar == debitor)
                            ok--;
                        if (x.Numar == creditor)
                            ok--;
                    }
                    if (ok == 2)
                        throw new Exception("nu exista contul debitor si nici contul creditor");
                    if (ok == 1)
                        throw new Exception("nu exista contul debitor sau contul creditor");


                

                foreach (var s in Inregistrare_cont.conturi)
                    if (val > s.Sold_creditor && s.Numar == creditor)
                        throw new Exception("fonduri creditoare insuficiente");
                    else if (val <= s.Sold_creditor)
                    {
                        if (s.Numar == creditor)
                            s.Sold_creditor -= val;
                        if (s.Numar == debitor)
                            s.Sold_creditor += val;
                    }
                //updatam fisierul de conturi
                using (StreamWriter sw = new StreamWriter("conturi.txt"))
                {
                    foreach (var x in Inregistrare_cont.conturi)
                    {
                        sw.WriteLine(x.ToString());
                        sw.WriteLine("");
                    }

                }
                //creem tranzactia cu datele introduse si adaugam in lista
                Tranzactie aux = new Tranzactie(debitor, creditor, val, data);
                tranzactii.Add(aux);

                using (StreamWriter writer = new StreamWriter("tranzactii.txt", true))//true == append adica adauga la liniile existente
                {
                    writer.WriteLine(aux.ToString());
                }
                btn_clearAll_Click(sender, e);


                SubmitPressed.Invoke(sender, e);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void editareTranzactieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {   //datele pe care le cautam
                DateTime data = Convert.ToDateTime(Interaction.InputBox("Introduceti Data Tranzactiei", "Data Tranzactiei", "", 200, 100));
                double val = Convert.ToDouble(Interaction.InputBox("Introduceti valoarea Tranzactiei", "Data Tranzactiei", "", 200, 100));
                int creditor = Convert.ToInt32(Interaction.InputBox("Introduceti creditorul", "Creditor", "", 200, 100));
                int debitor = Convert.ToInt32(Interaction.InputBox("Introduceti debitorul", "Debitor", "", 200, 100));
                //pozitia elementului cautat, si ok daca exista
                int ok = 1, poz = 0;

                for (int i = 0; i < tranzactii.Count; i++)
                {
                    if (tranzactii[i].Data == data && tranzactii[i].Valoare == val && tranzactii[i].Cont_creditor == creditor && tranzactii[i].Cont_debitor == debitor)
                    {
                        ok = 0;
                        poz = i;
                    }
                }
                if (ok == 1)
                    throw new Exception("nu exista o astfel de tranzactie");
                else
                {   //datele cu care vrem sa inlocuim 
                    //DateTime data1 = Convert.ToDateTime(Interaction.InputBox("Introduceti Data Tranzactiei", "Data Tranzactiei", "", 200, 100));
                    double val1 = Convert.ToDouble(Interaction.InputBox("Introduceti valoarea noua/veche a tranzactiei", "Data Tranzactiei", "", 200, 100));
                    //int creditor1 = Convert.ToInt32(Interaction.InputBox("Introduceti creditorul", "Creditor", "", 200, 100));
                    int debitor1 = Convert.ToInt32(Interaction.InputBox("Introduceti debitorul nou/vechi", "Debitor", "", 200, 100));
                    //verificam daca valoarea noua introdusa poate fi schimbata
                    foreach (var x in Inregistrare_cont.conturi)
                        if (tranzactii[poz].Cont_debitor == x.Numar && val1 > x.Sold_creditor + tranzactii[poz].Valoare)
                            throw new Exception("valoarea schimbata este prea mare");
                        else if (tranzactii[poz].Cont_creditor == x.Numar && val1 <= x.Sold_creditor + tranzactii[poz].Valoare)
                        {
                            tranzactii[poz].Valoare = val1;
                            tranzactii[poz].Cont_debitor = debitor1;
                        }
                    using (StreamWriter sw = new StreamWriter("tranzactii.txt"))
                    {
                        foreach (var x in tranzactii)
                        {
                            sw.WriteLine(x.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adaugareSolduriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numar = Convert.ToInt32(Interaction.InputBox("Introduceti numarul contului", "Cont", "", 200, 100));
            string denumire = Convert.ToString(Interaction.InputBox("Introduceti denumirea contului", "Denumire", "", 200, 100));
            DateTime data = Convert.ToDateTime(Interaction.InputBox("Introduceti data tranzactiei", "data", "", 200, 100));
            int ok = 1;
            double aux = 0;
            try
            {
                foreach (var x in Inregistrare_cont.conturi)
                {
                    if (x.Numar == numar && x.Denumire == denumire)
                    {
                        ok = 0;
                        aux = Convert.ToDouble(Interaction.InputBox("Introduceti suma de adaugat", "Suma", "", 200, 100));
                        x.Sold_creditor += aux;
                        MessageBox.Show("Solduri actualizate");
                    }

                }
                if (ok == 1)
                    throw new Exception("Cont inexistent ");
                else
                {
                    Tranzactie aux1 = new Tranzactie(numar, numar, aux, data);
                    tranzactii.Add(aux1);
                    //actualizam conturile
                    using (StreamWriter writer = new StreamWriter("conturi.txt"))
                    {
                        foreach (var x in Inregistrare_cont.conturi)
                            writer.WriteLine(x.ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void retragereSolduriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ok = 1;
            double aux = 0;
            try
            {
                int numar = Convert.ToInt32(Interaction.InputBox("Introduceti numarul contului", "Cont", "", 200, 100));
                string denumire = Convert.ToString(Interaction.InputBox("Introduceti denumirea contului", "Denumire", "", 200, 100));
                DateTime data = Convert.ToDateTime(Interaction.InputBox("Introduceti data tranzactiei", "data", "", 200, 100));

                foreach (var x in Inregistrare_cont.conturi)
                {
                    if (x.Numar == numar && x.Denumire == denumire)
                    {
                        ok = 0;
                        aux = Convert.ToDouble(Interaction.InputBox("Introduceti suma de retras", "Suma", "", 200, 100));
                        if (aux <= x.Sold_creditor)
                        {
                            x.Sold_creditor -= aux;
                            MessageBox.Show("Solduri actualizate");
                        }
                        else
                            throw new Exception("Fonduri insuficiente");
                    }

                }
                if (ok == 1)
                    throw new Exception("Cont inexistent ");
                    else
                    {
                        Tranzactie aux1 = new Tranzactie(numar, numar, aux, data);
                        tranzactii.Add(aux1);
                        //actualizam conturile.txt
                        using (StreamWriter writer = new StreamWriter("conturi.txt"))
                        {
                            foreach (var x in Inregistrare_cont.conturi)
                                writer.WriteLine(x.ToString());
                                                
                        }
                        //actualizam tranzactiile.txt
                        using (StreamWriter sw1 = new StreamWriter("tranzactii.txt", true))
                        {
                            sw1.WriteLine(aux1.ToString());

                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vizualizareTranzactiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("tranzactii.txt"), "Tranzactii");
        }

        private void Inregistrare_Tranzactie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "A")//daca apasam control + A
                btn_submit_Click(sender, e);
            if (e.Control && e.KeyCode.ToString() == "X")
                btn_clearAll_Click(sender, e);
        }

        private void printeazaFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}