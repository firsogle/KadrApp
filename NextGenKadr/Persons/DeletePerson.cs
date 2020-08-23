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
        public DeletePerson (string id = "")
        {
            key = id;
            InitializeComponent();
            if (!string.IsNullOrEmpty(Surname_Box.Text = connection.ReadDB($"SELECT Фамилия FROM General WHERE ID = {key}")))
            {
                Surname_Box.Text = connection.ReadDB($"SELECT Фамилия FROM General WHERE ID = {key}");
            }
            if (!string.IsNullOrEmpty(Name_Box.Text = connection.ReadDB($"SELECT Имя FROM General WHERE ID = {key}")))
            {
                Name_Box.Text = connection.ReadDB($"SELECT Имя FROM General WHERE ID = {key}");
            }
            if (!string.IsNullOrEmpty(Patronymic_Box.Text = connection.ReadDB($"SELECT Отчество FROM General WHERE ID = {key}")))
            {
                Patronymic_Box.Text = connection.ReadDB($"SELECT Отчество FROM General WHERE ID = {key}");
            }
            if (!string.IsNullOrEmpty(Position_Box.Text = connection.ReadDB($"SELECT Position FROM LaborActiv WHERE ID = {key}")))
            {
                Position_Box.Text = connection.ReadDB($"SELECT Position FROM LaborActiv WHERE ID = {key}");
            }
            if (!string.IsNullOrEmpty(Phone_Box.Text = connection.ReadDB($"SELECT Position FROM LaborActiv WHERE ID = {key}")))
            {
                Phone_Box.Text = connection.ReadDB($"SELECT Position FROM LaborActiv WHERE ID = {key}");
            }
            if (!string.IsNullOrEmpty(NumberContract_Box.Text = connection.ReadDB($"SELECT NumberContract FROM LaborActiv WHERE ID = {key}")))
            {
                NumberContract_Box.Text = connection.ReadDB($"SELECT NumberContract FROM LaborActiv WHERE ID = {key}");
            }
            if (!string.IsNullOrEmpty(ContractTerm_Picker.Text = connection.ReadDB($"SELECT ContractTerm FROM LaborActiv WHERE ID = {key}")))
            {
                ContractTerm_Picker.Text = connection.ReadDB($"SELECT ContractTerm FROM LaborActiv WHERE ID = {key}");
            }
        }
        private void But_Del_Click(object sender, EventArgs e)
        {
            connection.Build($"INSERT INTO DeletePersons (Причина, [Номер приказа], Имя, Фамилия, Отчество, Телефон, [ID пользователя]) VALUES (N'{Reason.Text}', N'{IdReason.Text}', N'{Surname_Box.Text}', N'{Name_Box.Text}', N'{Patronymic_Box.Text}', N'{Phone_Box.Text}', {key})");
            connection.DeletePerson($"Delete FROM LaborActiv WHERE ID = {key}");
            connection.DeletePerson($"Delete FROM Passport WHERE ID = {key}");
            connection.DeletePerson($"Delete FROM EducMil WHERE ID = {key}");
            connection.DeletePerson($"Delete FROM General WHERE ID = {key}");
            connection.Build($"INSERT INTO Journal ([User], Time, Action, Famaly, Name, Surname) VALUES (N'{Data.UserAuthorization}',N'{Data.Today}',N'{"Увольнение сотрудника"}',N'{Surname_Box.Text}',N'{Name_Box.Text}',N'{Patronymic_Box.Text}')");
            
        }
    }
}