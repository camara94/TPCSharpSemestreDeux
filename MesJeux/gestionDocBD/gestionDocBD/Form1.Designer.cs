namespace gestionDocBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerLeDocDansLaBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherMesDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDocumentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDocumentToolStripMenuItem
            // 
            this.gestionDocumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauDocumentToolStripMenuItem,
            this.enregistrerLeDocDansLaBaseToolStripMenuItem,
            this.afficherMesDocumentToolStripMenuItem});
            this.gestionDocumentToolStripMenuItem.Name = "gestionDocumentToolStripMenuItem";
            this.gestionDocumentToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.gestionDocumentToolStripMenuItem.Text = "Gestion Document";
            // 
            // nouveauDocumentToolStripMenuItem
            // 
            this.nouveauDocumentToolStripMenuItem.Name = "nouveauDocumentToolStripMenuItem";
            this.nouveauDocumentToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.nouveauDocumentToolStripMenuItem.Text = "Nouveau Document";
            this.nouveauDocumentToolStripMenuItem.Click += new System.EventHandler(this.nouveauDocumentToolStripMenuItem_Click);
            // 
            // enregistrerLeDocDansLaBaseToolStripMenuItem
            // 
            this.enregistrerLeDocDansLaBaseToolStripMenuItem.Name = "enregistrerLeDocDansLaBaseToolStripMenuItem";
            this.enregistrerLeDocDansLaBaseToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.enregistrerLeDocDansLaBaseToolStripMenuItem.Text = "Enregistrer le doc dans la base";
            this.enregistrerLeDocDansLaBaseToolStripMenuItem.Click += new System.EventHandler(this.enregistrerLeDocDansLaBaseToolStripMenuItem_Click);
            // 
            // afficherMesDocumentToolStripMenuItem
            // 
            this.afficherMesDocumentToolStripMenuItem.Name = "afficherMesDocumentToolStripMenuItem";
            this.afficherMesDocumentToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.afficherMesDocumentToolStripMenuItem.Text = "Afficher Mes Document";
            this.afficherMesDocumentToolStripMenuItem.Click += new System.EventHandler(this.afficherMesDocumentToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Document";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propriétaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Création";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(304, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(743, 267);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerLeDocDansLaBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherMesDocumentToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

