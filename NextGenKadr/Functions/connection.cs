using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace NextGenKadr
{
    class connection
    {
        private static SqlConnection ConnToDB = new SqlConnection(Path());
        private static SqlCommand sqlCommand = ConnToDB.CreateCommand();


        public static string Path()
        
        {
            PathToDB service = new PathToDB();
            return service.OpenFile(); ;
        }


        public static DataSet LoadGrid(string SqlQuery)
        {
            DataSet table = new DataSet();
            try
            {
                using (SqlDataAdapter BaseAdapter = new SqlDataAdapter(SqlQuery, ConnToDB))
                {
                    BaseAdapter.Fill(table);
                    ConnToDB.Close();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnToDB.Close();

            }
            ConnToDB.Close();
            return table;

        }
        public static void Build(string query)
        {

            ConnToDB.Close();
            ConnToDB.Open();
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            ConnToDB.Close();
        }
        public static string id(string query)
        {
            ConnToDB.Close();
            ConnToDB.Open();
            sqlCommand.CommandText = query;
            string val = sqlCommand.ExecuteScalar().ToString();
            ConnToDB.Close();
            return val;
        }
        public static void UpdateDB(string query)
        {
            ConnToDB.Close();
            ConnToDB.Open();
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            ConnToDB.Close();

        }
        public static void DeletePerson(string query)
        {
            ConnToDB.Close();
            ConnToDB.Open();
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            ConnToDB.Close();

        }
        public static string ReadDB(string query)
        {
            try
            {
                ConnToDB.Close();
                ConnToDB.Open();
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;
                var val = sqlCommand.ExecuteScalar();
                ConnToDB.Close();
                return Convert.ToString(val);
            }
            catch (Exception ex)
            {
                return String.Empty;
            }
        }


        public static DataSet ReloadGrid(string SqlQuery)
        {
            DataSet table = new DataSet();
            try
            {
                using (SqlDataAdapter BaseAdapter = new SqlDataAdapter(SqlQuery, ConnToDB))
                {
                    BaseAdapter.Fill(table);
                    ConnToDB.Close();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnToDB.Close();

            }
            ConnToDB.Close();
            return table;

        }
    }
}
