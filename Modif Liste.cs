using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PawContabilitate
{
    public partial class Modif_Liste : Form
    {
        public Modif_Liste()
        {
            InitializeComponent();
            if (Inregistrare_cont.conturi.Count > 0)
                foreach (var s in Inregistrare_cont.conturi)
                {
                    ListViewItem item = new ListViewItem(s.Numar.ToString());
                    item.SubItems.Add(s.Denumire);
                    item.SubItems.Add(s.Sold_debitor.ToString());
                    item.SubItems.Add(s.Sold_debitor.ToString());

                    listView1.Items.Add(item);
                }
            else
                MessageBox.Show("Nu exista conturi");

            if (Inregistrare_Tranzactie.tranzactii.Count > 0)
                foreach (var s in Inregistrare_Tranzactie.tranzactii)
                {
                    ListViewItem item = new ListViewItem(s.Cont_debitor.ToString());
                    item.SubItems.Add(s.Cont_creditor.ToString());
                    item.SubItems.Add(s.Valoare.ToString());
                    item.SubItems.Add(s.Data.ToString());

                    listView2.Items.Add(item);
                }
            else
                MessageBox.Show("Nu exista tranzactii");
        }
        //updatam fisierele
        private void btn_aplica_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter("conturi.txt"))
            {
                List<Cont> conturi = new List<Cont>();
                foreach (ListViewItem x in listView1.Items)
                {
                    Cont c1 = new Cont(Convert.ToInt32(x.Text), x.SubItems[1].Text, Convert.ToDouble(x.SubItems[2].Text), Convert.ToDouble(x.SubItems[3].Text));
                    conturi.Add(c1);
                    writer.WriteLine(c1.ToString());
                }
                Inregistrare_cont.conturi = conturi;
            }
            using (StreamWriter writer = new StreamWriter("tranzactii.txt"))
            {
                List<Tranzactie> tranzactii = new List<Tranzactie>(); 
                foreach (ListViewItem x in listView2.Items)
                {
                    Tranzactie t1 = new Tranzactie(Convert.ToInt32(x.Text), Convert.ToInt32(x.SubItems[1].Text), Convert.ToDouble(x.SubItems[2].Text), Convert.ToDateTime(x.SubItems[3].Text));
                    tranzactii.Add(t1);
                    writer.WriteLine(t1.ToString());
                }
                Inregistrare_Tranzactie.tranzactii = tranzactii;
            }
            this.Close();
            MessageBox.Show("Liste modificate!");
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        internal void MiscaItem(System.Windows.Forms.ListView listView1,DragEventArgs e)
        {
            Point cp = listView1.PointToClient(new Point(e.X, e.Y));
            ListViewItem dragToItem = listView1.GetItemAt(cp.X, cp.Y);
            if (dragToItem != null)
            {
                int dropIndex = dragToItem.Index;
                ListViewItem aux = listView1.SelectedItems[0];
                listView1.Items.Remove(aux);
                listView1.Items.Insert(dropIndex, aux);
            }

        }
        private void listView1_DragDrop(object sender, DragEventArgs e)
        {

            MiscaItem(listView1,e);
        }


        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            MiscaItem(listView2,e);
        }

        private void listView2_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listView2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
    }
}
