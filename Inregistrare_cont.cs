using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

       
    }


  }

