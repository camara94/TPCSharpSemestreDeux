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
    public partial class docBase : Form
    {
        public docBase()
        {
            InitializeComponent();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            string connexionstring = null;
            OleDbConnection connexion;
            connexionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=basedoc.accdb;Persist Security Info = False";
            string req = "select * from doc where propretaire ='" + textBox1.Text + "'";
            connexion = new OleDbConnection(connexionstring);
            OleDbCommand command = connexion.CreateCommand();
            command.CommandText = req;
            connexion.Open();

            OleDbDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                dataGridView1.Rows.Add(r[0].ToString(),r[1].ToString(),r[2].ToString(),r[3].ToString());
            }
            connexion.Close();
            connexion.Dispose();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (res == DialogResult.OK)
                {
                    string connexionstring = null;
                    OleDbConnection connexion;
                    connexionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseDoc.accdb;Persist Security Info = False";
                    connexion = new OleDbConnection(connexionstring);

                    OleDbCommand command = connexion.CreateCommand();
                    connexion.Open();
                    string requete = "delete  from doc where ID ='" + dataGridView1.SelectedRows[0].Cells[0].Value + " ' ";
                    command.CommandText = requete;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                    connexion.Close();

                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                }
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Form2 f2 = new Form2();
                f2.id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                f2.proprietaire = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                f2.datecreation = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                f2.text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                f2.ShowDialog();
            }
            else
            { MessageBox.Show("il faut séléctionner une ligne!!"); }
        }
    }
}
