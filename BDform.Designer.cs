namespace PawContabilitate
{
    partial class BDform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lv_conturi = new System.Windows.Forms.ListView();
            this.lv_Tranzactii = new System.Windows.Forms.ListView();
            this.nrCont = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soldCreditor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Synchronize = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_conturi
            // 
            this.lv_conturi.CheckBoxes = true;
            this.lv_conturi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nrCont,
            this.soldCreditor,
            this.columnHeader1,
            this.columnHeader2});
            this.lv_conturi.ContextMenuStrip = this.contextMenuStrip1;
            this.lv_conturi.FullRowSelect = true;
            this.lv_conturi.GridLines = true;
            this.lv_conturi.HideSelection = false;
            this.lv_conturi.Location = new System.Drawing.Point(74, 42);
            this.lv_conturi.Name = "lv_conturi";
            this.lv_conturi.Size = new System.Drawing.Size(272, 174);
            this.lv_conturi.TabIndex = 0;
            this.lv_conturi.UseCompatibleStateImageBehavior = false;
            this.lv_conturi.View = System.Windows.Forms.View.Details;
            // 
            // lv_Tranzactii
            // 
            this.lv_Tranzactii.CheckBoxes = true;
            this.lv_Tranzactii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_Tranzactii.ContextMenuStrip = this.contextMenuStrip1;
            this.lv_Tranzactii.FullRowSelect = true;
            this.lv_Tranzactii.GridLines = true;
            this.lv_Tranzactii.HideSelection = false;
            this.lv_Tranzactii.Location = new System.Drawing.Point(436, 42);
            this.lv_Tranzactii.Name = "lv_Tranzactii";
            this.lv_Tranzactii.Size = new System.Drawing.Size(272, 174);
            this.lv_Tranzactii.TabIndex = 0;
            this.lv_Tranzactii.UseCompatibleStateImageBehavior = false;
            this.lv_Tranzactii.View = System.Windows.Forms.View.Details;
            // 
            // nrCont
            // 
            this.nrCont.Text = "nrCont";
            this.nrCont.Width = 70;
            // 
            // soldCreditor
            // 
            this.soldCreditor.Text = "Sold Creditor";
            this.soldCreditor.Width = 89;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "soldDebitor";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Denumire";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cont Debitor";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cont Creditor";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valoare";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data";
            this.columnHeader6.Width = 101;
            // 
            // btn_Synchronize
            // 
            this.btn_Synchronize.Location = new System.Drawing.Point(74, 262);
            this.btn_Synchronize.Name = "btn_Synchronize";
            this.btn_Synchronize.Size = new System.Drawing.Size(109, 52);
            this.btn_Synchronize.TabIndex = 1;
            this.btn_Synchronize.Text = "Sync\r\n";
            this.btn_Synchronize.UseVisualStyleBackColor = true;
            this.btn_Synchronize.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(216, 262);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(109, 52);
            this.btn_Insert.TabIndex = 2;
            this.btn_Insert.Text = "Insert Cont";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Insert Tranzactie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 28);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // BDform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Synchronize);
            this.Controls.Add(this.lv_Tranzactii);
            this.Controls.Add(this.lv_conturi);
            this.Name = "BDform";
            this.Text = "BDform";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_conturi;
        private System.Windows.Forms.ColumnHeader nrCont;
        private System.Windows.Forms.ColumnHeader soldCreditor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lv_Tranzactii;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_Synchronize;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
    }
}