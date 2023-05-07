using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawContabilitate
{
    [Serializable]
    internal class Cont
    {
        private int numar;
        private string denumire;
        private double sold_debitor;
        private double sold_creditor;

        public int Numar { get => numar; set => numar = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public double Sold_debitor { get => sold_debitor; set => sold_debitor = value; }
        public double Sold_creditor { get => sold_creditor; set => sold_creditor = value; }

        public Cont(int numar, string denumire, double sold_debitor, double sold_creditor)
        {
            this.numar = numar;
            if (denumire != null)
                this.denumire = denumire;
            this.sold_debitor = sold_debitor;
            this.sold_creditor = sold_creditor;
        }

        public Cont()
        {
        }

        public override string ToString()
        {
            return "Numar " + numar + " Denumire " + denumire + " Sold debitor " + sold_debitor + " Sold creditor " + sold_creditor;
        }

        public static bool operator >(Cont y, Cont x)
        {
            return y.sold_creditor>x.sold_creditor;
        }
        public static bool operator <(Cont y,Cont x)
        {
            return y.sold_creditor < x.sold_creditor;
        }


    }
}
