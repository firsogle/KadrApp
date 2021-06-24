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
        public static string Salt(string Login)
        {
            string PasswordSalt = string.Empty;
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Соль", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL = new SqlParameter();
            ParamSQL.ParameterName = "@Логин";
            ParamSQL.SqlDbType = SqlDbType.NVarChar;
            ParamSQL.Value = Login;
            ParamSQL.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Пароль";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 200;
            ParamSQL3.Direction = ParameterDirection.Output;
            SQLComm.Parameters.Add(ParamSQL3);

            SQLComm.ExecuteNonQuery();
            try
            {
                PasswordSalt = ((string)SQLComm.Parameters["@Пароль"].Value).Trim();
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Во время авторизации произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return PasswordSalt;
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

        public static void Запись_в_журнал(string name, string Type, string раздел, string пользователь)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Журнал] ([Дата записи],[Название], [Тип записи], [Раздел], [Пользователь]) values (@1, @2, @3, @4, @5)";
            SQLComm.Parameters.AddWithValue("@1", DateTime.Now);
            SQLComm.Parameters.AddWithValue("@2", name);
            SQLComm.Parameters.AddWithValue("@3", Type);
            SQLComm.Parameters.AddWithValue("@4", раздел);
            SQLComm.Parameters.AddWithValue("@5", пользователь);
  
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();
        }

        public static void Создать_сотрудника(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Создать сотрудника", SQLConn);
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

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Телефон";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_общие_сведения(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11, string Param12, string Param13, string Param14, string Param15, string Param16, string Param17, string Param18, string Param19, string Param20, string Param21, string Param22, string Param23, string Param24)
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
            ParamSQL2.ParameterName = "@Дата_составления";
            ParamSQL2.SqlDbType = SqlDbType.DateTime;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@ИНН";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Пенсионное_свидетельство";
            ParamSQL4.SqlDbType = SqlDbType.NVarChar;
            ParamSQL4.Size = 50;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Алфавит";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Характер_работы";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Вид_работы";
            ParamSQL7.SqlDbType = SqlDbType.NVarChar;
            ParamSQL7.Size = 50;
            ParamSQL7.Value = Param7;
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SqlParameter ParamSQL8 = new SqlParameter();
            ParamSQL8.ParameterName = "@Дата_рождения";
            ParamSQL8.SqlDbType = SqlDbType.DateTime;
            ParamSQL8.Value = Param8;
            ParamSQL8.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL8);

            SqlParameter ParamSQL9 = new SqlParameter();
            ParamSQL9.ParameterName = "@Место_рождения";
            ParamSQL9.SqlDbType = SqlDbType.NVarChar;
            ParamSQL9.Size = 50;
            ParamSQL9.Value = Param9;
            ParamSQL9.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL9);

            SqlParameter ParamSQL10 = new SqlParameter();
            ParamSQL10.ParameterName = "@Место_рождения_ОКАТА";
            ParamSQL10.SqlDbType = SqlDbType.NVarChar;
            ParamSQL10.Value = Param10;
            ParamSQL10.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL10);

            SqlParameter ParamSQL11 = new SqlParameter();
            ParamSQL11.ParameterName = "@Гражданство";
            ParamSQL11.SqlDbType = SqlDbType.NVarChar;
            ParamSQL11.Size = 50;
            ParamSQL11.Value = Param11;
            ParamSQL11.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL11);

            SqlParameter ParamSQL12 = new SqlParameter();
            ParamSQL12.ParameterName = "@Код_гражданства_по_ОКИН";
            ParamSQL12.SqlDbType = SqlDbType.Int;
            ParamSQL12.Value = Convert.ToInt32(Param12);
            ParamSQL12.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL12);

            SqlParameter ParamSQL13 = new SqlParameter();
            ParamSQL13.ParameterName = "@Инонстранный_язык";
            ParamSQL13.SqlDbType = SqlDbType.NVarChar;
            ParamSQL13.Size = 50;
            ParamSQL13.Value = Param13;
            ParamSQL13.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL13);

            SqlParameter ParamSQL14 = new SqlParameter();
            ParamSQL14.ParameterName = "@Код_языка_по_ОКИН";
            ParamSQL14.SqlDbType = SqlDbType.Int;
            ParamSQL14.Value = Convert.ToInt32(Param14);
            ParamSQL14.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL14);

            SqlParameter ParamSQL15 = new SqlParameter();
            ParamSQL15.ParameterName = "@Уровень_знания_языка";
            ParamSQL15.SqlDbType = SqlDbType.NVarChar;
            ParamSQL15.Size = 50;
            ParamSQL15.Value = Param15;
            ParamSQL15.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL15);

            SqlParameter ParamSQL16 = new SqlParameter();
            ParamSQL16.ParameterName = "@Код_знания_языка_по_ОКИН";
            ParamSQL16.SqlDbType = SqlDbType.Int;
            ParamSQL16.Value = Convert.ToInt32(Param16);
            ParamSQL16.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL16);

            SqlParameter ParamSQL17 = new SqlParameter();
            ParamSQL17.ParameterName = "@Состояние_в_браке";
            ParamSQL17.SqlDbType = SqlDbType.NVarChar;
            ParamSQL17.Size = 50;
            ParamSQL17.Value = Param17;
            ParamSQL17.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL17);

            SqlParameter ParamSQL18 = new SqlParameter();
            ParamSQL18.ParameterName = "@Код_брака_по_ОКИН";
            ParamSQL18.SqlDbType = SqlDbType.Int;
            ParamSQL18.Value = Convert.ToInt32(Param18);
            ParamSQL18.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL18);

            SqlParameter ParamSQL19 = new SqlParameter();
            ParamSQL19.ParameterName = "@Национальность";
            ParamSQL19.SqlDbType = SqlDbType.NVarChar;
            ParamSQL19.Size = 50;
            ParamSQL19.Value = Param19;
            ParamSQL19.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL19);

            SqlParameter ParamSQL20 = new SqlParameter();
            ParamSQL20.ParameterName = "@Номер_медицинского_полиса";
            ParamSQL20.SqlDbType = SqlDbType.NVarChar;
            ParamSQL20.Size = 50;
            ParamSQL20.Value = Param20;
            ParamSQL20.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL20);

            SqlParameter ParamSQL21 = new SqlParameter();
            ParamSQL21.ParameterName = "@Образование";
            ParamSQL21.SqlDbType = SqlDbType.NVarChar;
            ParamSQL21.Size = 50;
            ParamSQL21.Value = Param21;
            ParamSQL21.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL21);

            SqlParameter ParamSQL22 = new SqlParameter();
            ParamSQL22.ParameterName = "@Код_образование_по_ОКИН";
            ParamSQL22.SqlDbType = SqlDbType.Int;
            ParamSQL22.Value = Convert.ToInt32(Param22);
            ParamSQL22.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL22);

            SqlParameter ParamSQL23 = new SqlParameter();
            ParamSQL23.ParameterName = "@Номер_договора";
            ParamSQL23.SqlDbType = SqlDbType.NVarChar;
            ParamSQL23.Value = Param23;
            ParamSQL23.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL23);

            SqlParameter ParamSQL24 = new SqlParameter();
            ParamSQL24.ParameterName = "@Дата_договора";
            ParamSQL24.SqlDbType = SqlDbType.DateTime;
            ParamSQL24.Size = 50;
            ParamSQL24.Value = Param24;
            ParamSQL24.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL24);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_сведения_паспорта(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11, string Param12)
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
            ParamSQL7.ParameterName = "@Индекс_регистрации";
            ParamSQL7.SqlDbType = SqlDbType.Int;
            ParamSQL7.Value = Convert.ToInt32(Param7);
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SqlParameter ParamSQL8 = new SqlParameter();
            ParamSQL8.ParameterName = "@Адрес_регистрации";
            ParamSQL8.SqlDbType = SqlDbType.NVarChar;
            ParamSQL8.Size = 50;
            ParamSQL8.Value = Param8;
            ParamSQL8.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL8);

            SqlParameter ParamSQL9 = new SqlParameter();
            ParamSQL9.ParameterName = "@Дата_регистрации";
            ParamSQL9.SqlDbType = SqlDbType.DateTime;
            ParamSQL9.Value = Param9;
            ParamSQL9.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL9);

            SqlParameter ParamSQL10 = new SqlParameter();
            ParamSQL10.ParameterName = "@Город_проживания";
            ParamSQL10.SqlDbType = SqlDbType.NVarChar;
            ParamSQL10.Size = 50;
            ParamSQL10.Value = Param10;
            ParamSQL10.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL10);

            SqlParameter ParamSQL11 = new SqlParameter();
            ParamSQL11.ParameterName = "@Индекс_города_проживания";
            ParamSQL11.SqlDbType = SqlDbType.Int;
            ParamSQL11.Value = Convert.ToInt32(Param11);
            ParamSQL11.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL11);

            SqlParameter ParamSQL12 = new SqlParameter();
            ParamSQL12.ParameterName = "@Адрес_проживания";
            ParamSQL12.SqlDbType = SqlDbType.NVarChar;
            ParamSQL12.Size = 50;
            ParamSQL12.Value = Param12;
            ParamSQL12.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL12);

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
        public static void Внести_сведения_об_образовании(string Param1, string Param0, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11, string Param12)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();

            SQLComm = new SqlCommand("Внести cведения об образовании", SQLConn);
            SQLComm.CommandType = CommandType.StoredProcedure;

            SqlParameter ParamSQL1 = new SqlParameter();
            ParamSQL1.ParameterName = "@Табельный_номер";
            ParamSQL1.SqlDbType = SqlDbType.Int;
            ParamSQL1.Value = Param1;
            ParamSQL1.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL1);

            SqlParameter ParamSQL0 = new SqlParameter();
            ParamSQL0.ParameterName = "@Наименование_учебного_заведения";
            ParamSQL0.SqlDbType = SqlDbType.NVarChar;
            ParamSQL0.Size = 50;
            ParamSQL0.Value = Param0;
            ParamSQL0.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL0);

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
            ParamSQL5.ParameterName = "@Год_окончания";
            ParamSQL5.SqlDbType = SqlDbType.DateTime;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Квалификация";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Специальность";
            ParamSQL7.SqlDbType = SqlDbType.NVarChar;
            ParamSQL7.Size = 50;
            ParamSQL7.Value = Param7;
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SqlParameter ParamSQL8 = new SqlParameter();
            ParamSQL8.ParameterName = "@Код_ОКСО";
            ParamSQL8.SqlDbType = SqlDbType.Int;
            ParamSQL8.Value = Convert.ToInt32(Param8);
            ParamSQL8.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL8);

            SqlParameter ParamSQL9 = new SqlParameter();
            ParamSQL9.ParameterName = "@Профессия_Основная";
            ParamSQL9.SqlDbType = SqlDbType.NVarChar;
            ParamSQL9.Size = 50;
            ParamSQL9.Value = Param9;
            ParamSQL9.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL9);

            SqlParameter ParamSQL10 = new SqlParameter();
            ParamSQL10.ParameterName = "@Код_по_ОКПДТР_основной";
            ParamSQL10.SqlDbType = SqlDbType.Int;
            ParamSQL10.Value = Convert.ToInt32(Param10);
            ParamSQL10.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL10);

            SqlParameter ParamSQL11 = new SqlParameter();
            ParamSQL11.ParameterName = "@Профессия_другая";
            ParamSQL11.SqlDbType = SqlDbType.NVarChar;
            ParamSQL11.Size = 50;
            ParamSQL11.Value = Param11;
            ParamSQL11.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL11);

            SqlParameter ParamSQL12 = new SqlParameter();
            ParamSQL12.ParameterName = "@Код_по_ОКПДТР_другой";
            ParamSQL12.SqlDbType = SqlDbType.Int;
            ParamSQL12.Value = Convert.ToInt32(Param12);
            ParamSQL12.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL12);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_cведения_о_послевузовском_образовании(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9)
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

            SqlParameter ParamSQL2 = new SqlParameter();
            ParamSQL2.ParameterName = "@Послевузовское_образование";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Наименование_учебного_заведения_После";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Дата_выдачи_после";
            ParamSQL4.SqlDbType = SqlDbType.DateTime;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Год_окончания";
            ParamSQL5.SqlDbType = SqlDbType.DateTime;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@Наименование_документа_после";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Документ_Num";
            ParamSQL7.SqlDbType = SqlDbType.Int;
            ParamSQL7.Value = Convert.ToInt32(Param7);
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SqlParameter ParamSQL8 = new SqlParameter();
            ParamSQL8.ParameterName = "@Направление";
            ParamSQL8.SqlDbType = SqlDbType.NVarChar;
            ParamSQL8.Size = 50;
            ParamSQL8.Value = Param8;
            ParamSQL8.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL8);

            SqlParameter ParamSQL9 = new SqlParameter();
            ParamSQL9.ParameterName = "@Код_ОКСО_3";
            ParamSQL9.SqlDbType = SqlDbType.Int;
            ParamSQL9.Value = Convert.ToInt32(Param9);
            ParamSQL9.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL9);

            SQLComm.ExecuteNonQuery();
        }
        public static void Внести_сведения_о_воиснком_учёте(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11)
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
            ParamSQL2.ParameterName = "@Категория_запаса";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL2.Value = Param2;
            ParamSQL2.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL2);

            SqlParameter ParamSQL3 = new SqlParameter();
            ParamSQL3.ParameterName = "@Воинское_звание";
            ParamSQL3.SqlDbType = SqlDbType.NVarChar;
            ParamSQL3.Size = 50;
            ParamSQL3.Value = Param3;
            ParamSQL3.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL3);

            SqlParameter ParamSQL4 = new SqlParameter();
            ParamSQL4.ParameterName = "@Состав";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL4.Value = Param4;
            ParamSQL4.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL4);

            SqlParameter ParamSQL5 = new SqlParameter();
            ParamSQL5.ParameterName = "@Номер_ВУС";
            ParamSQL5.SqlDbType = SqlDbType.NVarChar;
            ParamSQL5.Size = 50;
            ParamSQL5.Value = Param5;
            ParamSQL5.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL5);

            SqlParameter ParamSQL6 = new SqlParameter();
            ParamSQL6.ParameterName = "@ВУС";
            ParamSQL6.SqlDbType = SqlDbType.NVarChar;
            ParamSQL6.Size = 50;
            ParamSQL6.Value = Param6;
            ParamSQL6.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL6);

            SqlParameter ParamSQL7 = new SqlParameter();
            ParamSQL7.ParameterName = "@Категория_годности";
            ParamSQL2.SqlDbType = SqlDbType.NVarChar;
            ParamSQL2.Size = 50;
            ParamSQL7.Value = Param7;
            ParamSQL7.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL7);

            SqlParameter ParamSQL8 = new SqlParameter();
            ParamSQL8.ParameterName = "@Комиссариат";
            ParamSQL8.SqlDbType = SqlDbType.NVarChar;
            ParamSQL8.Size = 50;
            ParamSQL8.Value = Param8;
            ParamSQL8.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL8);

            SqlParameter ParamSQL9 = new SqlParameter();
            ParamSQL9.ParameterName = "@Общий_воинский_учет";
            ParamSQL9.SqlDbType = SqlDbType.NVarChar;
            ParamSQL9.Size = 50;
            ParamSQL9.Value = Param9;
            ParamSQL9.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL9);

            SqlParameter ParamSQL10 = new SqlParameter();
            ParamSQL10.ParameterName = "@Специальный_воинский_учет";
            ParamSQL10.SqlDbType = SqlDbType.NVarChar;
            ParamSQL10.Size = 50;
            ParamSQL10.Value = Param10;
            ParamSQL10.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL10);

            SqlParameter ParamSQL11 = new SqlParameter();
            ParamSQL11.ParameterName = "@Отметка_о_снятии_с_учета";
            ParamSQL11.SqlDbType = SqlDbType.NVarChar;
            ParamSQL11.Size = 50;
            ParamSQL11.Value = Param11;
            ParamSQL11.Direction = ParameterDirection.Input;
            SQLComm.Parameters.Add(ParamSQL11);
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
            ParamSQL2.Size = 200;
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

            DateTime date3 = new DateTime(2000, 5, 5);
            DateTime date4 = new DateTime(2000, 5, 5);
            DateTime date6 = new DateTime(2000, 5, 5);


            try
            {
                date3 = Convert.ToDateTime(Param3);
                date4 = Convert.ToDateTime(Param4);
                date6 = Convert.ToDateTime(Param6);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"insert into [Сведения о больничных] ([Номер листа нетрудоспособности],[Название организации, выдавшей листок],[Табельный номер],[Дата начала],[Дата окончания],[Код причины нетрудоспособности],[Дата предоставления листка]) values (@Param, @Param1, @Param2, @Param3, @Param4, @Param5, @Param6)";
            SQLComm.Parameters.AddWithValue("@Param", Param);
            SQLComm.Parameters.AddWithValue("@Param1", Param1);
            SQLComm.Parameters.AddWithValue("@Param2", Param2);
            SQLComm.Parameters.AddWithValue("@Param3", date3);
            SQLComm.Parameters.AddWithValue("@Param4", date4);
            SQLComm.Parameters.AddWithValue("@Param5", Param5);
            SQLComm.Parameters.AddWithValue("@Param6", date6);


            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();
        }
        public static void Внести_cведения_о_командировках(string Param, string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10)
        {
            DateTime date1 = new DateTime(2000, 5, 5);
            DateTime date6 = new DateTime(2000, 5, 5);
            DateTime date7 = new DateTime(2000, 5, 5);
            DateTime date10 = new DateTime(2000, 5, 5);
            try
            {
                date1 = Convert.ToDateTime(Param1);
                date6 = Convert.ToDateTime(Param6);
                date7 = Convert.ToDateTime(Param7);
                date10 = Convert.ToDateTime(Param10);

            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"insert into [Сведения о командировках] ([Номер документа],[Дата приказа],[Табельный номер],[Цель],[Место],[Дни],[Начало командировки],[Окончание командировки],[Источник финансов],[Задание],[Дата задания]) values (@Param, @Param1, @Param2, @Param3, @Param4, @Param5, @Param6, @Param7, @Param8, @Param9, @Param10)";
            SQLComm.Parameters.AddWithValue("@Param", Param);
            SQLComm.Parameters.AddWithValue("@Param1", date1);
            SQLComm.Parameters.AddWithValue("@Param2", Param2);
            SQLComm.Parameters.AddWithValue("@Param3", Param3);
            SQLComm.Parameters.AddWithValue("@Param4", Param4);
            SQLComm.Parameters.AddWithValue("@Param5", Param5);
            SQLComm.Parameters.AddWithValue("@Param6", date6);
            SQLComm.Parameters.AddWithValue("@Param7", date7);
            SQLComm.Parameters.AddWithValue("@Param8", Param8);
            SQLComm.Parameters.AddWithValue("@Param9", Param9);
            SQLComm.Parameters.AddWithValue("@Param10", date10);

            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();
        }
        public static void Внести_cведения_об_отпусках(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11, string Param12, string Param13, string Param14, string Param15)
        {
            DateTime date1 = new DateTime(2000, 5, 5);
            DateTime date2 = new DateTime(2000, 5, 5);
            DateTime date3 = new DateTime(2000, 5, 5);
            DateTime date4 = new DateTime(2000, 5, 5);
            DateTime date5 = new DateTime(2000, 5, 5);
            DateTime date6 = new DateTime(2000, 5, 5);
            DateTime date7 = new DateTime(2000, 5, 5);
            DateTime date8 = new DateTime(2000, 5, 5);
            DateTime date9 = new DateTime(2000, 5, 5);
            DateTime date10 = new DateTime(2000, 5, 5);
            DateTime date11 = new DateTime(2000, 5, 5);
            DateTime date12 = new DateTime(2000, 5, 5);

            try
            {
                date3 = Convert.ToDateTime(Param3);
                date4 = Convert.ToDateTime(Param4);
                date5 = Convert.ToDateTime(Param5);
                date7 = Convert.ToDateTime(Param7);
                date8 = Convert.ToDateTime(Param8);
                date9 = Convert.ToDateTime(Param9);
                date10 = Convert.ToDateTime(Param10);
                date11 = Convert.ToDateTime(Param11);
                date12 = Convert.ToDateTime(Param12);

            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"insert into [Сведения об отпусках] ([Табельный номер],[Номер документа],[Дата приказа],[Переод работы от],[Переод работы по],[Тип отпуска],[Начало отпуска А],[Окончание отпуска А],[Начало отпуска Б],[Окончание отпуска Б],[Начало отпуска В],[Окончание отпуска В],[Дней А],[Дней Б],[Дней В]) values (@Param1, @Param2, @Param3, @Param4, @Param5, @Param6, @Param7, @Param8, @Param9, @Param10, @Param11, @Param12, @Param13, @Param14, @Param14)";
            SQLComm.Parameters.AddWithValue("@Param1", Param1);
            SQLComm.Parameters.AddWithValue("@Param2", Param2);
            SQLComm.Parameters.AddWithValue("@Param3", date3);
            SQLComm.Parameters.AddWithValue("@Param4", date4);
            SQLComm.Parameters.AddWithValue("@Param5", date5);
            SQLComm.Parameters.AddWithValue("@Param6", Param6);
            SQLComm.Parameters.AddWithValue("@Param7", date7);
            SQLComm.Parameters.AddWithValue("@Param8", date8);
            SQLComm.Parameters.AddWithValue("@Param9", date9);
            SQLComm.Parameters.AddWithValue("@Param10", date10);
            SQLComm.Parameters.AddWithValue("@Param11", date11);
            SQLComm.Parameters.AddWithValue("@Param12", date12);
            SQLComm.Parameters.AddWithValue("@Param13", Param13);
            SQLComm.Parameters.AddWithValue("@Param14", Param14);
            SQLComm.Parameters.AddWithValue("@Param15", Param15);
            SQLComm.ExecuteScalar();

        }
        public static void Внести_cведения_об_уволенных(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11, string Param12, string Param13, string Param14)
        {
            DateTime date2 = new DateTime(2000, 5, 5);
            DateTime date4 = new DateTime(2000, 5, 5);
            DateTime date7 = new DateTime(2000, 5, 5);
            try
            {
                date2 = Convert.ToDateTime(Param2);
                date4 = Convert.ToDateTime(Param4);
                date7 = Convert.ToDateTime(Param7);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"insert into [Сведения об уволенных] ([Имя], [Отчество], [Фамилия], [Должность], [Подразделение], [Табельный номер], [Номер документа],[Дата приказа],[Дата заключения договора],[Номер договора],[Дата увольнения],[Основание],[Номер основания],[Дата основания]) values (@Param1, @Param2, @Param3, @Param4, @Param5, @Param6, @Param7, @Param8, @Param9, @Param10, @Param11, @Param12, @Param13, @Param14)";
            SQLComm.Parameters.AddWithValue("@Param1", Param1);
            SQLComm.Parameters.AddWithValue("@Param2", Param2);
            SQLComm.Parameters.AddWithValue("@Param3", Param3);
            SQLComm.Parameters.AddWithValue("@Param4", Param4);
            SQLComm.Parameters.AddWithValue("@Param5", Param5);
            SQLComm.Parameters.AddWithValue("@Param6", Param6);
            SQLComm.Parameters.AddWithValue("@Param7", Param7);
            SQLComm.Parameters.AddWithValue("@Param8", Param8);
            SQLComm.Parameters.AddWithValue("@Param9", Param9);
            SQLComm.Parameters.AddWithValue("@Param10", Param10);
            SQLComm.Parameters.AddWithValue("@Param11", Param11);
            SQLComm.Parameters.AddWithValue("@Param12", Param12);
            SQLComm.Parameters.AddWithValue("@Param13", Param13);
            SQLComm.Parameters.AddWithValue("@Param14", Param14);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();


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
        public static void Внести_сведения_о_семье(string Номер, string Степень_родства, string табельный, string Фамилия, string Имя, string Отчество, string дата)
        {
            DateTime date = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(дата);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Состав семьи] ([Номер родственника],[Степень родства], [Табельный номер сотрудника],  [Фамилия], [Имя], [Отчество],  [Дата рождения]) values (@Номер, @Степень_родства, @табельный, @Фамилия, @Имя, @Отчество, @Дата_рождения)";
            SQLComm.Parameters.AddWithValue("@Номер", Номер);
            SQLComm.Parameters.AddWithValue("@Степень_родства", Степень_родства);
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@Фамилия", Фамилия);
            SQLComm.Parameters.AddWithValue("@Имя", Имя);
            SQLComm.Parameters.AddWithValue("@Отчество", Отчество);
            SQLComm.Parameters.AddWithValue("@Дата_рождения", date);

            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }

        public static void Обновить_сведения_о_семье(string Номер, string Степень_родства, string табельный, string Фамилия, string Имя, string Отчество, string дата, string id )
        {
            DateTime date = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(дата);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;
            
            SQLComm.CommandText = $"update [Состав семьи] SET [Номер родственника] =@Номер,[Степень родства]=@Степень_родства, [Фамилия] = @Фамилия, [Имя]=@Имя, [Отчество]=@Отчество,  [Дата рождения] = @Дата_рождения where [Табельный номер сотрудника]  = {табельный} and [id Родственника]= {id}";
            SQLComm.Parameters.AddWithValue("@Номер", Номер);
            SQLComm.Parameters.AddWithValue("@Степень_родства", Степень_родства);
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@Фамилия", Фамилия);
            SQLComm.Parameters.AddWithValue("@Имя", Имя);
            SQLComm.Parameters.AddWithValue("@Отчество", Отчество);
            SQLComm.Parameters.AddWithValue("@Дата_рождения", date);

            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }


        public static void Внести_сведения_приёмов_и_переводов(string табельный, string дата, string Договор, string Подразделение, string Дожность, string Оклад, string Основание)
        {
            DateTime date = new DateTime(2000, 5,5);
            try
            {
                date = Convert.ToDateTime(дата);
            }
            catch (Exception)
            {
               
            } 

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Приём и переводы на работу] ([Табельный номер],[Дата приёма на работу], [Номер договора], [Подразделение], [Дожность], [Оклад], [Основание] ) values (@табельный, @дата, @Договор, @Подразделение, @Дожность, @Оклад, @Основание)";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@дата", date);
            SQLComm.Parameters.AddWithValue("@Договор", Договор);
            SQLComm.Parameters.AddWithValue("@Подразделение", Подразделение);
            SQLComm.Parameters.AddWithValue("@Дожность", Дожность);
            SQLComm.Parameters.AddWithValue("@Оклад", Оклад);
            SQLComm.Parameters.AddWithValue("@Основание", Основание);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }



        public static void Обновить_сведения_приёмов_и_переводов(string табельный, string дата, string Договор, string Подразделение, string Дожность, string Оклад, string Основание, string id)
        {
            DateTime date = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(дата);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"update [Приём и переводы на работу] SET [Дата приёма на работу] =@дата, [Номер договора] =@Договор, [Подразделение] =@Подразделение, [Дожность] =@Дожность, [Оклад] = @Оклад, [Основание] =@Основание where [Табельный номер] = @табельный and [id Приёма на работу]= {id}";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@дата", date);
            SQLComm.Parameters.AddWithValue("@Договор", Договор);
            SQLComm.Parameters.AddWithValue("@Подразделение", Подразделение);
            SQLComm.Parameters.AddWithValue("@Дожность", Дожность);
            SQLComm.Parameters.AddWithValue("@Оклад", Оклад);
            SQLComm.Parameters.AddWithValue("@Основание", Основание);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }
        public static void Внести_Повышение_квалификации(string табельный, string Начало_повышения_квалификации, string Окончание,string Вид_повышения_квалификации, string Наименование_образовательного_учреждения, string Наименование_документа, string Серия_документа, string Номер_документа, string Дата, string Основание)
        {
            DateTime date = new DateTime(2000, 5, 5);
            DateTime date2 = new DateTime(2000, 5, 5);
            DateTime date3 = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(Начало_повышения_квалификации);
                date2 = Convert.ToDateTime(Окончание);
                date3 = Convert.ToDateTime(Дата);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Повышение квалификации] ([Табельный номер], [Начало повышения квалификации], [Окончание повышения квалификации], [Вид повышения квалификации], [Наименование образовательного учреждения], [Наименование документа], [Серия документа], [Номер документа], [Дата], [Основание]) values (@табельный, @Начало_повышения_квалификации, @Окончание, @Вид_повышения_квалификации, @Наименование_образовательного_учреждения, @Наименование_документа, @Серия_документа, @Номер_документа, @Дата, @Основание)";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@Начало_повышения_квалификации", date);
            SQLComm.Parameters.AddWithValue("@Окончание", date2);
            SQLComm.Parameters.AddWithValue("@Вид_повышения_квалификации", Вид_повышения_квалификации);
            SQLComm.Parameters.AddWithValue("@Наименование_образовательного_учреждения", Наименование_образовательного_учреждения);
            SQLComm.Parameters.AddWithValue("@Наименование_документа", Наименование_документа);
            SQLComm.Parameters.AddWithValue("@Серия_документа", Серия_документа);
            SQLComm.Parameters.AddWithValue("@Номер_документа", Номер_документа);
            SQLComm.Parameters.AddWithValue("@Дата", date3);
            SQLComm.Parameters.AddWithValue("@Основание", Основание);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }
        public static void Обновить_Повышение_квалификации(string табельный, string Начало_повышения_квалификации, string Окончание, string Вид_повышения_квалификации, string Наименование_образовательного_учреждения, string Наименование_документа, string Серия_документа, string Номер_документа, string Дата, string Основание, string id)
        {
            DateTime date = new DateTime(2000, 5, 5);
            DateTime date2 = new DateTime(2000, 5, 5);
            DateTime date3 = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(Начало_повышения_квалификации);
                date2 = Convert.ToDateTime(Окончание);
                date3 = Convert.ToDateTime(Дата);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"update [Повышение квалификации] SET  [Начало повышения квалификации]=@Начало_повышения_квалификации, [Окончание повышения квалификации]=@Окончание, [Вид повышения квалификации]=@Вид_повышения_квалификации, [Наименование образовательного учреждения]=@Наименование_образовательного_учреждения, [Наименование документа]= @Наименование_документа, [Серия документа]=@Серия_документа, [Номер документа]= @Номер_документа, [Дата]=@Дата, [Основание]=@Основание where [Табельный номер] = @табельный and [Id повышения квалификации] = {id}";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@Начало_повышения_квалификации", date);
            SQLComm.Parameters.AddWithValue("@Окончание", date2);
            SQLComm.Parameters.AddWithValue("@Вид_повышения_квалификации", Вид_повышения_квалификации);
            SQLComm.Parameters.AddWithValue("@Наименование_образовательного_учреждения", Наименование_образовательного_учреждения);
            SQLComm.Parameters.AddWithValue("@Наименование_документа", Наименование_документа);
            SQLComm.Parameters.AddWithValue("@Серия_документа", Серия_документа);
            SQLComm.Parameters.AddWithValue("@Номер_документа", Номер_документа);
            SQLComm.Parameters.AddWithValue("@Дата", date3);
            SQLComm.Parameters.AddWithValue("@Основание", Основание);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }

        public static void Внести_сведения_аттестации(string табельный, string Дата_аттестацииата, string Решение, string Номер_протокола, string Дата_протокола, string Основание)
        {
            DateTime date = new DateTime(2000, 5, 5);
            DateTime date2 = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(Дата_аттестацииата);
                date2 = Convert.ToDateTime(Дата_протокола);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Аттестация] ([Табельный номер],[Дата аттестации], [Решение комиссии], [Номер протокола], [Дата протокола], [Основание]) values (@табельный, @Дата_аттестацииата, @Решение, @Номер_протокола, @Дата_протокола, @Основание)";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@Дата_аттестацииата", date);
            SQLComm.Parameters.AddWithValue("@Решение", Решение);
            SQLComm.Parameters.AddWithValue("@Номер_протокола", Номер_протокола);
            SQLComm.Parameters.AddWithValue("@Дата_протокола", date2);
            SQLComm.Parameters.AddWithValue("@Основание", Основание);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }

        public static void Обновить_сведения_аттестации(string табельный, string Дата_аттестацииата, string Решение, string Номер_протокола, string Дата_протокола, string Основание, string id)
        {
            DateTime date = new DateTime(2000, 5, 5);
            DateTime date2 = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(Дата_аттестацииата);
                date2 = Convert.ToDateTime(Дата_протокола);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"update [Аттестация] SET [Дата аттестации]=@Дата_аттестацииата, [Решение комиссии] =@Решение, [Номер протокола]=@Номер_протокола, [Дата протокола]=@Дата_протокола, [Основание]=@Основание where [Табельный номер] = @табельный and [id аттестации] = {id}";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@Дата_аттестацииата", date);
            SQLComm.Parameters.AddWithValue("@Решение", Решение);
            SQLComm.Parameters.AddWithValue("@Номер_протокола", Номер_протокола);
            SQLComm.Parameters.AddWithValue("@Дата_протокола", date2);
            SQLComm.Parameters.AddWithValue("@Основание", Основание);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }

        public static void Внести_проф_подготовку(string табельный, string начала, string окончания, string Специальность, string Наименование_документа, string Дата, string Основание)
        {
            DateTime date = new DateTime(2000, 5, 5);
            DateTime date2 = new DateTime(2000, 5, 5);
            DateTime date3 = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(начала);
                date2 = Convert.ToDateTime(окончания);
                date3 = Convert.ToDateTime(Дата);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Профессиональная переподготовка] ([Табельный номер], [Дата начала переподготовки], [Дата окончания переподготовки], [Специальность], [Наименование документа], [Дата], [Основание]) values (@табельный, @начала, @окончания, @Специальность, @Наименование_документа, @Дата, @Основание)";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@начала", date);
            SQLComm.Parameters.AddWithValue("@окончания", date2);
            SQLComm.Parameters.AddWithValue("@Специальность", Специальность);
            SQLComm.Parameters.AddWithValue("@Наименование_документа", Наименование_документа);
            SQLComm.Parameters.AddWithValue("@Дата", date3);
            SQLComm.Parameters.AddWithValue("@Основание", Основание);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }
        public static void Обновить_проф_подготовку(string табельный, string начала, string окончания, string Специальность, string Наименование_документа, string Дата, string Основание, string id)
        {
            DateTime date = new DateTime(2000, 5, 5);
            DateTime date2 = new DateTime(2000, 5, 5);
            DateTime date3 = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(начала);
                date2 = Convert.ToDateTime(окончания);
                date3 = Convert.ToDateTime(Дата);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"update[Профессиональная переподготовка] SET  [Дата начала переподготовки]=@начала, [Дата окончания переподготовки]=@окончания, [Специальность]=@Специальность, [Наименование документа]=@Наименование_документа, [Дата] = @Дата, [Основание]=@Основание where [Табельный номер] = @табельный and [id переподготовки]= {id}";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@начала", date);
            SQLComm.Parameters.AddWithValue("@окончания", date2);
            SQLComm.Parameters.AddWithValue("@Специальность", Специальность);
            SQLComm.Parameters.AddWithValue("@Наименование_документа", Наименование_документа);
            SQLComm.Parameters.AddWithValue("@Дата", date3);
            SQLComm.Parameters.AddWithValue("@Основание", Основание);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

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

        public static void Внести_награды(string табельный, string Наименование_награды, string Наименование_документа, string Дата)
        {
            DateTime date = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(Дата);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Награды и почетные звания] ([Табельный номер], [Наименование награды], [Наименование документа], [Дата]) values (@табельный, @Наименование_награды, @Наименование_документа, @Дата)";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@Наименование_награды", Наименование_награды);
            SQLComm.Parameters.AddWithValue("@Наименование_документа", Наименование_документа);
            SQLComm.Parameters.AddWithValue("@Дата", date);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }
        public static void Обновить_награды(string табельный, string Наименование_награды, string Наименование_документа, string Дата, string id)
        {
            DateTime date = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(Дата);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"update [Награды и почетные звания] SET  [Наименование награды]=@Наименование_награды, [Наименование документа]=@Наименование_документа, [Дата]=@Дата where [Табельный номер] = @табельный and [id награды] = {id}";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@Наименование_награды", Наименование_награды);
            SQLComm.Parameters.AddWithValue("@Наименование_документа", Наименование_документа);
            SQLComm.Parameters.AddWithValue("@Дата", date);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }
        public static void Внести_льготы(string табельный, string Наименование_льготы, string Наименование_документа, string Дата_выдачи, string Основание)
        {
            DateTime date = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(Дата_выдачи);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Социальные льготы] ([Табельный номер], [Наименование льготы], [Наименование документа], [Дата выдачи], [Основание]) values (@табельный, @Наименование_льготы, @Наименование_документа, @Дата_выдачи, @Основание)";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@Наименование_льготы", Наименование_льготы);
            SQLComm.Parameters.AddWithValue("@Наименование_документа", Наименование_документа);
            SQLComm.Parameters.AddWithValue("@Дата_выдачи", date);
            SQLComm.Parameters.AddWithValue("@Основание", Основание);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }

        public static void Обновить_льготы(string табельный, string Наименование_льготы, string Наименование_документа, string Дата_выдачи, string Основание, string id)
        {
            DateTime date = new DateTime(2000, 5, 5);
            try
            {
                date = Convert.ToDateTime(Дата_выдачи);
            }
            catch (Exception)
            {

            }

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"update[Социальные льготы] SET [Наименование льготы]=@Наименование_льготы, [Наименование документа]=@Наименование_документа, [Дата выдачи]=@Дата_выдачи, [Основание]=@Основание where [Табельный номер] = @табельный and [id льготы]={id}";
            SQLComm.Parameters.AddWithValue("@табельный", табельный);
            SQLComm.Parameters.AddWithValue("@Наименование_льготы", Наименование_льготы);
            SQLComm.Parameters.AddWithValue("@Наименование_документа", Наименование_документа);
            SQLComm.Parameters.AddWithValue("@Дата_выдачи", date);
            SQLComm.Parameters.AddWithValue("@Основание", Основание);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }

        public static void Обновить_сотрудника(string Табельный_номер_Box, string Имя_Box, string Фамилия_Box, string Отчество_Box, string Пол_Box, string Телефон_Box)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"Update [Сотрудники] SET [Фамилия] = @Фамилия_Box, [Отчество] = @Отчество_Box, [Имя] = @Имя_Box, [Пол]=@Пол_Box, Телефон = @Телефон_Box  where [Табельный номер] = {Табельный_номер_Box}";
            SQLComm.Parameters.AddWithValue("@Фамилия_Box", Фамилия_Box);
            SQLComm.Parameters.AddWithValue("@Отчество_Box", Отчество_Box);
            SQLComm.Parameters.AddWithValue("@Имя_Box", Имя_Box);
            SQLComm.Parameters.AddWithValue("@Пол_Box", Пол_Box);
            SQLComm.Parameters.AddWithValue("@Телефон_Box", Телефон_Box);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }

        public static void Обновить_общие_сведения(string Param1, string Param2, string ИНН, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11, string Param12, string Param13, string Param14, string Param15, string Param16, string Param17, string Param18, string Param19, string Param20, string Param21, string Param22, string Param23, string Param24)
        {
           
                SQLConn = new SqlConnection(Path());
                SQLConn.Open();
                SQLComm.CommandType = CommandType.Text;

                SQLComm.CommandText = $"Update [Общие сведения] SET [Дата составления] = @Дата_составления, [ИНН] = @ИНН, [Номер пенсионного свидетельства] = @Номер_пенсионного_свидетельства, [Алфавит] = @Алфавит, [Характер работы] = @Характер_работы, [Вид работы] = @Вид_работы, [Дата рождения] = @Дата_рождения, [Место рождения] = @Место_рождения, [Код места рождения по ОКАТО] = @КодместаОКАТО, [Гражданство] = @Гражданство, [Код гражданства по ОКИН] = @КодгражданстваОКИН, [Инонстранный язык] = @Инонстранныйязык, [Код языка по ОКИН] = @КодязыкаОКИН, [Уровень знания языка] = @Уровеньязыка, [Код знания языка по ОКИН] = @КодзнанияязыкаОКИН, [Состояние в браке] = @Состояниевбраке, [Код брака по ОКИН] = @КодбракаОКИН, [Национальность] = @Национальность, [Номер медицинского полиса] = @Номермедицинскогополиса, [Образование] = @Образование, [Код образования по ОКИН] = @КодобразованияОКИН, [Номер договора] = @Номер_договора, [Дата договора] = @Дата_договора  where [Табельный номер] = {Param1}";
                SQLComm.Parameters.AddWithValue("@Дата_составления", Param2);
                SQLComm.Parameters.AddWithValue("@ИНН", ИНН);
                SQLComm.Parameters.AddWithValue("@Номер_пенсионного_свидетельства", Param4);
                SQLComm.Parameters.AddWithValue("@Алфавит", Param5);
                SQLComm.Parameters.AddWithValue("@Характер_работы", Param6);
                SQLComm.Parameters.AddWithValue("@Вид_работы", Param7);
                SQLComm.Parameters.AddWithValue("@Дата_рождения", Param8);
                SQLComm.Parameters.AddWithValue("@Место_рождения", Param9);
                SQLComm.Parameters.AddWithValue("@КодместаОКАТО", Param10);
                SQLComm.Parameters.AddWithValue("@Гражданство", Param11);
                SQLComm.Parameters.AddWithValue("@КодгражданстваОКИН", Param12);
                SQLComm.Parameters.AddWithValue("@Инонстранныйязык", Param13);
                SQLComm.Parameters.AddWithValue("@КодязыкаОКИН", Param14);
                SQLComm.Parameters.AddWithValue("@Уровеньязыка", Param15);
                SQLComm.Parameters.AddWithValue("@КодзнанияязыкаОКИН", Param16);
                SQLComm.Parameters.AddWithValue("@Состояниевбраке", Param17);
                SQLComm.Parameters.AddWithValue("@КодбракаОКИН", Param18);
                SQLComm.Parameters.AddWithValue("@Национальность", Param19);
                SQLComm.Parameters.AddWithValue("@Номермедицинскогополиса", Param20);
                SQLComm.Parameters.AddWithValue("@Образование", Param21);
                SQLComm.Parameters.AddWithValue("@КодобразованияОКИН", Param22);
                SQLComm.Parameters.AddWithValue("@Номер_договора", Param23);
                SQLComm.Parameters.AddWithValue("@Дата_договора", Param24);

                SQLComm.ExecuteScalar();

                SQLComm.Parameters.Clear();

        }

        public static void Обновить_сведения_паспорта(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11, string Param12)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"Update [Сведения паспорта] SET [Серия] = @Серия, [Номер] = @Номер, [Дата выдачи] = @Дата_выдачи, [Кем выдан]=@Кем_выдан, [Город регистрации] = @Город_регистрации, [Индекс регистрации]=@Индекс_регистрации, [Адрес регистрации]=@Адрес_регистрации, [Дата регистрации]=@Дата_регистрации, [Город проживания]=@Город_проживания, [Индекс города проживания]=@Индекс_города_проживания, [Адрес проживания]=@Адрес_проживания  where [Табельный номер] = {Param1}";
            SQLComm.Parameters.AddWithValue("@Серия", Param2);
            SQLComm.Parameters.AddWithValue("@Номер", Param3);
            SQLComm.Parameters.AddWithValue("@Дата_выдачи", Param4);
            SQLComm.Parameters.AddWithValue("@Кем_выдан", Param5);
            SQLComm.Parameters.AddWithValue("@Город_регистрации", Param6);
            SQLComm.Parameters.AddWithValue("@Индекс_регистрации", Param7);
            SQLComm.Parameters.AddWithValue("@Адрес_регистрации", Param8);
            SQLComm.Parameters.AddWithValue("@Дата_регистрации", Param9);
            SQLComm.Parameters.AddWithValue("@Город_проживания", Param10);
            SQLComm.Parameters.AddWithValue("@Индекс_города_проживания", Param11);
            SQLComm.Parameters.AddWithValue("@Адрес_проживания", Param12);
            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();

        }

        public static void Обновить_сведения_заграниченого_паспорта(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"Update [Сведения заграниченого паспорта] SET [Серия] = @Серия, [Номер] = @Номер, [Дата] = @Дата, [Кем выдан]=@Кем_выдан, [Срок действия] = @Срок_действия  where [Табельный номер] = {Param1}";
            SQLComm.Parameters.AddWithValue("@Серия", Param2);
            SQLComm.Parameters.AddWithValue("@Номер", Param3);
            SQLComm.Parameters.AddWithValue("@Дата", Param4);
            SQLComm.Parameters.AddWithValue("@Кем_выдан", Param5);
            SQLComm.Parameters.AddWithValue("@Срок_действия", Param6);

            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();
        }

        public static void Обновить_сведения_об_образовании(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11, string Param12, string Param13)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"Update [Сведения об образовании] SET [Наименование учебного заведения] = @Наименование_учебного_заведения, [Наименование документа] = @Наименование_документа, [Серия] = @Серия, [Номер]=@Номер, [Год окончания] = @Год_окончания, [Квалификация] = @Квалификация, [Направление / специальность] = @Направление_специальность, [Код ОКСО] = @Код_ОКСО, [Профессия Основная] = @Профессия_Основная, [Код по ОКПДТР основной] = @КодпоОКПДТРосновной, [Профессия другая] = @Профессия_другая, [Код по ОКПДТР другой] = @КодпоОКПДТРдругой  where [Табельный номер] = {Param1}";
            SQLComm.Parameters.AddWithValue("@Наименование_учебного_заведения", Param2);
            SQLComm.Parameters.AddWithValue("@Наименование_документа", Param3);
            SQLComm.Parameters.AddWithValue("@Серия", Param4);
            SQLComm.Parameters.AddWithValue("@Номер", Param5);
            SQLComm.Parameters.AddWithValue("@Год_окончания", Param6);
            SQLComm.Parameters.AddWithValue("@Квалификация", Param7);
            SQLComm.Parameters.AddWithValue("@Направление_специальность", Param8);
            SQLComm.Parameters.AddWithValue("@Код_ОКСО", Param9);
            SQLComm.Parameters.AddWithValue("@Профессия_Основная", Param10);
            SQLComm.Parameters.AddWithValue("@КодпоОКПДТРосновной", Param11);
            SQLComm.Parameters.AddWithValue("@Профессия_другая", Param12);
            SQLComm.Parameters.AddWithValue("@КодпоОКПДТРдругой", Param13);

            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();
        }

        public static void Обновить_cведения_о_послевузовском_образовании(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"Update [Сведения о послевузовском образовании] SET [Послевузовское образование] = @Послевузовское_образование, [Наименование учебного заведения] = @Наименование_учебного_заведения, [Дата выдачи] = @Дата_выдачи, [Год окончания]=@Год_окончания, [Наименование документа] = @Наименование_документа, [Документ №] = @Документ, [Направление / специальность] = @Направление_специальность, [Код ОКСО] = @Код_ОКСО  where [Табельный номер] = {Param1}";
            SQLComm.Parameters.AddWithValue("@Послевузовское_образование", Param2);
            SQLComm.Parameters.AddWithValue("@Наименование_учебного_заведения", Param3);
            SQLComm.Parameters.AddWithValue("@Дата_выдачи", Param4);
            SQLComm.Parameters.AddWithValue("@Год_окончания", Param5);
            SQLComm.Parameters.AddWithValue("@Наименование_документа", Param6);
            SQLComm.Parameters.AddWithValue("@Документ", Param7);
            SQLComm.Parameters.AddWithValue("@Направление_специальность", Param8);
            SQLComm.Parameters.AddWithValue("@Код_ОКСО", Param9);


            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();
        }

        public static void Обновить_сведения_о_воиснком_учёте(string Param1, string Param2, string Param3, string Param4, string Param5, string Param6, string Param7, string Param8, string Param9, string Param10, string Param11)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = $"Update [Сведения о воиснком учёте] SET [Категория запаса] = @Категория_запаса, [Воинское звание] = @Воинское_звание, [Состав] = @Состав, [Номер ВУС]=@Номер_ВУС, [ВУС] = ВУС, [Категория годности] = @Категория_годности, [Коммисариат] = @Коммисариат, [Общий воинский учет] = @Общийвоинскийучет, [Специальный воинский учет] = @Специальныйвоинскийучет, [Отметка о снятии с учета] = @Отметкаучета  where [Табельный номер] = {Param1}";
            SQLComm.Parameters.AddWithValue("@Категория_запаса", Param2);
            SQLComm.Parameters.AddWithValue("@Воинское_звание", Param3);
            SQLComm.Parameters.AddWithValue("@Состав", Param4);
            SQLComm.Parameters.AddWithValue("@Номер_ВУС", Param5);
            SQLComm.Parameters.AddWithValue("@ВУС", Param6);
            SQLComm.Parameters.AddWithValue("@Категория_годности", Param7);
            SQLComm.Parameters.AddWithValue("@Коммисариат", Param8);
            SQLComm.Parameters.AddWithValue("@Общийвоинскийучет", Param9);
            SQLComm.Parameters.AddWithValue("@Специальныйвоинскийучет", Param10);
            SQLComm.Parameters.AddWithValue("@Отметкаучета", Param11);


            SQLComm.ExecuteScalar();

            SQLComm.Parameters.Clear();
        }

        public static int Создать_семью(int Number)
        {

                SQLConn = new SqlConnection(Path());
                SQLConn.Open();
                SQLComm.CommandType = CommandType.Text;

                SQLComm.CommandText = "insert into [Состав семьи] ([Номер родственника], [Табельный номер сотрудника], [Фамилия], [Имя], [Отчество], [Дата рождения]) values(1, @Number1, null ,null , null, '2021.01.15')";
                SQLComm.Parameters.AddWithValue("@Number1", Number);
                SQLComm.ExecuteScalar();

                SQLComm.CommandText = "insert into [Состав семьи] ([Номер родственника], [Табельный номер сотрудника], [Фамилия], [Имя], [Отчество], [Дата рождения]) values(2, @Number2, null ,null , null, '2021.01.15')";
                SQLComm.Parameters.AddWithValue("@Number2", Number);
                SQLComm.ExecuteScalar();

                SQLComm.CommandText = "insert into [Состав семьи] ([Номер родственника], [Табельный номер сотрудника], [Фамилия], [Имя], [Отчество], [Дата рождения]) values(3, @Number3, null ,null , null, '2021.01.15')";
                SQLComm.Parameters.AddWithValue("@Number3", Number);
                SQLComm.ExecuteScalar();    

                SQLComm.CommandText = "insert into [Состав семьи] ([Номер родственника], [Табельный номер сотрудника], [Фамилия], [Имя], [Отчество], [Дата рождения]) values(4, @Number4, null ,null , null, '2021.01.15')";
                SQLComm.Parameters.AddWithValue("@Number4", Number);
                SQLComm.ExecuteScalar();    

                SQLComm.CommandText = "insert into [Состав семьи] ([Номер родственника], [Табельный номер сотрудника], [Фамилия], [Имя], [Отчество], [Дата рождения]) values(5, @Number5, null ,null , null, '2021.01.15')";
                SQLComm.Parameters.AddWithValue("@Number5", Number);
                SQLComm.ExecuteScalar();

                SQLComm.CommandText = "insert into [Состав семьи] ([Номер родственника], [Табельный номер сотрудника], [Фамилия], [Имя], [Отчество], [Дата рождения]) values(6, @Number6, null ,null , null, '2021.01.15')";
                SQLComm.Parameters.AddWithValue("@Number6", Number);
                SQLComm.ExecuteScalar();


                SQLConn.Close();

                SQLComm.Parameters.Clear();

                return Number;
        }

        public static int Создать_сведения_работы(int Number)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Приём и переводы на работу] ([Табельный номер], [Дата приёма на работу], [Номер договора], [Подразделение], [Дожность], [Оклад], [Основание]) values(@Number1, '2021.01.15', 1, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number1", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Приём и переводы на работу] ([Табельный номер], [Дата приёма на работу], [Номер договора], [Подразделение], [Дожность], [Оклад], [Основание]) values(@Number2, null, 1, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number2", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Приём и переводы на работу] ([Табельный номер], [Дата приёма на работу], [Номер договора], [Подразделение], [Дожность], [Оклад], [Основание]) values(@Number3, null, 1, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number3", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Приём и переводы на работу] ([Табельный номер], [Дата приёма на работу], [Номер договора], [Подразделение], [Дожность], [Оклад], [Основание]) values(@Number4, null, 1, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number4", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Приём и переводы на работу] ([Табельный номер], [Дата приёма на работу], [Номер договора], [Подразделение], [Дожность], [Оклад], [Основание]) values(@Number5, null, 1, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number5", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Приём и переводы на работу] ([Табельный номер], [Дата приёма на работу], [Номер договора], [Подразделение], [Дожность], [Оклад], [Основание]) values(@Number6, null, 1, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number6", Number);
            SQLComm.ExecuteScalar();


            SQLConn.Close();

            SQLComm.Parameters.Clear();

            return Number;
        }

        public static int Создать_аттестацию(int Number)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Аттестация] ([Табельный номер], [Дата аттестации], [Решение комиссии], [Номер протокола], [Дата протокола], [Основание]) values(@Number1, '2021.01.15', null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number1", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Аттестация] ([Табельный номер], [Дата аттестации], [Решение комиссии], [Номер протокола], [Дата протокола], [Основание]) values(@Number2, null, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number2", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Аттестация] ([Табельный номер], [Дата аттестации], [Решение комиссии], [Номер протокола], [Дата протокола], [Основание]) values(@Number3, null, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number3", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Аттестация] ([Табельный номер], [Дата аттестации], [Решение комиссии], [Номер протокола], [Дата протокола], [Основание]) values(@Number4, null, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number4", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Аттестация] ([Табельный номер], [Дата аттестации], [Решение комиссии], [Номер протокола], [Дата протокола], [Основание]) values(@Number5, null, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number5", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Аттестация] ([Табельный номер], [Дата аттестации], [Решение комиссии], [Номер протокола], [Дата протокола], [Основание]) values(@Number6, null, null, null, null, null)";
            SQLComm.Parameters.AddWithValue("@Number6", Number);
            SQLComm.ExecuteScalar();


            SQLConn.Close();

            SQLComm.Parameters.Clear();

            return Number;
        }

        public static int Создать_повышение_квалификации(int Number)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Повышение квалификации] ([Табельный номер], [Начало повышения квалификации], [Окончание повышения квалификации], [Вид повышения квалификации], [Наименование образовательного учреждения], [Наименование документа], [Серия документа], [Номер документа], [Дата], [Основание]) values(@Number1, '2021.01.15', '2021.01.20', null, null, null, null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number1", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Повышение квалификации] ([Табельный номер], [Начало повышения квалификации], [Окончание повышения квалификации], [Вид повышения квалификации], [Наименование образовательного учреждения], [Наименование документа], [Серия документа], [Номер документа], [Дата], [Основание]) values(@Number2, '2021.01.15', '2021.01.20', null, null, null, null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number2", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Повышение квалификации] ([Табельный номер], [Начало повышения квалификации], [Окончание повышения квалификации], [Вид повышения квалификации], [Наименование образовательного учреждения], [Наименование документа], [Серия документа], [Номер документа], [Дата], [Основание]) values(@Number3,'2021.01.15', '2021.01.20', null, null, null, null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number3", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Повышение квалификации] ([Табельный номер], [Начало повышения квалификации], [Окончание повышения квалификации], [Вид повышения квалификации], [Наименование образовательного учреждения], [Наименование документа], [Серия документа], [Номер документа], [Дата], [Основание]) values(@Number4, '2021.01.15', '2021.01.20', null, null, null, null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number4", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Повышение квалификации] ([Табельный номер], [Начало повышения квалификации], [Окончание повышения квалификации], [Вид повышения квалификации], [Наименование образовательного учреждения], [Наименование документа], [Серия документа], [Номер документа], [Дата], [Основание]) values(@Number5, '2021.01.15', '2021.01.20', null, null, null, null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number5", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Повышение квалификации] ([Табельный номер], [Начало повышения квалификации], [Окончание повышения квалификации], [Вид повышения квалификации], [Наименование образовательного учреждения], [Наименование документа], [Серия документа], [Номер документа], [Дата], [Основание]) values(@Number6,'2021.01.15', '2021.01.20', null, null, null, null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number6", Number);
            SQLComm.ExecuteScalar();
            SQLConn.Close();

            SQLComm.Parameters.Clear();

            return Number;
        }

        public static int Создать_проф_подготовку(int Number)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Профессиональная переподготовка] ([Табельный номер], [Дата начала переподготовки], [Дата окончания переподготовки], [Специальность], [Наименование документа], [Дата], [Основание]) values (@Number1, '2021.01.15', '2021.01.20', null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number1", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Профессиональная переподготовка] ([Табельный номер], [Дата начала переподготовки], [Дата окончания переподготовки], [Специальность], [Наименование документа], [Дата], [Основание]) values (@Number2, '2021.01.15', '2021.01.20', null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number2", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Профессиональная переподготовка] ([Табельный номер], [Дата начала переподготовки], [Дата окончания переподготовки], [Специальность], [Наименование документа], [Дата], [Основание]) values (@Number3, '2021.01.15', '2021.01.20', null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number3", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Профессиональная переподготовка] ([Табельный номер], [Дата начала переподготовки], [Дата окончания переподготовки], [Специальность], [Наименование документа], [Дата], [Основание]) values (@Number4, '2021.01.15', '2021.01.20', null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number4", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Профессиональная переподготовка] ([Табельный номер], [Дата начала переподготовки], [Дата окончания переподготовки], [Специальность], [Наименование документа], [Дата], [Основание]) values (@Number5, '2021.01.15', '2021.01.20', null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number5", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Профессиональная переподготовка] ([Табельный номер], [Дата начала переподготовки], [Дата окончания переподготовки], [Специальность], [Наименование документа], [Дата], [Основание]) values (@Number6, '2021.01.15', '2021.01.20', null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number6", Number);
            SQLComm.ExecuteScalar();

            SQLConn.Close();

            SQLComm.Parameters.Clear();

            return Number;
        }

        public static int Создать_награды(int Number)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Награды и почетные звания] ([Табельный номер], [Наименование награды], [Наименование документа], [Дата] ) values (@Number1, null, null, '2021.01.15')";
            SQLComm.Parameters.AddWithValue("@Number1", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Награды и почетные звания] ([Табельный номер], [Наименование награды], [Наименование документа], [Дата] ) values (@Number2 ,null, null, '2021.01.15')";
            SQLComm.Parameters.AddWithValue("@Number2", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Награды и почетные звания] ([Табельный номер], [Наименование награды], [Наименование документа], [Дата] ) values (@Number3, null, null, '2021.01.15')";
            SQLComm.Parameters.AddWithValue("@Number3", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Награды и почетные звания] ([Табельный номер], [Наименование награды], [Наименование документа], [Дата] ) values (@Number4 ,null, null, '2021.01.15')";
            SQLComm.Parameters.AddWithValue("@Number4", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Награды и почетные звания] ([Табельный номер], [Наименование награды], [Наименование документа], [Дата] ) values (@Number5, null, null, '2021.01.15')";
            SQLComm.Parameters.AddWithValue("@Number5", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Награды и почетные звания] ([Табельный номер], [Наименование награды], [Наименование документа], [Дата] ) values (@Number6, null, null, '2021.01.15')";
            SQLComm.Parameters.AddWithValue("@Number6", Number);
            SQLComm.ExecuteScalar();

            SQLConn.Close();

            SQLComm.Parameters.Clear();

            return Number;
        }
        public static int Создать_Льготы(int Number)
        {

            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "insert into [Социальные льготы] ([Табельный номер], [Наименование льготы], [Наименование документа], [Дата выдачи], [Основание]) values (@Number1,null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number1", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Социальные льготы] ([Табельный номер], [Наименование льготы], [Наименование документа], [Дата выдачи], [Основание] ) values (@Number2,null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number2", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Социальные льготы] ([Табельный номер], [Наименование льготы], [Наименование документа], [Дата выдачи], [Основание] ) values (@Number3,null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number3", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Социальные льготы] ([Табельный номер], [Наименование льготы], [Наименование документа], [Дата выдачи], [Основание] ) values (@Number4,null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number4", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Социальные льготы] ([Табельный номер], [Наименование льготы], [Наименование документа], [Дата выдачи], [Основание] ) values (@Number5,null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number5", Number);
            SQLComm.ExecuteScalar();

            SQLComm.CommandText = "insert into [Социальные льготы] ([Табельный номер], [Наименование льготы], [Наименование документа], [Дата выдачи], [Основание] ) values (@Number6,null, null, '2021.01.15', null)";
            SQLComm.Parameters.AddWithValue("@Number6", Number);
            SQLComm.ExecuteScalar();

            SQLConn.Close();

            SQLComm.Parameters.Clear();

            return Number;
        }

        public static void Удалить_атестацию(int Number)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "delete FROM [Аттестация] where [Табельный номер]= @Number7";
            SQLComm.Parameters.AddWithValue("@Number7", Number);
            SQLComm.ExecuteScalar();

            SQLConn.Close();

            SQLComm.Parameters.Clear();

        }
        public static void Удалить_семью(int Number)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "delete FROM [Состав семьи] where [Табельный номер сотрудника]= @Number7";
            SQLComm.Parameters.AddWithValue("@Number7", Number);
            SQLComm.ExecuteScalar();

            SQLConn.Close();

            SQLComm.Parameters.Clear();

        }
        public static void Удалить_сведения_работы(int Number)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "delete FROM [Приём и переводы на работу] where [Табельный номер]= @Number7";
            SQLComm.Parameters.AddWithValue("@Number7", Number);
            SQLComm.ExecuteScalar();

            SQLComm.ExecuteScalar();

            SQLConn.Close();

            SQLComm.Parameters.Clear();

        }

        public static void Удалить_повышение_квалификации(int Number)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "delete FROM [Повышение квалификации] where [Табельный номер]= @Number7";
            SQLComm.Parameters.AddWithValue("@Number7", Number);
            SQLComm.ExecuteScalar();

            SQLComm.ExecuteScalar();

            SQLConn.Close();

            SQLComm.Parameters.Clear();

        }
        public static void Удалить_проф_подготовку(int Number)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "delete FROM [Повышение квалификации] where [Табельный номер]= @Number7";
            SQLComm.Parameters.AddWithValue("@Number7", Number);
            SQLComm.ExecuteScalar();

            SQLComm.ExecuteScalar();

            SQLConn.Close();

            SQLComm.Parameters.Clear();

        }

        public static void Удалить_награды(int Number)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "delete FROM [Награды и почетные звания] where [Табельный номер]= @Number7";
            SQLComm.Parameters.AddWithValue("@Number7", Number);
            SQLComm.ExecuteScalar();

            SQLComm.ExecuteScalar();

            SQLConn.Close();

            SQLComm.Parameters.Clear();

        }

        public static void Удалить_Льготы(int Number)
        {
            SQLConn = new SqlConnection(Path());
            SQLConn.Open();
            SQLComm.CommandType = CommandType.Text;

            SQLComm.CommandText = "delete FROM [Социальные льготы] where [Табельный номер]= @Number7";
            SQLComm.Parameters.AddWithValue("@Number7", Number);
            SQLComm.ExecuteScalar();

            SQLComm.ExecuteScalar();

            SQLConn.Close();

            SQLComm.Parameters.Clear();

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