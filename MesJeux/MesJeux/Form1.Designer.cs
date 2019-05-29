namespace MesJeux
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
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cahngerCouleurDeFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.labChiffre = new System.Windows.Forms.Label();
            this.Neuf = new System.Windows.Forms.RadioButton();
            this.Huit = new System.Windows.Forms.RadioButton();
            this.Sept = new System.Windows.Forms.RadioButton();
            this.Six = new System.Windows.Forms.RadioButton();
            this.Cinq = new System.Windows.Forms.RadioButton();
            this.Quatre = new System.Windows.Forms.RadioButton();
            this.Trois = new System.Windows.Forms.RadioButton();
            this.Deux = new System.Windows.Forms.RadioButton();
            this.Un = new System.Windows.Forms.RadioButton();
            this.Zero = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerMotDePasseToolStripMenuItem,
            this.cahngerCouleurDeFondToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.jeuToolStripMenuItem.Text = "jeu";
            // 
            // changerMotDePasseToolStripMenuItem
            // 
            this.changerMotDePasseToolStripMenuItem.Name = "changerMotDePasseToolStripMenuItem";
            this.changerMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.changerMotDePasseToolStripMenuItem.Text = "Changer mot de passe";
            this.changerMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerMotDePasseToolStripMenuItem_Click);
            // 
            // cahngerCouleurDeFondToolStripMenuItem
            // 
            this.cahngerCouleurDeFondToolStripMenuItem.Name = "cahngerCouleurDeFondToolStripMenuItem";
            this.cahngerCouleurDeFondToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cahngerCouleurDeFondToolStripMenuItem.Text = "Cahnger couleur de fond";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 300);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Drapeau";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Valider la réponse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Location = new System.Drawing.Point(6, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Réponse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(500, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lybie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(362, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yemen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(199, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Egypte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(70, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tunisie";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Location = new System.Drawing.Point(466, 38);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox8_DragDrop_1);
            this.pictureBox8.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox8_DragEnter_1);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Location = new System.Drawing.Point(331, 38);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox7_DragDrop_1);
            this.pictureBox7.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox7_DragEnter_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(35, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox5_DragDrop_1);
            this.pictureBox5.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox5_DragEnter_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(171, 38);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox6_DragDrop_1);
            this.pictureBox6.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox6_DragEnter_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MesJeux.Properties.Resources.egypte;
            this.pictureBox4.Location = new System.Drawing.Point(472, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MesJeux.Properties.Resources.lybie;
            this.pictureBox3.Location = new System.Drawing.Point(337, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MesJeux.Properties.Resources.yemen;
            this.pictureBox2.Location = new System.Drawing.Point(177, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MesJeux.Properties.Resources.téléchargement;
            this.pictureBox1.Location = new System.Drawing.Point(41, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.labChiffre);
            this.tabPage2.Controls.Add(this.Neuf);
            this.tabPage2.Controls.Add(this.Huit);
            this.tabPage2.Controls.Add(this.Sept);
            this.tabPage2.Controls.Add(this.Six);
            this.tabPage2.Controls.Add(this.Cinq);
            this.tabPage2.Controls.Add(this.Quatre);
            this.tabPage2.Controls.Add(this.Trois);
            this.tabPage2.Controls.Add(this.Deux);
            this.tabPage2.Controls.Add(this.Un);
            this.tabPage2.Controls.Add(this.Zero);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "chiffres";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Le chiffre afficher est:";
            // 
            // labChiffre
            // 
            this.labChiffre.AutoSize = true;
            this.labChiffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 90.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labChiffre.Location = new System.Drawing.Point(26, 114);
            this.labChiffre.MaximumSize = new System.Drawing.Size(100, 500);
            this.labChiffre.Name = "labChiffre";
            this.labChiffre.Size = new System.Drawing.Size(100, 138);
            this.labChiffre.TabIndex = 120;
            this.labChiffre.Text = "0";
            // 
            // Neuf
            // 
            this.Neuf.AutoSize = true;
            this.Neuf.Location = new System.Drawing.Point(458, 240);
            this.Neuf.Name = "Neuf";
            this.Neuf.Size = new System.Drawing.Size(48, 17);
            this.Neuf.TabIndex = 11;
            this.Neuf.TabStop = true;
            this.Neuf.Text = "Neuf";
            this.Neuf.UseVisualStyleBackColor = true;
            this.Neuf.CheckedChanged += new System.EventHandler(this.Neuf_CheckedChanged);
            // 
            // Huit
            // 
            this.Huit.AutoSize = true;
            this.Huit.Location = new System.Drawing.Point(458, 217);
            this.Huit.Name = "Huit";
            this.Huit.Size = new System.Drawing.Size(44, 17);
            this.Huit.TabIndex = 10;
            this.Huit.TabStop = true;
            this.Huit.Text = "Huit";
            this.Huit.UseVisualStyleBackColor = true;
            this.Huit.CheckedChanged += new System.EventHandler(this.Huit_CheckedChanged);
            // 
            // Sept
            // 
            this.Sept.AutoSize = true;
            this.Sept.Location = new System.Drawing.Point(458, 192);
            this.Sept.Name = "Sept";
            this.Sept.Size = new System.Drawing.Size(47, 17);
            this.Sept.TabIndex = 9;
            this.Sept.TabStop = true;
            this.Sept.Text = "Sept";
            this.Sept.UseVisualStyleBackColor = true;
            this.Sept.CheckedChanged += new System.EventHandler(this.Sept_CheckedChanged);
            // 
            // Six
            // 
            this.Six.AutoSize = true;
            this.Six.Location = new System.Drawing.Point(458, 169);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(39, 17);
            this.Six.TabIndex = 8;
            this.Six.TabStop = true;
            this.Six.Text = "Six";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.CheckedChanged += new System.EventHandler(this.Six_CheckedChanged);
            // 
            // Cinq
            // 
            this.Cinq.AutoSize = true;
            this.Cinq.Location = new System.Drawing.Point(458, 137);
            this.Cinq.Name = "Cinq";
            this.Cinq.Size = new System.Drawing.Size(46, 17);
            this.Cinq.TabIndex = 7;
            this.Cinq.TabStop = true;
            this.Cinq.Text = "Cinq";
            this.Cinq.UseVisualStyleBackColor = true;
            this.Cinq.CheckedChanged += new System.EventHandler(this.Cinq_CheckedChanged);
            // 
            // Quatre
            // 
            this.Quatre.AutoSize = true;
            this.Quatre.Location = new System.Drawing.Point(458, 114);
            this.Quatre.Name = "Quatre";
            this.Quatre.Size = new System.Drawing.Size(57, 17);
            this.Quatre.TabIndex = 6;
            this.Quatre.TabStop = true;
            this.Quatre.Text = "Quatre";
            this.Quatre.UseVisualStyleBackColor = true;
            this.Quatre.CheckedChanged += new System.EventHandler(this.Quatre_CheckedChanged);
            // 
            // Trois
            // 
            this.Trois.AutoSize = true;
            this.Trois.Location = new System.Drawing.Point(458, 91);
            this.Trois.Name = "Trois";
            this.Trois.Size = new System.Drawing.Size(48, 17);
            this.Trois.TabIndex = 5;
            this.Trois.TabStop = true;
            this.Trois.Text = "Trois";
            this.Trois.UseVisualStyleBackColor = true;
            this.Trois.CheckedChanged += new System.EventHandler(this.Trois_CheckedChanged);
            // 
            // Deux
            // 
            this.Deux.AutoSize = true;
            this.Deux.Location = new System.Drawing.Point(458, 68);
            this.Deux.Name = "Deux";
            this.Deux.Size = new System.Drawing.Size(50, 17);
            this.Deux.TabIndex = 4;
            this.Deux.TabStop = true;
            this.Deux.Text = "Deux";
            this.Deux.UseVisualStyleBackColor = true;
            this.Deux.CheckedChanged += new System.EventHandler(this.Deux_CheckedChanged);
            // 
            // Un
            // 
            this.Un.AutoSize = true;
            this.Un.Location = new System.Drawing.Point(458, 45);
            this.Un.Name = "Un";
            this.Un.Size = new System.Drawing.Size(39, 17);
            this.Un.TabIndex = 3;
            this.Un.TabStop = true;
            this.Un.Text = "Un";
            this.Un.UseVisualStyleBackColor = true;
            this.Un.CheckedChanged += new System.EventHandler(this.Un_CheckedChanged);
            // 
            // Zero
            // 
            this.Zero.AutoSize = true;
            this.Zero.Location = new System.Drawing.Point(458, 21);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(47, 17);
            this.Zero.TabIndex = 2;
            this.Zero.TabStop = true;
            this.Zero.Text = "Zéro";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.CheckedChanged += new System.EventHandler(this.Zero_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Arréter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(21, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Démarrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 374);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cahngerCouleurDeFondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labChiffre;
        private System.Windows.Forms.RadioButton Neuf;
        private System.Windows.Forms.RadioButton Huit;
        private System.Windows.Forms.RadioButton Sept;
        private System.Windows.Forms.RadioButton Six;
        private System.Windows.Forms.RadioButton Cinq;
        private System.Windows.Forms.RadioButton Quatre;
        private System.Windows.Forms.RadioButton Trois;
        private System.Windows.Forms.RadioButton Deux;
        private System.Windows.Forms.RadioButton Un;
        private System.Windows.Forms.RadioButton Zero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

