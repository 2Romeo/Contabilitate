namespace PawContabilitate
{
    partial class Aplicatie_Contabilitate
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeazaFisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeazaFisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_BD = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adauga Cont";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Adauga Tranzactie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeazaFisiereToolStripMenuItem,
            this.deserializeazaFisiereToolStripMenuItem,
            this.restaureazaDateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 76);
            // 
            // serializeazaFisiereToolStripMenuItem
            // 
            this.serializeazaFisiereToolStripMenuItem.Name = "serializeazaFisiereToolStripMenuItem";
            this.serializeazaFisiereToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.serializeazaFisiereToolStripMenuItem.Text = "Serializeaza fisiere";
            this.serializeazaFisiereToolStripMenuItem.Click += new System.EventHandler(this.serializeazaFisiereToolStripMenuItem_Click);
            // 
            // deserializeazaFisiereToolStripMenuItem
            // 
            this.deserializeazaFisiereToolStripMenuItem.Name = "deserializeazaFisiereToolStripMenuItem";
            this.deserializeazaFisiereToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.deserializeazaFisiereToolStripMenuItem.Text = "Deserializeaza fisiere";
            this.deserializeazaFisiereToolStripMenuItem.Click += new System.EventHandler(this.deserializeazaFisiereToolStripMenuItem_Click);
            // 
            // restaureazaDateToolStripMenuItem
            // 
            this.restaureazaDateToolStripMenuItem.Name = "restaureazaDateToolStripMenuItem";
            this.restaureazaDateToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.restaureazaDateToolStripMenuItem.Text = "Restaureaza date";
            this.restaureazaDateToolStripMenuItem.Click += new System.EventHandler(this.restaureazaDateToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Conturi",
            "Inregistrari"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.Text = "Date analizate";
            this.toolStripComboBox1.ToolTipText = "\r\n";
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 25);
            this.toolStripLabel1.Text = "Rearanjare liste";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // btn_BD
            // 
            this.btn_BD.Location = new System.Drawing.Point(355, 267);
            this.btn_BD.Name = "btn_BD";
            this.btn_BD.Size = new System.Drawing.Size(96, 46);
            this.btn_BD.TabIndex = 3;
            this.btn_BD.Text = "Conectare BD";
            this.btn_BD.UseVisualStyleBackColor = true;
            this.btn_BD.Click += new System.EventHandler(this.btn_BD_Click);
            // 
            // Aplicatie_Contabilitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btn_BD);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Aplicatie_Contabilitate";
            this.Text = "Aplicatie_Contabilitate";
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeazaFisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeazaFisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem restaureazaDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btn_BD;
    }
}