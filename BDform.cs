using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PawContabilitate
{
    public partial class BDform : Form
    {
        String connConturi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Conturi.accdb";
        String connTranzactii = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Tranzactii.accdb";
        public BDform()
        {
            InitializeComponent();
            Aplicatie_Contabilitate.formCont.SubmitPressed += SubmitPressedinConturi;//legam evenimentul de apasare buton submit din formularul de inregistrare conturi al aplicatiei 
                                                                                        //de evenimentul nostru custom care va salva in baza de date atunci cand celalt eveniment se executa
                                                                                        //astfel incat la adaugarea unui noi cont, acesta se introduce si in fisier si in Baza de date
            Aplicatie_Contabilitate.formTranz.SubmitPressed += SubmitPressedinTranzactii;
        }   
        private void SubmitPressedinConturi(object sender, EventArgs e)
        {

            OleDbConnection conexiune = new OleDbConnection(connConturi);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;

                comanda.CommandText = "Insert into Conturi Values(?,?,?,?)";
                comanda.Parameters.Add("Numar", OleDbType.Integer).Value = Convert.ToInt32(Aplicatie_Contabilitate.formCont.tb_numar.Text);
                comanda.Parameters.Add("Sold Creditor", OleDbType.Double).Value = Convert.ToDouble(Aplicatie_Contabilitate.formCont.tb_soldCreditor.Text);
                comanda.Parameters.Add("Sold Debitor", OleDbType.Double).Value = Convert.ToDouble(Aplicatie_Contabilitate.formCont.tb_soldDebitor.Text);
                comanda.Parameters.Add("Denumire", OleDbType.Char, 50).Value = Aplicatie_Contabilitate.formCont.tb_denumire.Text;

                //Cont nou = new Cont(Convert.ToInt32(Aplicatie_Contabilitate.formCont.tb_numar.Text),
                //    Aplicatie_Contabilitate.formCont.tb_denumire.Text,
                //    Convert.ToDouble(Aplicatie_Contabilitate.formCont.tb_soldDebitor.Text),
                //    Convert.ToDouble(Aplicatie_Contabilitate.formCont.tb_soldCreditor.Text));

                //Inregistrare_cont.conturi.Add(nou);

                comanda.ExecuteNonQuery();//executa comanda non-query -> nu returneaza nimic comanda

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();

            }
            
        }
        private void SubmitPressedinTranzactii(object sender, EventArgs e)
        {

            
            OleDbConnection conexiuneTranz = new OleDbConnection(connTranzactii);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiuneTranz.Open();
                comanda.Connection = conexiuneTranz;

                comanda.CommandText = "Insert into Tranzactii Values(?,?,?,?)";
                comanda.Parameters.Add("Cont Debitor", OleDbType.Integer).Value = Convert.ToInt32(Aplicatie_Contabilitate.formTranz.tBox_debitor.Text);
                comanda.Parameters.Add("Cont Creditor", OleDbType.Integer).Value = Convert.ToInt32(Aplicatie_Contabilitate.formTranz.tBox_creditor.Text);
                comanda.Parameters.Add("Data", OleDbType.Date).Value = Convert.ToDateTime(Aplicatie_Contabilitate.formTranz.tBox_data.Text);
                comanda.Parameters.Add("Valoare", OleDbType.Double, 50).Value = Convert.ToDouble(Aplicatie_Contabilitate.formTranz.tBox_val.Text);

                comanda.ExecuteNonQuery();//executa comanda non-query -> nu returneaza nimic comanda

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiuneTranz.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            lv_conturi.Items.Clear();
            lv_Tranzactii.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connConturi);
            OleDbConnection conexiuneTranz = new OleDbConnection(connTranzactii);
            try
            {
                conexiune.Open();
                conexiuneTranz.Open();
                OleDbCommand comanda = new OleDbCommand();
                OleDbCommand comandaTranz = new OleDbCommand();
                comanda.CommandText = "Select * from Conturi";
                comanda.Connection = conexiune;

                comandaTranz.Connection = conexiuneTranz;
                comandaTranz.CommandText = "Select * from Tranzactii";

                OleDbDataReader reader = comanda.ExecuteReader();
                OleDbDataReader readerTranz=comandaTranz.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["Numar"].ToString());
                    itm.SubItems.Add(reader["Sold Creditor"].ToString());
                    itm.SubItems.Add(reader["Sold Debitor"].ToString());
                    itm.SubItems.Add(reader["Denumire"].ToString());

                    lv_conturi.Items.Add(itm);
                }

                while (readerTranz.Read())
                {
                    ListViewItem itm = new ListViewItem(readerTranz["Cont Debitor"].ToString());
                    itm.SubItems.Add(readerTranz["Cont Creditor"].ToString());
                    itm.SubItems.Add(readerTranz["Valoare"].ToString());
                    itm.SubItems.Add(readerTranz["Data"].ToString());

                    lv_Tranzactii.Items.Add(itm);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Aplicatie_Contabilitate.formCont.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Aplicatie_Contabilitate.formTranz.ShowDialog();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connConturi);
            OleDbConnection conexiuneTranz = new OleDbConnection(connTranzactii);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            try
            {

                conexiune.Open();
                conexiuneTranz.Open();
                foreach (ListViewItem itm in lv_conturi.Items)
                    if (itm.Selected)
                    {
                        int id = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM Conturi WHERE Numar =" + id;
                        comanda.ExecuteNonQuery();//executam comanda fara ca ea sa returneze ceva
                    }

                comanda.Connection = conexiuneTranz;
                foreach (ListViewItem itm in lv_Tranzactii.Items)
                    if (itm.Selected)
                    {
                        int deb = Convert.ToInt32(itm.SubItems[0].Text);
                        int cred = Convert.ToInt32(itm.SubItems[1].Text);
                        double val = Convert.ToDouble(itm.SubItems[2].Text);
                        DateTime data = Convert.ToDateTime(itm.SubItems[3].Text);

                        comanda.CommandText = "DELETE FROM Tranzactii WHERE [Cont Debitor] = " + deb + " and [Cont Creditor] = " + cred + " and Valoare = " + val; ;
                        comanda.ExecuteNonQuery();
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lv_conturi.Items.Clear();
                lv_Tranzactii.Items.Clear();
                conexiune.Close();
                conexiuneTranz.Close();
                button1_Click(sender, e);
            }
        }
    }
}
