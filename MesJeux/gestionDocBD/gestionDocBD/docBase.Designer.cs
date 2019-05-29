namespace gestionDocBD
{
    partial class docBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Afficher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TexteDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propretaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des documents par propriétaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propriétaire";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Afficher
            // 
            this.Afficher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Afficher.Location = new System.Drawing.Point(352, 80);
            this.Afficher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(56, 19);
            this.Afficher.TabIndex = 3;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = false;
            this.Afficher.Click += new System.EventHandler(this.Afficher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TexteDoc,
            this.dateCreation,
            this.propretaire});
            this.dataGridView1.Location = new System.Drawing.Point(25, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 238);
            this.dataGridView1.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id document";
            this.Id.Name = "Id";
            // 
            // TexteDoc
            // 
            this.TexteDoc.HeaderText = "Texte";
            this.TexteDoc.Name = "TexteDoc";
            // 
            // dateCreation
            // 
            this.dateCreation.HeaderText = "Date de création";
            this.dateCreation.Name = "dateCreation";
            // 
            // propretaire
            // 
            this.propretaire.HeaderText = "Proprétaire";
            this.propretaire.Name = "propretaire";
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(504, 119);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(64, 19);
            this.Supprimer.TabIndex = 5;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(504, 228);
            this.Modifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(64, 19);
            this.Modifier.TabIndex = 6;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(504, 336);
            this.Quitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(64, 19);
            this.Quitter.TabIndex = 7;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // docBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 384);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "docBase";
            this.Text = "docBase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Afficher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TexteDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn propretaire;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Quitter;
    }
}