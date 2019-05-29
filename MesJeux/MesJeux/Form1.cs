using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MesJeux
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            th = new Thread(Afficher);
                   
        }
      
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (th.ThreadState != ThreadState.Unstarted)
             if(th.ThreadState==ThreadState.Suspended)
                {
                    th.Resume();
                    th.Abort();
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void Zero_CheckedChanged(object sender, EventArgs e)
        {
            if (Zero.Checked )
            {
                if (labChiffre.Text == "0")
                {
                    MessageBox.Show("bravo");
                }
                else MessageBox.Show("Réponse incorrect... !!! Essayer encore");
            }
        }

        private void Un_CheckedChanged(object sender, EventArgs e)
        {
            if (Un.Checked)
            {
                if (labChiffre.Text == "1")
                {
                    MessageBox.Show("bravo");
                }
                else MessageBox.Show("Réponse incorrect... !!! Essayer encore");
            }
        }

        private void Deux_CheckedChanged(object sender, EventArgs e)
        {
            if (Deux.Checked)
            {
                if (labChiffre.Text == "2")
                {
                    MessageBox.Show("bravo");
                }
                else MessageBox.Show("Réponse incorrect... !!! Essayer encore");
            }
        }

        private void Trois_CheckedChanged(object sender, EventArgs e)
        {
            if (Trois.Checked)
            {
                if (labChiffre.Text == "3")
                {
                    MessageBox.Show("bravo");
                }
                else MessageBox.Show("Réponse incorrect... !!! Essayer encore");
            }
        }

        private void Quatre_CheckedChanged(object sender, EventArgs e)
        {
            if (Quatre.Checked)
            {
                if (labChiffre.Text == "4")
                {
                    MessageBox.Show("bravo");
                }
                else MessageBox.Show("Réponse incorrect... !!! Essayer encore");
            }
        }

        private void Cinq_CheckedChanged(object sender, EventArgs e)
        {
            if (Cinq.Checked)
            {
                if (labChiffre.Text == "5")
                {
                    MessageBox.Show("bravo");
                }
                else MessageBox.Show("Réponse incorrect... !!! Essayer encore");
            }
        }

        private void Six_CheckedChanged(object sender, EventArgs e)
        {
            if (Six.Checked)
            {
                if (labChiffre.Text == "6")
                {
                    MessageBox.Show("bravo");
                }
                else MessageBox.Show("Réponse incorrect... !!! Essayer encore");
            }
        }

        private void Sept_CheckedChanged(object sender, EventArgs e)
        {
            if (Sept.Checked)
            {
                if (labChiffre.Text == "7")
                {
                    MessageBox.Show("bravo");
                }
                else MessageBox.Show("Réponse incorrect... !!! Essayer encore");
            }
        }

        private void Huit_CheckedChanged(object sender, EventArgs e)
        {
            if (Huit.Checked)
            {
                if (labChiffre.Text == "8")
                {
                    MessageBox.Show("bravo");
                }
                else MessageBox.Show("Réponse incorrect... !!! Essayer encore");
            }
        }

        private void Neuf_CheckedChanged(object sender, EventArgs e)
        {
            if (Neuf.Checked)
            {
                if (labChiffre.Text == "9")
                {
                    MessageBox.Show("bravo");
                }
                else MessageBox.Show("Réponse incorrect... !!! Essayer encore");
            }
        }
        Thread th;
        public void Afficher()
        {
            int i = 0;
            while(true)
            {
                i++;
                System.Threading.Thread.Sleep(100);
                Invoke((MontrerLabel)Progres, i);
                if (i == 9)
                    i = 0;
            }
        }
        public delegate void MontrerLabel(int valeur);
        public void Progres(int valeur)
        {
            labChiffre.Text = valeur.ToString();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (th.ThreadState == ThreadState.Suspended)
            {
                th.Resume();
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th.Suspend();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmAuth fau = new FrmAuth();
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;

            if (fau.ShowDialog() == DialogResult.OK)
            {
                th.Start();
            }
            else
            {
                
                this.Close();
            }
        }

        private void changerMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePwd ch1 = new changePwd();
            ch1.Show();

        }
        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.All);}

        private void pictureBox2_MouseDown_1(object sender, MouseEventArgs e)
        {pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.All);}

        private void pictureBox3_MouseDown_1(object sender, MouseEventArgs e)
        {pictureBox3.DoDragDrop(pictureBox3.Image, DragDropEffects.All);}

        private void pictureBox4_MouseDown_1(object sender, MouseEventArgs e)
        {pictureBox4.DoDragDrop(pictureBox4.Image, DragDropEffects.All);}

        private void pictureBox5_DragDrop_1(object sender, DragEventArgs e)
        { this.pictureBox5.Image = (Bitmap)(e.Data.GetData(DataFormats.Bitmap)); }

        private void pictureBox5_DragEnter_1(object sender, DragEventArgs e)
        { e.Effect = DragDropEffects.Copy; }

        private void pictureBox6_DragDrop_1(object sender, DragEventArgs e)
        {this.pictureBox6.Image = (Bitmap)(e.Data.GetData(DataFormats.Bitmap));}

        private void pictureBox6_DragEnter_1(object sender, DragEventArgs e)
        {e.Effect = DragDropEffects.Copy;}

        private void pictureBox7_DragDrop_1(object sender, DragEventArgs e)
        { this.pictureBox7.Image = (Bitmap)(e.Data.GetData(DataFormats.Bitmap));  }

        private void pictureBox7_DragEnter_1(object sender, DragEventArgs e)
        {    e.Effect = DragDropEffects.Copy; }

        private void pictureBox8_DragDrop_1(object sender, DragEventArgs e)
        {this.pictureBox8.Image = (Bitmap)(e.Data.GetData(DataFormats.Bitmap));}

        private void pictureBox8_DragEnter_1(object sender, DragEventArgs e)
        {  e.Effect = DragDropEffects.Copy; }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((pictureBox5.Image == pictureBox1.Image) && (pictureBox6.Image == pictureBox4.Image) && (pictureBox7.Image == pictureBox2.Image) && (pictureBox8.Image == pictureBox3.Image))
            {
                MessageBox.Show("bravo");
            }
            else
            { MessageBox.Show("reponse incorrect !!!!"); }    
            }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            th.Abort();
        }
    }
}
