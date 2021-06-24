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
           
            InitializeComponent();
  
            this.StartPosition = FormStartPosition.CenterScreen;
            Имя_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Имя FROM Сотрудники WHERE [Табельный номер] = {id}");
            Фамилия_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Фамилия FROM Сотрудники WHERE [Табельный номер] = {id}");
            Отчество_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Отчество FROM Сотрудники WHERE [Табельный номер] = {id}");
            Должность_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дожность] FROM [Приём и переводы на работу] where [Табельный номер]= {id}");
            Подразделение_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Подразделение] FROM [Приём и переводы на работу] WHERE [Табельный номер] = {id}");
            Табельный_номер_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Табельный номер] FROM [Сотрудники] WHERE [Табельный номер] = {id}");

            Номер_документаBox.Text = "0";
            Дата_приказаPicker1Picker1.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата договора] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Дата_договораPicker2.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата заключения догвоора] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Номер_договора_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер договора] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Дата_увольнения_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата увольнения] FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");

            Причина_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Основание] FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");
            Основание_Box.Text = "0";
            Дата_основания_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата основания] FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");

           
        }
        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Уволить_Click(object sender, EventArgs e)
        {
            string key = Табельный_номер_Box.Text;
            connection.Внести_cведения_об_уволенных(Имя_Box.Text, Фамилия_Box.Text, Отчество_Box.Text, Должность_Box.Text, Подразделение_Box.Text, Табельный_номер_Box.Text, Номер_документаBox.Text, Дата_приказаPicker1Picker1.Text, Дата_договораPicker2.Text, Номер_договора_Box.Text, Дата_увольнения_Picker.Text, Причина_Box.Text, Основание_Box.Text, Дата_основания_Picker.Text);
            connection.Получить_сведения_из_базы_данных($"delete from [Аттестация] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Награды и почетные звания] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Приём и переводы на работу] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Профессиональная переподготовка] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Сведения о воиснком учёте] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Сведения о воиснком учёте] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Сведения о послевузовском образовании] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Сведения о принятых на работу] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Сведения об образовании] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Сведения паспорта] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Социальные льготы] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Стаж работы] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Сведения заграниченого паспорта] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Общие сведения] where [Табельный номер]={key}");
            connection.Получить_сведения_из_базы_данных($"delete from [Сотрудники] where [Табельный номер]={key}");

            MessageBox.Show($"Сотрудник {Фамилия_Box.Text} {Имя_Box.Text} {Отчество_Box.Text} был уволен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}