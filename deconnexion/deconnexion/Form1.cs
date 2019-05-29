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

namespace deconnexion
{
    public partial class Form1 : Form
    {

        private OleDbConnection cnx;

        private OleDbCommand cmd;

        private OleDbDataAdapter dta;

        private DataSet dts = new DataSet();

        public object DataGridView1 { get; private set; }

        //private String cnxstr;





        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            
        {
           
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cmdb = new OleDbCommandBuilder(dta);
            dta.Update(dts);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String cnxstr = "Provider=Microsoft.ACE.oledb.12.0.0;data source=BaseDoc.accdb";
             OleDbConnection cnx = new OleDbConnection(cnxstr);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from Doc";
            cnx.ConnectionString = cnxstr;
            cmd.Connection = cnx;

             dta = new OleDbDataAdapter(cmd);
           
            
            dta.Fill(dts);
            dataGridView1.DataSource = dts;
            dataGridView1.DataMember = dts.Tables[0].TableName;
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = "Provider=Microsoft.ACE.oledb.12.0.0;data source=BaseDoc.accdb";

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
                DataRelation relation = new DataRelation("propdoc",
                    data.Tables["proprietaire"].Columns["id"],
                    data.Tables["doc"].Columns["propretaire"]);
                data.Relations.Add(relation);
                // Bind the master data connector to the Customers table.
                MasterbindingSource.DataSource = data;
                MasterbindingSource.DataMember = "proprietaire";

                // Bind the details data connector to the master data connector,
                // using the DataRelation name to filter the information in the 
                // details table based on the current row in the master table. 
                DetaillebindingSource.DataSource = MasterbindingSource;
                DetaillebindingSource.DataMember = "propdoc";

                masterDataGridView.DataSource = MasterbindingSource;
                detailleDataGridView.DataSource = DetaillebindingSource;

            }
            catch (OleDbException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
    }
}
