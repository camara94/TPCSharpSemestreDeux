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
    public partial class Form2 : Form
    {
        public string id;
        public string proprietaire;
        public string datecreation;
        public string text;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = id;
            textBox2.Text = proprietaire;
            richTextBox1.Text = text;
            label4.Text = datecreation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connexionstring = null;
            OleDbConnection connexion;
            connexionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gestionDocBD.accdb;Persist Security Info = False";
            connexion = new OleDbConnection(connexionstring);

            OleDbCommand command = connexion.CreateCommand();
            connexion.Open();
            string requete = "update doc set texteDoc";
        }
    }
}
