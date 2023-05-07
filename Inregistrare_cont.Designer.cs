namespace PawContabilitate
{
    partial class Inregistrare_cont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inregistrare_cont));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_numar = new System.Windows.Forms.TextBox();
            this.tb_denumire = new System.Windows.Forms.TextBox();
            this.tb_soldDebitor = new System.Windows.Forms.TextBox();
            this.tb_soldCreditor = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vizualizareConturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sold debitor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sold creditor";
            // 
            // tb_numar
            // 
            this.tb_numar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_numar.Location = new System.Drawing.Point(188, 50);
            this.tb_numar.Name = "tb_numar";
            this.tb_numar.Size = new System.Drawing.Size(294, 22);
            this.tb_numar.TabIndex = 2;
            // 
            // tb_denumire
            // 
            this.tb_denumire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_denumire.Location = new System.Drawing.Point(188, 96);
            this.tb_denumire.Name = "tb_denumire";
            this.tb_denumire.Size = new System.Drawing.Size(294, 22);
            this.tb_denumire.TabIndex = 3;
            // 
            // tb_soldDebitor
            // 
            this.tb_soldDebitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_soldDebitor.Location = new System.Drawing.Point(188, 146);
            this.tb_soldDebitor.Name = "tb_soldDebitor";
            this.tb_soldDebitor.Size = new System.Drawing.Size(294, 22);
            this.tb_soldDebitor.TabIndex = 2;
            // 
            // tb_soldCreditor
            // 
            this.tb_soldCreditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_soldCreditor.Location = new System.Drawing.Point(188, 192);
            this.tb_soldCreditor.Name = "tb_soldCreditor";
            this.tb_soldCreditor.Size = new System.Drawing.Size(294, 22);
            this.tb_soldCreditor.TabIndex = 3;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(188, 265);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(127, 66);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(346, 265);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(127, 66);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareConturiToolStripMenuItem,
            this.stergereContToolStripMenuItem,
            this.editareContToolStripMenuItem,
            this.printDocumentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 128);
            // 
            // vizualizareConturiToolStripMenuItem
            // 
            this.vizualizareConturiToolStripMenuItem.Name = "vizualizareConturiToolStripMenuItem";
            this.vizualizareConturiToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.vizualizareConturiToolStripMenuItem.Text = "Vizualizare conturi";
            this.vizualizareConturiToolStripMenuItem.Click += new System.EventHandler(this.vizualizareConturiToolStripMenuItem_Click);
            // 
            // stergereContToolStripMenuItem
            // 
            this.stergereContToolStripMenuItem.Name = "stergereContToolStripMenuItem";
            this.stergereContToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.stergereContToolStripMenuItem.Text = "Stergere cont";
            this.stergereContToolStripMenuItem.Click += new System.EventHandler(this.stergereContToolStripMenuItem_Click);
            // 
            // editareContToolStripMenuItem
            // 
            this.editareContToolStripMenuItem.Name = "editareContToolStripMenuItem";
            this.editareContToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.editareContToolStripMenuItem.Text = "Editare cont existent";
            this.editareContToolStripMenuItem.Click += new System.EventHandler(this.editareContToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocumentToolStripMenuItem
            // 
            this.printDocumentToolStripMenuItem.Name = "printDocumentToolStripMenuItem";
            this.printDocumentToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.printDocumentToolStripMenuItem.Text = "Print Document";
            this.printDocumentToolStripMenuItem.Click += new System.EventHandler(this.printDocumentToolStripMenuItem_Click);
            // 
            // Inregistrare_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_soldCreditor);
            this.Controls.Add(this.tb_soldDebitor);
            this.Controls.Add(this.tb_denumire);
            this.Controls.Add(this.tb_numar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Inregistrare_cont";
            this.Text = "Inregistrare cont";
            this.Load += new System.EventHandler(this.Inregistrare_cont_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inregistrare_cont_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_numar;
        private System.Windows.Forms.TextBox tb_denumire;
        private System.Windows.Forms.TextBox tb_soldDebitor;
        private System.Windows.Forms.TextBox tb_soldCreditor;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareConturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareContToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem printDocumentToolStripMenuItem;
    }
}