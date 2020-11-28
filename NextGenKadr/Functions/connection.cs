using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NextGenKadr
{
    class connection
    {
        static SqlConnection SQLConn;
        static SqlCommand SQLComm;
        public static string Path()

        {
            PathToDB service = new PathToDB();
            return service.OpenFile(); ;
        }          
                       
        public static DataSet LoadGrid(string SqlQuery)
        {
  
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            DataSet table = new DataSet();
            try
            {
                using (SqlDataAdapter BaseAdapter = new SqlDataAdapter(SqlQuery, SQLConn))
                {
                    BaseAdapter.Fill(table);
                    SQLConn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SQLConn.Close();

            }
            SQLConn.Close();
            return table;

        }

        public static string Procedure(string Login, string Password)
        {
            string Root = string.Empty;
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Auth", SQLConn);

            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL = new SqlParameter();
            ParamSQL.ParameterName = "@Логин";
            ParamSQL.SqlDbType = SqlDbType.VarChar;
            ParamSQL.Value = Login;
            ParamSQL.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Пароль";
            ParamSQL2.SqlDbType = SqlDbType.VarChar;
            ParamSQL2.Value = Password;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Права";
            ParamSQL3.SqlDbType = SqlDbType.Char;
            ParamSQL3.Size = 10;
            ParamSQL3.Direction = ParameterDirection.Output;
            SQLComm.Parameters.Add(ParamSQL3);


            SQLComm.ExecuteNonQuery();
            Root = ((string)SQLComm.Parameters["@Права"].Value).Trim();

            return Root;
        }

        public static void Build(string query)
        {

        }

        public static void UpdateDB(string query)
        {

        }
        public static void DeletePerson(string query)
        {

        }
        public static string ReadDB(string query)
        {

            using (SqlCommand CommRead = new SqlCommand("Authorization", SQLConn))
            {
                SQLConn = new SqlConnection(Path());
                SQLConn.Open();
                try
                {
                    SQLConn.Close();
                    SQLConn.Open();
                    CommRead.CommandText = query;
                    CommRead.CommandType = CommandType.Text;
                    var val = CommRead.ExecuteScalar();
                    SQLConn.Close();
                    return Convert.ToString(val);
                }
                catch (Exception ex)
                {
                    return String.Empty;
                }
            }
        }
        public static DataSet ReloadGrid(string SqlQuery)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            DataSet table = new DataSet();
            try
            {
                using (SqlDataAdapter BaseAdapter = new SqlDataAdapter(SqlQuery, SQLConn))
                {
                    BaseAdapter.Fill(table);
                    SQLConn.Close();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SQLConn.Close();

            }
            SQLConn.Close();
            return table;

        }
        public static string id(string query)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Auth", SQLConn);

            SQLComm.CommandText = query;
            string val = SQLComm.ExecuteScalar().ToString();
            SQLConn.Close();
            return val;
        }
    }
}
