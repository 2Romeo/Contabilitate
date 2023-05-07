using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawContabilitate
{
    public partial class Inregistrare_cont : Form
    {
        internal static List<Cont> conturi = new List<Cont>();
        public Inregistrare_cont()
        {
            InitializeComponent();
        }


        private void Inregistrare_cont_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.ToString() == "A")//daca apasam control + A
               btn_submit_Click(sender, e);
            if(e.Control && e.KeyCode.ToString()=="X")
                btn_clear_Click(sender, e);
        }
        private void Inregistrare_cont_Load(object sender, EventArgs e)
        {
            tb_numar.Text = "";
            tb_denumire.Text = "";
            tb_soldCreditor.Text = "";
            tb_soldDebitor.Text = "";
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Inregistrare_cont_Load(sender, e);
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_numar.Text == "")
                    throw new Exception("numele este necompletat");
                else
                    if (tb_denumire.Text == "")
                    throw new Exception("denumirea este necompletata");
                else
                            if (tb_soldCreditor.Text == "")
                    throw new Exception("valoarea soludului creditor este necompletata");
                else
                                if (tb_soldDebitor.Text == "")
                    throw new Exception("valoarea soludului debitor este necompletata");
                else
                {
                    int numar = Convert.ToInt32(tb_numar.Text);
                    string denumire= Convert.ToString(tb_denumire.Text);
                    double sold_creditor=Convert.ToDouble(tb_soldCreditor.Text);
                    double sold_debitor = Convert.ToDouble(tb_soldDebitor.Text);

                    Cont aux = new Cont(numar, denumire, sold_debitor, sold_creditor);
                    conturi.Add(aux);

                    using (StreamWriter writer = new StreamWriter("conturi.txt",true))
                    { 
                        writer.WriteLine(aux.ToString());
                        writer.WriteLine("");
                   
                    }

                    
                }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { 
                tb_numar.Text = "";
                tb_denumire.Text = "";
                tb_soldCreditor.Text = "";
                tb_soldDebitor.Text = "";
            }

        }

        private void stergereContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numar = Convert.ToInt32(Interaction.InputBox("Introduceti numarul contului", "Cont", "", 200, 100));
            string denumire = Convert.ToString(Interaction.InputBox("Introduceti denumirea contului", "Denumire", "", 200, 100));

            try
            {
                int ok = 0,poz=0;
                for (int i = 0; i < conturi.Count(); i++)
                    if (conturi[i].Numar == numar && conturi[i].Denumire == denumire)
                    { ok = 1; poz = i; }
                if (ok == 1)
                {
                    conturi.RemoveAt(poz);

                    MessageBox.Show("Cont sters cu succes");
                    //updatam fisierul cu conturi
                    using (StreamWriter writer = new StreamWriter("conturi.txt"))
                    {
                        foreach (var x in conturi)
                            writer.WriteLine(x.ToString());
                    }
                }
                else
                    throw new Exception("Nu exista un astfel de cont");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void editareContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numar = Convert.ToInt32(Interaction.InputBox("Introduceti numarul contului", "Cont", "", 200, 100));
            string denumire = Convert.ToString(Interaction.InputBox("Introduceti denumirea contului", "Denumire", "", 200, 100));

            try
            {
                int ok = 0, poz = 0;
                for (int i = 0; i < conturi.Count(); i++)
                    if (conturi[i].Numar == numar && conturi[i].Denumire == denumire)
                    { ok = 1; poz = i; }
                if (ok == 1)
                {
                    int numar1 = Convert.ToInt32(Interaction.InputBox("Introduceti numarul nou/vechi al contului", "Cont", "", 200, 100));
                    string denumire1 = Convert.ToString(Interaction.InputBox("Introduceti denumirea noua/veche a contului", "Denumire", "", 200, 100));
                    double sold_creditor1 = Convert.ToDouble(Interaction.InputBox("introduceti noul/vechiul sold creditor", "Sold creditor", "", 200, 100));
                    double sold_debitor1 = Convert.ToDouble(Interaction.InputBox("introduceti noul/vechiul sold debitor", "Sold debitor", "", 200, 100));

                    conturi[poz].Numar = numar1; conturi[poz].Denumire = denumire1; conturi[poz].Sold_debitor = sold_debitor1;
                    conturi[poz].Sold_creditor = sold_creditor1;

                    MessageBox.Show("Cont modificat cu succes");
                    //updatam fisierul cu conturi
                    using (StreamWriter writer = new StreamWriter("conturi.txt"))
                    {
                        foreach (var x in conturi)
                            writer.WriteLine(x.ToString());
                    }
                }
                else
                    throw new Exception("Nu exista un astfel de cont");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void vizualizareConturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("conturi.txt"),"Conturi");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void printDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }


  }

