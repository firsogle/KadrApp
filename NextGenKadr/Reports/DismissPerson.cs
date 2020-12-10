using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextGenKadr
{
    public partial class DeletePerson : Form
    {
        string key = string.Empty;
        public DeletePerson (string id )
        {
            string key = id;
            InitializeComponent();
            Имя_Box.Text = connection.ReadDB($"SELECT Имя FROM Сотрудники WHERE [Табельный номер] = {id}");
            Фамилия_Box.Text = connection.ReadDB($"SELECT Фамилия FROM Сотрудники WHERE [Табельный номер] = {id}");
            Отчество_Box.Text = connection.ReadDB($"SELECT Отчество FROM Сотрудники WHERE [Табельный номер] = {id}");
            Должность_Box.Text = connection.ReadDB($"SELECT [Должность] FROM [Сведения о заработной плате] WHERE [Табельный номер] = {id}");
            Телефон_Box.Text = connection.ReadDB($"SELECT Телефон FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Номер_договора_Box.Text = connection.ReadDB($"SELECT [Номер договора] FROM [Трудовая деятельность] WHERE [Табельный номер] = {id}");
            Срок_договора_Picker.Text = connection.ReadDB($"SELECT [Срок договора] FROM [Трудовая деятельность] WHERE [Табельный номер] = {id}");
        }
        private void But_Del_Click(object sender, EventArgs e)
        {
            //connection.Insert($"INSERT INTO DeletePersons (Причина, [Номер приказа], Имя, Фамилия, Отчество, Телефон, [ID пользователя]) VALUES (N'{Reason.Text}', N'{IdReason.Text}', N'{Surname_Box.Text}', N'{Name_Box.Text}', N'{Patronymic_Box.Text}', N'{Phone_Box.Text}', {key})");
            connection.DeletePerson($"Delete FROM LaborActiv WHERE ID = {key}");
            connection.DeletePerson($"Delete FROM Passport WHERE ID = {key}");
            connection.DeletePerson($"Delete FROM EducMil WHERE ID = {key}");
            connection.DeletePerson($"Delete FROM General WHERE ID = {key}");
          //  connection.Insert($"INSERT INTO Journal ([User], Time, Action, Famaly, Name, Surname) VALUES (N'{Data.UserAuthorization}',N'{Data.Today}',N'{"Увольнение сотрудника"}',N'{Surname_Box.Text}',N'{Name_Box.Text}',N'{Patronymic_Box.Text}')");
            
        }
    }
}