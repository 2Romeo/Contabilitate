using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawContabilitate
{
    internal class Tranzactie
    {
        private int cont_debitor;
        private int cont_creditor;
        private double valoare;
        DateTime data;

        public int Cont_debitor { get => cont_debitor; set => cont_debitor = value; }
        public int Cont_creditor { get => cont_creditor; set => cont_creditor = value; }
        public double Valoare { get => valoare; set => valoare = value; }
        public DateTime Data { get => data; set => data = value; }

        public Tranzactie(int cont_debitor, int cont_creditor, double valoare, DateTime data)
        {
            this.cont_debitor = cont_debitor;
            this.cont_creditor = cont_creditor;
            this.valoare = valoare;
            this.data = data;
        }

        public override string ToString()
        {
            return "Cont debitor " + cont_debitor + " cont creditor: " + cont_creditor + " valoare: " + valoare + " data: " + data+"\n";
        }

 
    }
}
