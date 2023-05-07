namespace PawContabilitate
{
    partial class Inregistrare_Tranzactie
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
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_creditor = new System.Windows.Forms.Label();
            this.tBox_data = new System.Windows.Forms.TextBox();
            this.lbl_val = new System.Windows.Forms.Label();
            this.tBox_creditor = new System.Windows.Forms.TextBox();
            this.tBox_val = new System.Windows.Forms.TextBox();
            this.lbl_debitor = new System.Windows.Forms.Label();
            this.tBox_debitor = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vizualizareTranzactiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaTipulTranzactieiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareSolduriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retragereSolduriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareTranzactieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printeazaFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.Location = new System.Drawing.Point(483, 281);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(162, 59);
            this.btn_clearAll.TabIndex = 15;
            this.btn_clearAll.Text = "Clear All";
            this.btn_clearAll.UseVisualStyleBackColor = true;
            this.btn_clearAll.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(256, 281);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(162, 59);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(101, 223);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(102, 16);
            this.lbl_data.TabIndex = 12;
            this.lbl_data.Text = "Data Tranzactie";
            // 
            // lbl_creditor
            // 
            this.lbl_creditor.AutoSize = true;
            this.lbl_creditor.Location = new System.Drawing.Point(50, 120);
            this.lbl_creditor.Name = "lbl_creditor";
            this.lbl_creditor.Size = new System.Drawing.Size(153, 16);
            this.lbl_creditor.TabIndex = 13;
            this.lbl_creditor.Text = "Numarul contului creditor";
            // 
            // tBox_data
            // 
            this.tBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_data.Location = new System.Drawing.Point(216, 220);
            this.tBox_data.Name = "tBox_data";
            this.tBox_data.Size = new System.Drawing.Size(494, 22);
            this.tBox_data.TabIndex = 10;
            // 
            // lbl_val
            // 
            this.lbl_val.AutoSize = true;
            this.lbl_val.Location = new System.Drawing.Point(88, 170);
            this.lbl_val.Name = "lbl_val";
            this.lbl_val.Size = new System.Drawing.Size(115, 16);
            this.lbl_val.TabIndex = 8;
            this.lbl_val.Text = "Valoare tranzactie";
            // 
            // tBox_creditor
            // 
            this.tBox_creditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_creditor.Location = new System.Drawing.Point(216, 117);
            this.tBox_creditor.Name = "tBox_creditor";
            this.tBox_creditor.Size = new System.Drawing.Size(494, 22);
            this.tBox_creditor.TabIndex = 11;
            // 
            // tBox_val
            // 
            this.tBox_val.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_val.Location = new System.Drawing.Point(216, 167);
            this.tBox_val.Name = "tBox_val";
            this.tBox_val.Size = new System.Drawing.Size(494, 22);
            this.tBox_val.TabIndex = 6;
            // 
            // lbl_debitor
            // 
            this.lbl_debitor.AutoSize = true;
            this.lbl_debitor.Location = new System.Drawing.Point(50, 67);
            this.lbl_debitor.Name = "lbl_debitor";
            this.lbl_debitor.Size = new System.Drawing.Size(150, 16);
            this.lbl_debitor.TabIndex = 9;
            this.lbl_debitor.Text = "Numarul contului debitor";
            // 
            // tBox_debitor
            // 
            this.tBox_debitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_debitor.Location = new System.Drawing.Point(216, 64);
            this.tBox_debitor.Name = "tBox_debitor";
            this.tBox_debitor.Size = new System.Drawing.Size(494, 22);
            this.tBox_debitor.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareTranzactiiToolStripMenuItem,
            this.schimbaTipulTranzactieiToolStripMenuItem,
            this.editareTranzactieToolStripMenuItem,
            this.printeazaFisierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 128);
            // 
            // vizualizareTranzactiiToolStripMenuItem
            // 
            this.vizualizareTranzactiiToolStripMenuItem.Name = "vizualizareTranzactiiToolStripMenuItem";
            this.vizualizareTranzactiiToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.vizualizareTranzactiiToolStripMenuItem.Text = "Vizualizare Tranzactii";
            this.vizualizareTranzactiiToolStripMenuItem.Click += new System.EventHandler(this.vizualizareTranzactiiToolStripMenuItem_Click);
            // 
            // schimbaTipulTranzactieiToolStripMenuItem
            // 
            this.schimbaTipulTranzactieiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareSolduriToolStripMenuItem,
            this.retragereSolduriToolStripMenuItem});
            this.schimbaTipulTranzactieiToolStripMenuItem.Name = "schimbaTipulTranzactieiToolStripMenuItem";
            this.schimbaTipulTranzactieiToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.schimbaTipulTranzactieiToolStripMenuItem.Text = "Schimba tipul tranzactiei";
            // 
            // adaugareSolduriToolStripMenuItem
            // 
            this.adaugareSolduriToolStripMenuItem.Name = "adaugareSolduriToolStripMenuItem";
            this.adaugareSolduriToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.adaugareSolduriToolStripMenuItem.Text = "Adaugare solduri";
            this.adaugareSolduriToolStripMenuItem.Click += new System.EventHandler(this.adaugareSolduriToolStripMenuItem_Click);
            // 
            // retragereSolduriToolStripMenuItem
            // 
            this.retragereSolduriToolStripMenuItem.Name = "retragereSolduriToolStripMenuItem";
            this.retragereSolduriToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.retragereSolduriToolStripMenuItem.Text = "Retragere solduri";
            this.retragereSolduriToolStripMenuItem.Click += new System.EventHandler(this.retragereSolduriToolStripMenuItem_Click);
            // 
            // editareTranzactieToolStripMenuItem
            // 
            this.editareTranzactieToolStripMenuItem.Name = "editareTranzactieToolStripMenuItem";
            this.editareTranzactieToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.editareTranzactieToolStripMenuItem.Text = "Editare Tranzactie";
            this.editareTranzactieToolStripMenuItem.Click += new System.EventHandler(this.editareTranzactieToolStripMenuItem_Click);
            // 
            // printeazaFisierToolStripMenuItem
            // 
            this.printeazaFisierToolStripMenuItem.Name = "printeazaFisierToolStripMenuItem";
            this.printeazaFisierToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.printeazaFisierToolStripMenuItem.Text = "Printeaza fisier";
            this.printeazaFisierToolStripMenuItem.Click += new System.EventHandler(this.printeazaFisierToolStripMenuItem_Click);
            // 
            // Inregistrare_Tranzactie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 404);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btn_clearAll);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_creditor);
            this.Controls.Add(this.tBox_data);
            this.Controls.Add(this.lbl_val);
            this.Controls.Add(this.tBox_creditor);
            this.Controls.Add(this.tBox_val);
            this.Controls.Add(this.lbl_debitor);
            this.Controls.Add(this.tBox_debitor);
            this.KeyPreview = true;
            this.Name = "Inregistrare_Tranzactie";
            this.Text = "Formular de Tranzactie";
            this.Load += new System.EventHandler(this.Formular_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inregistrare_Tranzactie_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_creditor;
        private System.Windows.Forms.Label lbl_val;
        private System.Windows.Forms.Label lbl_debitor;
        private System.Windows.Forms.TextBox tBox_debitor;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox tBox_data;
        private System.Windows.Forms.TextBox tBox_creditor;
        private System.Windows.Forms.TextBox tBox_val;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareTranzactiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaTipulTranzactieiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareSolduriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retragereSolduriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareTranzactieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printeazaFisierToolStripMenuItem;
    }
}