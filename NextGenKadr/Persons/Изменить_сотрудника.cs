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
    public partial class UpdatePerson : Form
    {
        string key = string.Empty;

        public UpdatePerson(string id )
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Имя_Box.Text = connection.ReadDB($"SELECT Имя FROM Сотрудники WHERE [Табельный номер] = {id}");
            Фамилия_Box.Text = connection.ReadDB($"SELECT Фамилия FROM Сотрудники WHERE [Табельный номер] = {id}");
            Отчество_Box.Text = connection.ReadDB($"SELECT Отчество FROM Сотрудники WHERE [Табельный номер] = {id}");
            Пол_Box.Text = connection.ReadDB($"SELECT Пол FROM Сотрудники WHERE [Табельный номер] = {id}");
            Табельный_номер_Box.Text = connection.ReadDB($"SELECT [Табельный номер] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Телефон_Box.Text = connection.ReadDB($"SELECT Телефон FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Дата_рождения_Picker.Text = connection.ReadDB($"SELECT [Дата рождения] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Подразделение_Box.Text = connection.ReadDB($"SELECT Подразделение FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Пенсионное_свидетельство_Box.Text = connection.ReadDB($"SELECT [Пенсионное свидетельство] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Номер_мед_полиса_Box.Text = connection.ReadDB($"SELECT [Номер мед. полиса] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            ИНН_Box.Text = connection.ReadDB($"SELECT ИНН FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Гражданство_Box.Text = connection.ReadDB($"SELECT Гражданство FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Национальность_Box.Text = connection.ReadDB($"SELECT Национальность FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Семейное_положение_Box.Text = connection.ReadDB($"SELECT [Семейное положение] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Серия_Box.Text = connection.ReadDB($"SELECT Серия FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Номер_Box.Text = connection.ReadDB($"SELECT Номер FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Дата_выдачи_Picker.Text = connection.ReadDB($"SELECT [Дата выдачи] регистрации FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Кем_выдан_Box.Text = connection.ReadDB($"SELECT [Кем выдан] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Город_Box.Text = connection.ReadDB($"SELECT [Город регистрации] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Индекс_Box.Text = connection.ReadDB($"SELECT Индекс FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Улица_Box.Text = connection.ReadDB($"SELECT Улица FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Серия_загран_Box.Text = connection.ReadDB($"SELECT Серия FROM [Сведения заграниченого паспорта] WHERE [Табельный номер] = {id}");
            Номер_загран_Box.Text = connection.ReadDB($"SELECT Номер FROM [Сведения заграниченого паспорта] WHERE [Табельный номер] = {id}");
            Дата_выдачи_загран_Picker.Text = connection.ReadDB($"SELECT Дата FROM [Сведения заграниченого паспорта] WHERE [Табельный номер] = {id}");
            Кем_выдан_загран_Box.Text = connection.ReadDB($"SELECT [Кем выдан] FROM [Сведения заграниченого паспорта] WHERE [Табельный номер] = {id}");
            Наименование_документа_Box.Text = connection.ReadDB($"SELECT [Наименование документа] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Наименование_учебного_заведения_Box.Text = connection.ReadDB($"SELECT [Наименование учебного заведения] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Специальность_Box.Text = connection.ReadDB($"SELECT Специальность FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Серия_образование_Box.Text = connection.ReadDB($"SELECT Серия FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Номер_образование_Box.Text = connection.ReadDB($"SELECT Номер FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Квалификация_Box.Text = connection.ReadDB($"SELECT Квалицикация FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Название_документа_Box.Text = connection.ReadDB($"SELECT [Наименование документа] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Документ_Num_Box.Text = connection.ReadDB($"SELECT [№ Документа] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Наименование_учебного_заведения_После_Box.Text = connection.ReadDB($"SELECT [Наименование учебного заведения] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Ученая_степень_Box.Text = connection.ReadDB($"SELECT [Ученая степень] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Направление_Box.Text = connection.ReadDB($"SELECT Направление FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Воинское_звание_Box.Text = connection.ReadDB($"SELECT [Воинское звание] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Номер_ВУС_Box.Text = connection.ReadDB($"SELECT [Номер ВУС] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Военно_учетная_специальность_Box.Text = connection.ReadDB($"SELECT [Военно-учетная специальность] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Коммисариат_Box.Text = connection.ReadDB($"SELECT [Коммисариат] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Категория_запаса_Box.Text = connection.ReadDB($"SELECT [Категория запаса] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Состав_Box.Text = connection.ReadDB($"SELECT Состав FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Категория_годности_Box.Text = connection.ReadDB($"SELECT [Категория годности] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Дата_приёма_на_работу_TimePicker.Text = connection.ReadDB($"SELECT [Дата приёма на работу] FROM [Трудовая деятельность] WHERE [Табельный номер] = {id}");
            Num_Договора_Box.Text = connection.ReadDB($"SELECT [Номер договора] FROM [Трудовая деятельность] WHERE [Табельный номер] = {id}");
            Дата_договора_TimePicker.Text = connection.ReadDB($"SELECT [Дата заключения договора] FROM [Трудовая деятельность] WHERE [Табельный номер] = {id}");
            Num_Приказа_Box.Text = connection.ReadDB($"SELECT [Номер приказа] FROM [Трудовая деятельность] WHERE [Табельный номер] = {id}");
            Дата_приказа_Box.Text = connection.ReadDB($"SELECT [Дата приказа] FROM [Трудовая деятельность] WHERE [Табельный номер] = {id}");
            Срок_договора_Box.Text = connection.ReadDB($"SELECT [Срок договора] FROM [Трудовая деятельность] WHERE [Табельный номер] = {id}");
            Должность_Box.Text = connection.ReadDB($"SELECT [Должность] FROM [Сведения о заработной плате] WHERE [Табельный номер] = {id}");
            Надбавка_Box.Text = connection.ReadDB($"SELECT [Надбавка] FROM [Сведения о заработной плате] WHERE [Табельный номер] = {id}");
            Категория_Box.Text = connection.ReadDB($"SELECT [Категория] FROM [Сведения о заработной плате] WHERE [Табельный номер] = {id}");
            Оклад_Box.Text = connection.ReadDB($"SELECT [Оклад] FROM [Сведения о заработной плате] WHERE [Табельный номер] = {id}");
            Ставка_Box.Text = connection.ReadDB($"SELECT [Ставка] FROM [Сведения о заработной плате] WHERE [Табельный номер] = {id}");
            Стаж_работы_Box.Text = connection.ReadDB($"SELECT [Стаж работы] FROM [Сведения о заработной плате] WHERE [Табельный номер] = {id}");

            return;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
            try
            {
                connection.Обновить_общие_сведения(Телефон_Box.Text, Дата_рождения_Picker.Text, Подразделение_Box.Text, Семейное_положение_Box.Text, Гражданство_Box.Text, Национальность_Box.Text, Номер_страхового_полиса_Box.Text, ИНН_Box.Text, Номер_мед_полиса_Box.Text, Пенсионное_свидетельство_Box.Text);
            }
            catch (Exception sit2)
            {
                MessageBox.Show(sit2.Message);
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {

        }
    }
}

               