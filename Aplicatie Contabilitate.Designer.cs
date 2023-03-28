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
            this.contextMenuStrip1.SuspendLayout();
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
            this.deserializeazaFisiereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 52);
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
            // Aplicatie_Contabilitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Aplicatie_Contabilitate";
            this.Text = "Aplicatie_Contabilitate";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeazaFisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeazaFisiereToolStripMenuItem;
    }
}