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
            return service.OpenFile();
        }

        public static string Auth(string Login, string Password)
        {

            string Root = string.Empty;
             SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Авторизоваться", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL = new SqlParameter();
            ParamSQL.ParameterName = "@Логин";
            ParamSQL.SqlDbType = SqlDbType.NVarChar;
            ParamSQL.Value = Login;
            ParamSQL.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Пароль";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
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
            try
            {
                Root = ((string)SQLComm.Parameters["@Права"].Value).Trim();
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Во время авторизации произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Root;
        }
        public static void Сведения_о_сотрудниках(string Param1, string Param2, string Param3, string Param4, string Param5)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Сведения_о_сотрудниках", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Табельный_номер";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Имя";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Фамилия";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Отчество";
            ParamSQL4.SqlDbType = SqlDbType.NVarChar;
            ParamSQL4.Size = 50;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Пол";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_общие_сведения(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести общие сведения", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Табельный_номер";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Size = 50;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Телефон";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Дата_рождения";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Подразделение";
            ParamSQL4.SqlDbType = SqlDbType.NVarChar;
            ParamSQL4.Size = 50;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Семейное_положение";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Гражданство";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Национальность";
            ParamSQL7.SqlDbType = SqlDbType.NVarChar;
            ParamSQL7.Size = 50;
            ParamSQL7.Value = Param7;
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SqlParameter ParamSQL8 = new SqlParameter();
            ParamSQL8.ParameterName = "@Номер_страхового_полиса";
            ParamSQL8.SqlDbType = SqlDbType.NVarChar;
            ParamSQL8.Size = 50;
            ParamSQL8.Value = Param8;
            ParamSQL8.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL8);

            SqlParameter ParamSQL9 = new SqlParameter();
            ParamSQL9.ParameterName = "@ИНН";
            ParamSQL9.SqlDbType = SqlDbType.NVarChar;
            ParamSQL9.Size = 50;
            ParamSQL9.Value = Param9;
            ParamSQL9.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL9);

            SqlParameter ParamSQL10 = new SqlParameter();
            ParamSQL10.ParameterName = "@Номер_мед_полиса";
            ParamSQL10.SqlDbType = SqlDbType.NVarChar;
            ParamSQL10.Size = 50;
            ParamSQL10.Value = Param10;
            ParamSQL10.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL10);

            SqlParameter ParamSQL11 = new SqlParameter();
            ParamSQL11.ParameterName = "@Пенсионное_свидетельство";
            ParamSQL11.SqlDbType = SqlDbType.NVarChar;
            ParamSQL11.Size = 50;
            ParamSQL11.Value = Param11;
            ParamSQL11.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL11);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_сведения_паспорта(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести сведения паспорта", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Табельный_номер";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Серия";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Номер";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Дата_выдачи";
            ParamSQL4.SqlDbType = SqlDbType.Date;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Кем_выдан";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Город_регистрации";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Индекс";
            ParamSQL7.SqlDbType = SqlDbType.Int;
            ParamSQL7.Value = Convert.ToInt32(Param7);
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SqlParameter ParamSQL8 = new SqlParameter();
            ParamSQL8.ParameterName = "@Улица";
            ParamSQL8.SqlDbType = SqlDbType.NVarChar;
            ParamSQL8.Size = 50;
            ParamSQL8.Value = Param8;
            ParamSQL8.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL8);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_сведения_заграниченого_паспорта(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести сведения заграниченого паспорта", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Табельный_номер";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Серия";
            ParamSQL2.SqlDbType = SqlDbType.Int;
            ParamSQL2.Value = Convert.ToInt32(Param2);
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Номер";
            ParamSQL3.SqlDbType = SqlDbType.Int;
            ParamSQL3.Value = Convert.ToInt32(Param3);
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Дата";
            ParamSQL4.SqlDbType = SqlDbType.Date;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Кем_выдан";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Срок_действия";
            ParamSQL6.SqlDbType = SqlDbType.Date;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_сведения_об_образовании(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести сведения об образовании", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Табельный_номер";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Наименование_документа";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Серия";
            ParamSQL3.SqlDbType = SqlDbType.Int;
            ParamSQL3.Value = Convert.ToInt32(Param3);
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Номер";
            ParamSQL4.SqlDbType = SqlDbType.Int;
            ParamSQL4.Value = Convert.ToInt32(Param4);
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Наименование_учебного_заведения";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Квалицикация";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Специальность";
            ParamSQL7.SqlDbType = SqlDbType.NVarChar;
            ParamSQL7.Size = 50;
            ParamSQL7.Value = Param6;
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_cведения_о_послевузовском_образовании(string Param1, string Param3, string Param4, string Param5, string Param6, string Param7)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести cведения о послевузовском образовании", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Табельный_номер";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Наименование_документа";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Номер_Документа";
            ParamSQL4.SqlDbType = SqlDbType.Int;
            ParamSQL4.Value = Convert.ToInt32(Param4);
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Наименование_учебного_заведения";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Ученая_степень";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Направление";
            ParamSQL7.SqlDbType = SqlDbType.NVarChar;
            ParamSQL7.Size = 50;
            ParamSQL7.Value = Param6;
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_сведения_о_воиснком_учёте(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести сведения о воиснком учёте", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Табельный_номер";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Воинское_звание";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Номер_ВУС";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Военно_учетная_специальность";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Коммисариат";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Категория_запаса";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Состав";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL7.Value = Param7;
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SqlParameter ParamSQL8 = new SqlParameter();
            ParamSQL8.ParameterName = "@Категория_годности";
            ParamSQL8.SqlDbType = SqlDbType.NVarChar;
            ParamSQL8.Size = 50;
            ParamSQL8.Value = Param8;
            ParamSQL8.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL8);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_трудовую_деятельность(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести трудовую деятельность", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Табельный_номер";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Дата_приёма_на_работу";
            ParamSQL2.SqlDbType = SqlDbType.Date;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Номер_договора";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Дата_заключения_договора";
            ParamSQL4.SqlDbType = SqlDbType.Date;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Номер_приказа";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Дата_приказа";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Срок_договора";
            ParamSQL7.SqlDbType = SqlDbType.NVarChar;
            ParamSQL7.Size = 50;
            ParamSQL7.Value = Param6;
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_cведения_о_заработной_плате(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести cведения о заработной плате", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Табельный_номер";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Должность";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Надбавка";
            ParamSQL3.SqlDbType = SqlDbType.Int;
            ParamSQL3.Value = Convert.ToInt32(Param3);
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Категория";
            ParamSQL4.SqlDbType = SqlDbType.NVarChar;
            ParamSQL4.Size = 50;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Оклад";
            ParamSQL5.SqlDbType = SqlDbType.Int;
            ParamSQL5.Value = Convert.ToInt32(Param5);
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Ставка";
            ParamSQL6.SqlDbType = SqlDbType.Int;
            ParamSQL6.Value = Convert.ToInt32(Param6);
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Стаж_работы";
            ParamSQL7.SqlDbType = SqlDbType.Int;
            ParamSQL7.Value = Convert.ToInt32(Param7);
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_нового_пользователя(string Param1, string Param2, string Param3)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести нового пользователя", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Логин";
            ParamSQL1.SqlDbType = SqlDbType.NVarChar;
            ParamSQL1.Size = 50;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Пароль";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Права";
            ParamSQL3.SqlDbType = SqlDbType.NChar;
            ParamSQL3.Size = 10;
            ParamSQL3.Value = Convert.ToInt32(Param3);
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);


            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_cведения_о_больничных(string Param, string Param1, string Param2, string Param3, string Param4, string Param5, string Param6)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести cведения о больничных", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL = new SqlParameter();
            ParamSQL.ParameterName = "@Табельный_номер";
            ParamSQL.SqlDbType = SqlDbType.Int;
            ParamSQL.Value = Param;
            ParamSQL.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL);

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Номер_листа_нетрудоспособности";
            ParamSQL1.SqlDbType = SqlDbType.NVarChar;
            ParamSQL1.Size = 50;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Дата_начала";
            ParamSQL2.SqlDbType = SqlDbType.Date;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Дата_окончания";
            ParamSQL3.SqlDbType = SqlDbType.Date;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Номер_приказа";
            ParamSQL4.SqlDbType = SqlDbType.Int;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Дата_приказа";
            ParamSQL5.SqlDbType = SqlDbType.Date;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Дата_документа";
            ParamSQL6.SqlDbType = SqlDbType.Date;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);


            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_cведения_о_командировках(string Param, string Param1, string Param2, string Param3, string Param4, string Param5, string Param6)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести cведения о командировках", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL = new SqlParameter();
            ParamSQL.ParameterName = "@Табельный_номер";
            ParamSQL.SqlDbType = SqlDbType.Int;
            ParamSQL.Value = Param;
            ParamSQL.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL);

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Цель";
            ParamSQL1.SqlDbType = SqlDbType.NVarChar;
            ParamSQL1.Size = 50;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Место";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Датa_начала";
            ParamSQL3.SqlDbType = SqlDbType.Date;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Дата_окончания";
            ParamSQL4.SqlDbType = SqlDbType.Date;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Номер_приказа";
            ParamSQL5.SqlDbType = SqlDbType.Int;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Дата_приказа";
            ParamSQL6.SqlDbType = SqlDbType.Date;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_cведения_об_отпусках(string Param, string Param1, string Param2, string Param3, string Param4)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести сведения отпусков", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL = new SqlParameter();
            ParamSQL.ParameterName = "@Табельный_номер";
            ParamSQL.SqlDbType = SqlDbType.Int;
            ParamSQL.Value = Param;
            ParamSQL.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL);

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Номер_приказа";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Дата_приказа";
            ParamSQL2.SqlDbType = SqlDbType.Date;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Дата_начала";
            ParamSQL3.SqlDbType = SqlDbType.Date;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Дата_окончания";
            ParamSQL4.SqlDbType = SqlDbType.Date;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_cведения_об_уволенных(string Param, string Param1, string Param2, string Param3, string Param4, string Param5)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести сведения об уволенных", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL = new SqlParameter();
            ParamSQL.ParameterName = "@Табельный_номер";
            ParamSQL.SqlDbType = SqlDbType.Int;
            ParamSQL.Value = Param;
            ParamSQL.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL);

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Причина";
            ParamSQL1.SqlDbType = SqlDbType.NVarChar;
            ParamSQL1.Value = Param1;
            ParamSQL1.Size = 50;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Дата_увольнения";
            ParamSQL2.SqlDbType = SqlDbType.Date;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Имя";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Фамилия";
            ParamSQL4.SqlDbType = SqlDbType.NVarChar;
            ParamSQL4.Size = 50;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Отчество";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);


            SQLComm.ExecuteNonQuery();
        }
        public static void Обновить_сотрудника(int param, string Param1, string Param2, string Param3)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Обновить пользователя", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL = new SqlParameter();
            ParamSQL.ParameterName = "Id_пользователя";
            ParamSQL.SqlDbType = SqlDbType.Int;
            ParamSQL.Value = param;
            ParamSQL.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL);

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Логин";
            ParamSQL1.SqlDbType = SqlDbType.NVarChar;
            ParamSQL1.Size = 50;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Пароль";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Права";
            ParamSQL3.SqlDbType = SqlDbType.NChar;
            ParamSQL3.Size = 10;
            ParamSQL3.Value = Convert.ToInt32(Param3);
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SQLComm.ExecuteNonQuery();
        }
        public static void Обновить_общие_сведения(string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Обновить общие сведения", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;


            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Телефон";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Дата_рождения";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Подразделение";
            ParamSQL4.SqlDbType = SqlDbType.NVarChar;
            ParamSQL4.Size = 50;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Семейное_положение";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Гражданство";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Национальность";
            ParamSQL7.SqlDbType = SqlDbType.NVarChar;
            ParamSQL7.Size = 50;
            ParamSQL7.Value = Param7;
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SqlParameter ParamSQL8 = new SqlParameter();
            ParamSQL8.ParameterName = "@Номер_страхового_полиса";
            ParamSQL8.SqlDbType = SqlDbType.NVarChar;
            ParamSQL8.Size = 50;
            ParamSQL8.Value = Param8;
            ParamSQL8.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL8);

            SqlParameter ParamSQL9 = new SqlParameter();
            ParamSQL9.ParameterName = "@ИНН";
            ParamSQL9.SqlDbType = SqlDbType.NVarChar;
            ParamSQL9.Size = 50;
            ParamSQL9.Value = Param9;
            ParamSQL9.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL9);

            SqlParameter ParamSQL10 = new SqlParameter();
            ParamSQL10.ParameterName = "@Номер_мед_полиса";
            ParamSQL10.SqlDbType = SqlDbType.NVarChar;
            ParamSQL10.Size = 50;
            ParamSQL10.Value = Param10;
            ParamSQL10.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL10);

            SqlParameter ParamSQL11 = new SqlParameter();
            ParamSQL11.ParameterName = "@Пенсионное_свидетельство";
            ParamSQL11.SqlDbType = SqlDbType.NVarChar;
            ParamSQL11.Size = 50;
            ParamSQL11.Value = Param11;
            ParamSQL11.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL11);

            SQLComm.ExecuteNonQuery();
        }
        public static void Прочитать_сведения_паспорта(string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести сведения паспорта", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;


            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Серия";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Номер";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Дата_выдачи";
            ParamSQL4.SqlDbType = SqlDbType.Date;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Кем_выдан";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Город_регистрации";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Индекс";
            ParamSQL7.SqlDbType = SqlDbType.Int;
            ParamSQL7.Value = Convert.ToInt32(Param7);
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SqlParameter ParamSQL8 = new SqlParameter();
            ParamSQL8.ParameterName = "@Улица";
            ParamSQL8.SqlDbType = SqlDbType.NVarChar;
            ParamSQL8.Size = 50;
            ParamSQL8.Value = Param8;
            ParamSQL8.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL8);

            SQLComm.ExecuteNonQuery();
        }
        public static string Получить_сведения_из_базы_данных(string query)
        {
            try
            {
                SQLConn = new SqlConnection(Path());
                SQLConn.Open();
                SQLComm.CommandType = CommandType.Text;
                SQLComm.CommandText = query;
                var val = SQLComm.ExecuteScalar();
                SQLConn.Close();
                return Convert.ToString(val);

            }
            catch (Exception)
            {
                return string.Empty;
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
    }
}