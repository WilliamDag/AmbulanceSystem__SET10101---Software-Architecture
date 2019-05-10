using KwikMedical_Ambulance_Interface.KwikMedicalServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KwikMedical_Ambulance_Interface
{
    public partial class Search : Form
    {
        //Values for hospitals
        string[] hospitalList = { "Western General Hospital", "Stobhill Hospital" ,"Aberdeen Royal Infirmary"
                                    , "Forth Valley Royal Hospital", "Dumfries and Galloway Royal Infirmary"};
        DataTable dataQuery = new DataTable();
        Patient patient = new Patient();

        public Search()
        {
            InitializeComponent();
            cb_Hospital.DataSource = hospitalList;
        }

        SqlConnection sqlConnect;
        SqlCommand sqlCommand;

        public void ConnectToDatabase()
        {
            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = @"Data Source=40216858.database.windows.net;Initial Catalog=HospitalDatabase;
                                            User ID=softwarearchitecture;Password=Coursework123;Connect Timeout=30;
                                            Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                            MultiSubnetFailover=False";
            sqlCommand = sqlConnect.CreateCommand();
            sqlConnect.Open();
        }

        //Search button to query the database
        private void btn_search_Click(object sender, EventArgs e)
        {
            ConnectToDatabase();
            data_searchResults.DataSource = null;
            data_searchResults.Rows.Clear();
            dataQuery.Clear();
            try
            {
                //If no patient number is given then search for all values from specified hospital
                if(tb_search.Text == "")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                        ("SELECT * FROM Patient WHERE CONVERT(VARCHAR, hospital) = '" + cb_Hospital.SelectedValue + "'", sqlConnect);
                    sqlDataAdapter.Fill(dataQuery);
                }
                //If patient number is given then show all calls logged for the reference
                if (tb_search.Text != "")
                {
                    try
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                            //"SELECT * FROM [Patient] WHERE CONVERT(VARCHAR, patientNo) = '" + tb_search.Text + "'", sqlConnect
                            ("SELECT Call.patientNo, Patient.firstName, Patient.lastName, callDetails, callLength FROM" +
                            " Call RIGHT JOIN Patient ON Call.patientNo = Patient.patientNo WHERE CONVERT(VARCHAR, Patient.patientNo) = '"
                            + tb_search.Text + "' ORDER BY Patient.patientNo", sqlConnect);
                        sqlDataAdapter.Fill(dataQuery);
                    }
                    catch
                    {
                        MessageBox.Show("No patient found with that NHS Registration Number", "No Results");
                        MessageBox.Show(tb_search.Text);
                    }
                }
                data_searchResults.DataSource = dataQuery;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlConnect != null)
                {
                    sqlConnect.Close();
                }
            }
        }

        //TO BE ADDED IN LATER VERSION - CLICKABLE ROWS COPY DATA TO TEXTBOXES
        private void data_searchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            foreach (DataGridViewRow row in data_searchResults.SelectedRows)
            {
                MessageBox.Show(row.Cells[0].Value.ToString());
                patient.patientNo = Int32.Parse(row.Cells[0].Value.ToString());
                patient.firstName = row.Cells[1].Value.ToString();
                patient.lastName = row.Cells[2].Value.ToString();
                patient.dateOfBirth = DateTime.Parse(row.Cells[4].Value.ToString());
            }
            */
        }
    }
}
