using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices.ComTypes;

namespace PawContabilitate
{
    [Serializable]
    public partial class Aplicatie_Contabilitate : Form
    {
        public Aplicatie_Contabilitate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inregistrare_cont newform = new Inregistrare_cont();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Inregistrare_cont.conturi.Count == 0)
                    throw new Exception("Nu exista conturi introduse");
                Inregistrare_Tranzactie newform = new Inregistrare_Tranzactie();
                this.Hide();
                newform.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void serializeazaFisiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Read the text file into a string
            string text = File.ReadAllText("conturi.txt");
            string text1 = File.ReadAllText("tranzactii.txt");
            //Serialize the text string
            BinaryFormatter bf = new BinaryFormatter();
            FileStream sf = new FileStream("conturi.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(sf, text);
            sf.Close();
            FileStream sf1 = new FileStream("tranzactii.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(sf1, text1);
            sf.Close();
        }
        private void deserializeazaFisiereToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("conturi.txt", FileMode.Open, FileAccess.Read);
            FileStream fs1 = new FileStream("tranzactii.txt", FileMode.Open, FileAccess.Read);
            string text = (string)bf.Deserialize(fs);
            string text1=(string)bf.Deserialize(fs1);
            fs1.Close();
            fs.Close();
            using (StreamWriter sw = new StreamWriter("conturi.txt"))
            {
                sw.WriteLine(text);
            }
            using (StreamWriter sw = new StreamWriter("tranzactii.txt"))
            {
                sw.WriteLine(text1);
            }
        }

     

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "Conturi")
            { 
                Charts_Conturi conturi = new Charts_Conturi();
                conturi.ShowDialog();
            }
            if(toolStripComboBox1.Text=="Inregistrari")
            {
                Charts_tranzactii inregistrari= new Charts_tranzactii();
                inregistrari.ShowDialog();
            }
        }

        private void restaureazaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader srCont = new StreamReader("conturi.txt");
            StreamReader srTranz = new StreamReader("tranzactii.txt");
            string linie = null;
            while ((linie = srCont.ReadLine()) != null)//cat timp avem linii in StreamReader
            {
                if (linie != "")
                {
                    int cod = Convert.ToInt32(linie.Split(' ')[1]);//imparte linia in substringuri despartite de virgula si alegem primul element ca fiind codul studentului
                    string denumire = linie.Split(' ')[3];
                    double deb = Convert.ToDouble(linie.Split(' ')[6]);
                    double cred = Convert.ToDouble(linie.Split(' ')[9]);

                    Cont nou = new Cont(cod, denumire, deb, cred);
                    Inregistrare_cont.conturi.Add(nou);
                }
            }
            srCont.Close();

            while ((linie = srTranz.ReadLine()) != null)//cat timp avem linii in StreamReader
            {
                if (linie != "")
                {
                    int contD = Convert.ToInt32(linie.Split(' ')[2]);//imparte linia in substringuri despartite de virgula si alegem primul element ca fiind codul studentului
                    int contC= Convert.ToInt32(linie.Split(' ')[5]);
                    double val = Convert.ToDouble(linie.Split(' ')[7]);
                    DateTime data= Convert.ToDateTime(linie.Split(' ')[9]);

                    Tranzactie noua=new Tranzactie(contD,contC,val,data);
                    Inregistrare_Tranzactie.tranzactii.Add(noua);

                }
            }
            srTranz.Close();
         //   MessageBox.Show("Date Incarcate!");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Modif_Liste form = new Modif_Liste();
            form.ShowDialog();

        }
    }
}

        

