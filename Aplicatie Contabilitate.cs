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
                sw.WriteLine(text);
            }
        }
    }
}

        

