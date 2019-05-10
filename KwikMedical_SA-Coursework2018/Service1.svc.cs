using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KwikMedical_SA_Coursework2018
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDatabase();
        }

        SqlConnection sqlConnect;
        SqlCommand sqlCommand;

        public void ConnectToDatabase()
        {
            sqlConnect = new SqlConnection();
            //Connect to Azure server & Database
            sqlConnect.ConnectionString = @"Data Source=40216858.database.windows.net;Initial Catalog=HospitalDatabase;
                                            User ID=softwarearchitecture;Password=Coursework123;Connect Timeout=30;
                                            Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                            MultiSubnetFailover=False";
            /*sqlConnect.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=C:\USERS\WILLI\DESKTOP\REGIONALHOSPITAL.MDF;
                                            Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                            TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                            MultiSubnetFailover=False";*/
            sqlCommand = sqlConnect.CreateCommand();
            sqlConnect.Open();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int InsertPatient(Patient patient)
        {
            try
            {
                sqlCommand.CommandText = "INSERT INTO [Patient] (patientNo, firstName, lastName, gender, dateOfBirth, houseNo, streetName," +
                    "city, postcode, hospital) VALUES (@patientNo, @firstName, @lastName, @gender, @dateOfBirth," +
                    "@houseNo, @streetName, @city, @postcode, @hospital)";
                sqlCommand.Parameters.AddWithValue("patientNo", patient.patientNo);
                sqlCommand.Parameters.AddWithValue("firstName", patient.firstName);
                sqlCommand.Parameters.AddWithValue("lastName", patient.lastName);
                sqlCommand.Parameters.AddWithValue("gender", patient.gender);
                sqlCommand.Parameters.AddWithValue("dateOfBirth", patient.dateOfBirth);
                sqlCommand.Parameters.AddWithValue("houseNo", patient.houseNo);
                sqlCommand.Parameters.AddWithValue("streetName", patient.streetName);
                sqlCommand.Parameters.AddWithValue("city", patient.city);
                sqlCommand.Parameters.AddWithValue("postcode", patient.postcode);
                sqlCommand.Parameters.AddWithValue("hospital", patient.hospital);

                sqlCommand.CommandType = CommandType.Text;

                return sqlCommand.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(sqlConnect != null)
                {
                    sqlConnect.Close();
                }
            }
        }
        public int AddCall(Call call)
        {
            try
            {
                sqlCommand.CommandText = "INSERT INTO [Call] (patientNo, callDetails, callLength)" +
                    " VALUES (@patientNo, @callDetails, @callLength)";
                sqlCommand.Parameters.AddWithValue("patientNo", call.patientNo);
                sqlCommand.Parameters.AddWithValue("callDetails", call.callDetails);
                sqlCommand.Parameters.AddWithValue("callLength", call.callLength);

                sqlCommand.CommandType = CommandType.Text;

                return sqlCommand.ExecuteNonQuery();
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
    }
}
