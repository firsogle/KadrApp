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

namespace NextGenKadr
{
    public partial class AddPerson : Form
    {
        string action = string.Empty;
        string key = string.Empty;
        public AddPerson()
        {
            InitializeComponent();

        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Button_Ok_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];


            connection.Сведения_о_сотрудниках(Фамилия_Box.Text, Имя_Box.Text, Отчество_Box.Text, Пол_Box.Text);
            string TabNumber = connection.id($"SELECT MAX ([Табельный номер]) FROM Сотрудники");
            connection.Внести_общие_сведения(TabNumber, Телефон_Box.Text, Дата_выдачи_Picker.Text, Подразделение_Box.Text, Семейное_положение_Box.Text, Гражданство_Box.Text, Национальность_Box.Text, Номер_страхового_полиса_Box.Text, ИНН_Box.Text, Номер_мед_полиса_Box.Text, Пенсионное_свидетельство_Box.Text);
            connection.Внести_сведения_паспорта(TabNumber, Серия_Box.Text, Номер_Box.Text, Дата_выдачи_Picker.Text, Кем_выдан_Box.Text, Город_Box.Text, Индекс_Box.Text, Улица_Box.Text);
            connection.Внести_сведения_заграниченого_паспорта(TabNumber, Серия_загран_Box.Text, Номер_загран_Box.Text, Номер_загран_Box.Text, Кем_выдан_загран_Box.Text, Срок_выдачи_загран_Picker.Text);
            connection.Внести_сведения_об_образовании(TabNumber, Уровень_образования_Box.Text, Номер_образование_Box.Text, Наименование_учебного_заведения_Box.Text, Серия_образование_Box.Text, Квалификация_Box.Text, Специальность_Box.Text);
            connection.Внести_cведения_о_послевузовском_образовании(TabNumber, Название_документа_Box.Text, Наименование_выдававшего_органа_Box.Text, Направление_Box.Text, Документ_Num_Box.Text, Ученая_степень_Box.Text);
            connection.Внести_сведения_о_воиснком_учёте(TabNumber, Воинское_звание_Box.Text, Номер_ВУС_Box.Text, Военно_учетная_специальность_Box.Text, Коммисариат_Box.Text, Категория_запаса_Box.Text, Состав_Box.Text, Категория_годности_Box.Text);
            connection.Внести_трудовую_деятельность(TabNumber, Дата_приёма_на_работу_TimePicker.Text, Num_Договора_Box.Text, Дата_договора_TimePicker.Text, Num_Приказа_Box.Text, Дата_приказа_Box.Text, Срок_договора_Box.Text);
        
        }
        private void Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
        }
        private void Next3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
        }
        private void Next2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
        }
        private void Back2_click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
        }
        private void Back3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
        }
        private void Back4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Next_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
