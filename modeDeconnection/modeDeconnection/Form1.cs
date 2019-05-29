using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace modeDeconnection
{
    public partial class Form1 : Form
    {
        
        private OleDbConnection cnx;
        
        private OleDbCommand cmd;

        private OleDbDataAdapter dta;

        private DataSet dts = new DataSet();

        private String sql;

        private DataTable dtt;

        private DataRow dtr;

        private String cnxstr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnxstr = "Provider=Microsoft.ACE.oledb.12.0.0;data source=gestionDocBD.accdb";
            cnx = new OleDbConnection();
            cnx.ConnectionString = cnxstr;
            
            sql ="select doc.*, proprietaire.* from doc inner join proprietaire on doc.propriétaire=proprietaire.id" ;
            cmd = new OleDbCommand(sql);
            dta = new OleDbDataAdapter(cmd);
            cmd.Connection = cnx;
            dta.Fill(dts);
            dataGridView1.DataSource = dts;
            dataGridView1.DataMember = dts.Tables[0].TableName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }

        private void master_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = "Provider=Microsoft.ACE.oledb.12.0.0;data source=gestionDocBD.accdb";
                OleDbConnection connection = new OleDbConnection(connectionString);

                // Create a DataSet.
                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                // Add data from the Customers table to the DataSet.
                OleDbDataAdapter masterDataAdapter = new
                    OleDbDataAdapter("select * from proprietaire", connection);
                masterDataAdapter.Fill(data, "proprietaire");

                // Add data from the Orders table to the DataSet.
                OleDbDataAdapter detailsDataAdapter = new
                    OleDbDataAdapter("select * from doc", connection);
                detailsDataAdapter.Fill(data, "doc");

                // Establish a relationship between the two tables.
                DataRelation relation = new DataRelation("docproprietaire",
                    data.Tables["proprietaire"].Columns["id"],
                    data.Tables["doc"].Columns["Propriétaire"]);
                data.Relations.Add(relation);

                // Bind the master data connector to the Customers table.
                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "proprietaire"; 

                // Bind the details data connector to the master data connector,
                // using the DataRelation name to filter the information in the 
                // details table based on the current row in the master table. 
                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "docproprietaire";

                //liaison gridview*
                dataGridView2.DataSource = masterBindingSource;
                dataGridView3.DataSource = detailsBindingSource;
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dta.Update(dts, "doc");
        }
    }
}
