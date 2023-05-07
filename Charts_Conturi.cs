using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawContabilitate
{
    public partial class Charts_Conturi : Form
    {
        public Charts_Conturi()
        {
            InitializeComponent();
        }

        private void Charts_Conturi_Load(object sender, EventArgs e)
        {
            List<Cont> aux = Inregistrare_cont.conturi;
            List<Cont> auxDeb = Inregistrare_cont.conturi;
            for (int i = 0; i < aux.Count - 1; i++)
            {

                for (int j = i + 1; j < aux.Count; j++)
                {
                    if (aux[i].Sold_creditor < aux[j].Sold_creditor)
                    {
                        Cont aux1 = aux[i];
                        aux[i] = aux[j];
                        aux[j] = aux1;
                    }
                }

            }//sort dupa credit
            for (int i = 0; i < auxDeb.Count - 1; i++)
            {

                for (int j = i + 1; j < aux.Count; j++)
                {
                    if (auxDeb[i].Sold_debitor < auxDeb[j].Sold_debitor)
                    {
                        Cont aux1 = auxDeb[i];
                        auxDeb[i] = auxDeb[j];
                        auxDeb[j] = aux1;
                    }
                }

            }//sort dupa debit

            for (int i = aux.Count-1; i>=0; i--)
            {
                chr_TopCred.Series["U.m."].Points.AddXY(Convert.ToString(aux[i].Numar),aux[i].Sold_creditor);
                chr_TopDeb.Series["U.m."].Points.AddXY(Convert.ToString(auxDeb[i].Numar), auxDeb[i].Sold_debitor);
            } 
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            chr_TopCred.Printing.PrintPreview();
            chr_TopDeb.Printing.PrintPreview();
        }
    }
}
