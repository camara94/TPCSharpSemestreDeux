using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace gestionDocBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nouveauDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            label4.Text = System.DateTime.Now.ToString();
            groupBox1.Visible = true;
        }

        private void enregistrerLeDocDansLaBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "")&&(richTextBox1.Text!=""))
            {
                string connexionstring = null;
                OleDbConnection connexion;
                connexionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseDoc.accdb";
                connexion = new OleDbConnection(connexionstring);

                OleDbCommand command = connexion.CreateCommand();
                connexion.Open();
                string req = "insert into doc values('" + textBox1.Text + "','" + richTextBox1.Text + "','" + System.DateTime.Now.ToString() + "','" + textBox2.Text + "')";
                command.CommandText = req;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connexion.Close();
                connexion.Dispose();
            }
        }

        private void afficherMesDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docBase AffDocument = new docBase();

            AffDocument.ShowDialog();
        }
    }
}
