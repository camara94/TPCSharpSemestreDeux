namespace MesJeux
{
    partial class changePwd
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
            this.ancinpwd = new System.Windows.Forms.Label();
            this.nvpwd = new System.Windows.Forms.Label();
            this.confpwd = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ancinpwd
            // 
            this.ancinpwd.AutoSize = true;
            this.ancinpwd.Location = new System.Drawing.Point(36, 46);
            this.ancinpwd.Name = "ancinpwd";
            this.ancinpwd.Size = new System.Drawing.Size(111, 13);
            this.ancinpwd.TabIndex = 0;
            this.ancinpwd.Text = "ancien mot_de_passe";
            // 
            // nvpwd
            // 
            this.nvpwd.AutoSize = true;
            this.nvpwd.Location = new System.Drawing.Point(36, 83);
            this.nvpwd.Name = "nvpwd";
            this.nvpwd.Size = new System.Drawing.Size(121, 13);
            this.nvpwd.TabIndex = 1;
            this.nvpwd.Text = "Nouvelle mot_de_passe";
            // 
            // confpwd
            // 
            this.confpwd.AutoSize = true;
            this.confpwd.Location = new System.Drawing.Point(36, 117);
            this.confpwd.Name = "confpwd";
            this.confpwd.Size = new System.Drawing.Size(150, 13);
            this.confpwd.TabIndex = 2;
            this.confpwd.Text = "Confirmer votre mot_de_passe";
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(101, 169);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 3;
            this.valider.Text = "valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // changePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 236);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.confpwd);
            this.Controls.Add(this.nvpwd);
            this.Controls.Add(this.ancinpwd);
            this.Name = "changePwd";
            this.Text = "changePwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ancinpwd;
        private System.Windows.Forms.Label nvpwd;
        private System.Windows.Forms.Label confpwd;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}