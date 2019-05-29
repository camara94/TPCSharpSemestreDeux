using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesJeux
{
    public partial class FrmAuth : Form
    {
      
        public FrmAuth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox2.Text == "admin"))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("verfifier votre login et mot de passe !");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
