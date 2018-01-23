using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; 

namespace CSharp_sqlServer_Connection
{
    public partial class frmGetCSharpData : Form
    {
        SqlConnection sqlConn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UsingADO;Integrated Security=True");
        
        string strSelectCmd = "SELECT ContactID, FName, LName FROM Customers ORDER BY LName";

        public frmGetCSharpData()
        {
            InitializeComponent();
        }

        private void cmdPress_Click(object sender, EventArgs e)
        {


            sqlConn.Open();

            displayState(sqlConn);

            txtDisplay .Text = displayData(strSelectCmd, sqlConn).ToString ();

            sqlConn.Close();

            displayState(sqlConn);
        }

        private void displayState(SqlConnection Connection)
        {

            switch (sqlConn.State) // check the state of the connection
            {
                case ConnectionState.Closed:

                    MessageBox.Show("Your connection to " + Connection.Database.ToString() + " is closed");

                    break;
                case ConnectionState.Open:

                    MessageBox.Show("Your connection to "+ Connection.Database.ToString() + " is open");

                    break;
                //default:
                //break;
            }
        }

        private StringWriter displayData(string command, SqlConnection connection)
        {
            StringWriter sWriter = new StringWriter();

            SqlDataAdapter daContacts = new SqlDataAdapter(command, connection);

            DataSet dsTheDataSet = new DataSet("TheDataSet");

            sWriter.WriteLine("Name of DataSet = " + dsTheDataSet.DataSetName.ToString());

            daContacts.Fill(dsTheDataSet, "Customers");

            sWriter.WriteLine("");
            sWriter.WriteLine("{0}", dsTheDataSet.Tables[0].TableName);
            sWriter.WriteLine("*************");

            foreach (DataRow row in dsTheDataSet.Tables[0].Rows) 
            {
                sWriter.WriteLine("Customer No. {0} {1} {2}", row["ContactID"], row["FName"], row["LName"]);
            }

            return sWriter;

        }

        private void cmdShowCode_Click(object sender, EventArgs e)
        {

            Form frmCSharpCode = new frmCSharpCode();

            frmCSharpCode.ShowDialog(this);

        }
    }
}
