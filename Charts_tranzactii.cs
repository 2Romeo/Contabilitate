using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PawContabilitate
{
    public partial class Charts_tranzactii : Form
    {
        public Charts_tranzactii()
        {
            InitializeComponent();
        }

        private void Charts_tranzactii_Load(object sender, EventArgs e)
        {
            List<Tranzactie> aux = Inregistrare_Tranzactie.tranzactii;
            for (int i = 0; i < aux.Count - 1; i++)
            {

                for (int j = i + 1; j < aux.Count; j++)
                {
                    if (aux[i].Valoare < aux[j].Valoare)
                    {
                        Tranzactie aux1 = aux[i];
                        aux[i] = aux[j];
                        aux[j] = aux1;
                    }
                }

            }//sort dupa valoare

            for (int i = aux.Count - 1; i >= 0; i--)
            {   
                int ok = 0;
                chart1.Series["U.m."].Points.AddXY(aux[i].Data.ToString("yyyy - MMM - dd") , aux[i].Valoare);

                foreach (DataPoint point in chart2.Series["Series1"].Points)
                {
                    if (aux[i].Data.ToString("MMM") == point.AxisLabel)//daca luna este deja introdusa
                    {
                        point.SetValueY(point.YValues[0] + 200);
                        ok = 1;
                    }
                }
                if(ok==0)
                {
                    chart2.Series["Series1"].Points.AddXY(aux[i].Data.ToString("MMM"), 200);//daca nu exista creem luna respectiva

                }

            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintPreview();
            chart2.Printing.PrintPreview();
        }
    }
}
