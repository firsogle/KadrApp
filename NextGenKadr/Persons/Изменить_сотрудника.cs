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
            Имя_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Имя FROM Сотрудники WHERE [Табельный номер] = {id}");
            Фамилия_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Фамилия FROM Сотрудники WHERE [Табельный номер] = {id}");
            Отчество_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Отчество FROM Сотрудники WHERE [Табельный номер] = {id}");
            Пол_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Пол FROM Сотрудники WHERE [Табельный номер] = {id}");
            Телефон_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Телефон] FROM Сотрудники WHERE [Табельный номер] = {id}");

            Дата_составления_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата составления] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Табельный_номер_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Табельный номер] FROM [Сотрудники] WHERE [Табельный номер] = {id}");
            ИНН_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT ИНН FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Пенсионное_свидетельство_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер пенсионного свидетельства] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Алфавит_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Алфавит] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Характер_работы_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Характер работы] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Вид_работы_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Вид работы] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Дата_рождения_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата рождения] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Место_рождения_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Место рождения] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Место_рождения_ОКАТА_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Код места рождения по ОКАТО] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Гражданство_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Гражданство] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Гражданство_ОКИН_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Код гражданства по ОКИН] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Знание_языка_название_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Инонстранный язык] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Язык_ОКИН_Имя_Combobox.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Код языка по ОКИН] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Знание_языка_степень_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Уровень знания языка] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Язык_ОКИН_Степень_Combobox.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Код знания языка по ОКИН] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Семейное_положение_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Состояние в браке] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Код_по_ОКИН_БракBox.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Код брака по ОКИН] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Национальность_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Национальность] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Номер_мед_полиса_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер медицинского полиса] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Образование_comboBox.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Образование] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Образование_по_ОКИН_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Образование] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Num_Договора_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер договора] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Дата_договора_TimePicker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата договора] FROM [Общие сведения] WHERE [Табельный номер] = {id}");

            Наименование_учебного_заведения_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Наименование учебного заведения] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Наименование_документа_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Наименование документа] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Серия_образование_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Серия] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Номер_образование_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Год_окончания_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Год окончания] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Квалификация_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Квалификация] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Специальность_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Направление / специальность] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Код_ОКСО_1_Combobox.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Код ОКСО] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Профессия_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Профессия Основная] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            ОКПДТР_1_comboBox.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Код по ОКПДТР основной] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            Профессия_2_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Профессия другая] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");
            ОКПДТР_2_comboBox.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Код по ОКПДТР другой] FROM [Сведения об образовании] WHERE [Табельный номер] = {id}");

            Послевузовское_образование_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Послевузовское образование] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Наименование_учебного_заведения_После_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Наименование учебного заведения] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Дата_выдачи_после_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата выдачи] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Год_окончания_после_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Год окончания] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Наименование_документа_после_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Наименование документа] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Документ_Num_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Документ №] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Направление_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Направление / специальность] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Послевузовское_образование_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Послевузовское образование] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");
            Код_ОКСО_3_Combobox.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Код ОКСО] FROM [Сведения о послевузовском образовании] WHERE [Табельный номер] = {id}");

            Серия_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Серия] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Номер_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Дата_выдачи_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата выдачи] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Кем_выдан_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Кем выдан] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Город_регистрации_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Город регистрации] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Индекс_регистрации_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Индекс регистрации] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Адрес_регистрации_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Адрес регистрации] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Дата_регистрации_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата регистрации] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Город_проживания_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Город проживания] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Индекс_проживания_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Индекс города проживания] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");
            Адрес_проживания_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Адрес проживания] FROM [Сведения паспорта] WHERE [Табельный номер] = {id}");

            Grid_Family.DataSource = connection.ReloadGrid($"SELECT [Номер родственника], [Степень родства], [Фамилия], [Имя], [Отчество], [Дата рождения], [id Родственника] FROM [Состав семьи] where [Табельный номер сотрудника]= {id}").Tables[0].DefaultView;
            
            Grid_Work.DataSource = connection.ReloadGrid($"SELECT [Дата приёма на работу], [Номер договора], [Подразделение], [Дожность], [Оклад], [Основание], [id Приёма на работу] FROM [Приём и переводы на работу] where [Табельный номер]= {id}").Tables[0].DefaultView;
            Grid_аттестация.DataSource = connection.ReloadGrid($"SELECT [Дата аттестации], [Решение комиссии], [Номер протокола], [Дата протокола], [Основание] , [id аттестации], [id аттестации] FROM [Аттестация] where [Табельный номер]= {id}").Tables[0].DefaultView;
            Grid_квалификация.DataSource = connection.ReloadGrid($"SELECT [Начало повышения квалификации], [Окончание повышения квалификации], [Вид повышения квалификации], [Наименование образовательного учреждения], [Наименование документа], [Серия документа], [Номер документа], [Дата], [Основание], [Id повышения квалификации] FROM [Повышение квалификации] where [Табельный номер]= {id}").Tables[0].DefaultView;
            Grid_переподготовка_сотрудника.DataSource = connection.ReloadGrid($"SELECT [Дата начала переподготовки], [Дата окончания переподготовки], [Специальность], [Наименование документа], [Дата], [Основание], [id переподготовки] FROM [Профессиональная переподготовка] where [Табельный номер]= {id}").Tables[0].DefaultView;
            Grid_награды.DataSource = connection.ReloadGrid($"SELECT [Наименование награды], [Наименование документа], [Дата], [id награды] FROM [Награды и почетные звания] where [Табельный номер]={id}").Tables[0].DefaultView;
            Grid_отпуск.DataSource = connection.ReloadGrid($"SELECT [Номер документа], [Дата приказа], [Начало отпуска А], [Окончание отпуска А], [Начало отпуска Б], [Окончание отпуска Б], [Id отпуска] FROM [Сведения об отпусках] where [Табельный номер]= {id}").Tables[0].DefaultView;
            Grid_льготы.DataSource = connection.ReloadGrid($"SELECT[Наименование льготы], [Наименование документа], [Дата выдачи], [Основание], [id льготы] FROM[Социальные льготы] where[Табельный номер] = { id}").Tables[0].DefaultView;


            Серия_загран_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Серия] FROM [Сведения заграниченого паспорта] WHERE [Табельный номер] = {id}");
            Номер_загран_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер] FROM [Сведения заграниченого паспорта] WHERE [Табельный номер] = {id}");
            Дата_выдачиa_загран_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата] FROM [Сведения заграниченого паспорта] WHERE [Табельный номер] = {id}");
            Кем_выдан_загран_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Серия] FROM [Кем выдан] WHERE [Табельный номер] = {id}");
            Срок_выдачи_загран_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Срок действия] FROM [Сведения заграниченого паспорта] WHERE [Табельный номер] = {id}");

            Общий_Дней_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Общий день] FROM [Стаж работы] WHERE [Табельный номер] = {id}");
            Стаж_на_момент_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата стажа] FROM [Стаж работы] WHERE [Табельный номер] = {id}");
            Общий_Месяцев_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Общий месяцев] FROM [Стаж работы] WHERE [Табельный номер] = {id}");
            Общий_Лет_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Общий лет] FROM [Стаж работы] WHERE [Табельный номер] = {id}");
            Непрерывный_дней_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Непрерывный дней] FROM [Стаж работы] WHERE [Табельный номер] = {id}");
            Непрерывный_месяцев_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Непрерывный месяцев] FROM [Стаж работы] WHERE [Табельный номер] = {id}");
            Непрерывный_лет_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Непрерывный лет] FROM [Стаж работы] WHERE [Табельный номер] = {id}");
            Выслуга_лет_Дней_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Выслуга лет дней] FROM [Стаж работы] WHERE [Табельный номер] = {id}");
            Выслуга_лет_Месяцев_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Выслуга лет месяцев] FROM [Стаж работы] WHERE [Табельный номер] = {id}");
            Выслуга_лет_Лет_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Выслуга лет лет] FROM [Стаж работы] WHERE [Табельный номер] = {id}");

            Категория_запаса_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Категория запаса] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Воинское_звание_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Воинское звание] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Состав_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Состав] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Номер_ВУС_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер ВУС] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            ВУС_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [ВУС] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Категория_годности_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Категория годности] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Комиссариат_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Коммисариат] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Общий_учет_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Общий воинский учет] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Спец_учет_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Специальный воинский учет] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");
            Отметка_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Отметка о снятии с учета] FROM [Сведения о воиснком учёте] WHERE [Табельный номер] = {id}");

            return;
        }



        private void Обновить_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage8"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage7"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage6"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage5"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];

            connection.Обновить_сотрудника(Табельный_номер_Box.Text, Имя_Box.Text, Фамилия_Box.Text, Отчество_Box.Text, Пол_Box.Text, Телефон_Box.Text);
            connection.Обновить_общие_сведения(Табельный_номер_Box.Text, Дата_составления_Picker.Text, ИНН_Box.Text, Пенсионное_свидетельство_Box.Text, Алфавит_Box.Text, Характер_работы_Box.Text, Вид_работы_Box.Text, Дата_рождения_Picker.Text, Место_рождения_Box.Text, Место_рождения_ОКАТА_Box.Text, Гражданство_Box.Text, Гражданство_ОКИН_Box.Text, Знание_языка_название_Box.Text, Язык_ОКИН_Имя_Combobox.Text, Знание_языка_степень_Box.Text, Язык_ОКИН_Степень_Combobox.Text, Семейное_положение_Box.Text, Код_по_ОКИН_БракBox.Text, Национальность_Box.Text, Номер_мед_полиса_Box.Text, Образование_comboBox.Text, Образование_по_ОКИН_Box.Text, Num_Договора_Box.Text, Дата_договора_TimePicker.Text);
            connection.Обновить_сведения_паспорта(Табельный_номер_Box.Text, Серия_Box.Text, Номер_Box.Text, Дата_выдачи_Picker.Text, Кем_выдан_Box.Text, Город_регистрации_Box.Text, Индекс_регистрации_Box.Text, Адрес_регистрации_Box.Text, Дата_регистрации_Picker.Text, Город_проживания_Box.Text, Индекс_проживания_Box.Text, Адрес_проживания_Box.Text);
            connection.Обновить_сведения_заграниченого_паспорта(Табельный_номер_Box.Text, Серия_загран_Box.Text, Номер_загран_Box.Text, Дата_выдачи_Picker.Text, Кем_выдан_загран_Box.Text, Срок_выдачи_загран_Picker.Text);
            connection.Обновить_сведения_об_образовании(Табельный_номер_Box.Text, Наименование_учебного_заведения_Box.Text, Наименование_документа_Box.Text, Серия_образование_Box.Text, Номер_образование_Box.Text, Год_окончания_Box.Text, Квалификация_Box.Text, Специальность_Box.Text, Код_ОКСО_1_Combobox.Text, Профессия_Box.Text, ОКПДТР_1_comboBox.Text, Профессия_2_Box.Text, ОКПДТР_2_comboBox.Text);
            connection.Обновить_cведения_о_послевузовском_образовании(Табельный_номер_Box.Text, Послевузовское_образование_Box.Text, Наименование_учебного_заведения_После_Box.Text, Дата_выдачи_после_Box.Text, Год_окончания_после_Box.Text, Наименование_документа_после_Box.Text, Документ_Num_Box.Text, Направление_Box.Text, Код_ОКСО_3_Combobox.Text);
            connection.Обновить_сведения_о_воиснком_учёте(Табельный_номер_Box.Text, Категория_запаса_Box.Text, Воинское_звание_Box.Text, Состав_Box.Text, Номер_ВУС_Box.Text, ВУС_Box.Text, Категория_годности_Box.Text, Комиссариат_Box.Text, Общий_учет_Box.Text, Спец_учет_Box.Text, Отметка_Box.Text);


            foreach (DataGridViewRow row in Grid_Family.Rows)
            {
                connection.Обновить_сведения_о_семье(row.Cells["Номер родственника"].Value.ToString(),
                                                row.Cells["Степень родства"].Value.ToString(),
                                                Табельный_номер_Box.Text,
                                                row.Cells["Фамилия"].Value.ToString(),
                                                row.Cells["Имя"].Value.ToString(),
                                                row.Cells["Отчество"].Value.ToString(),
                                                row.Cells["Дата рождения"].Value.ToString(),
                                                row.Cells["id Родственника"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_Work.Rows)
            {
                connection.Обновить_сведения_приёмов_и_переводов(Табельный_номер_Box.Text,
                                                row.Cells["Дата приёма на работу"].Value.ToString(),
                                                row.Cells["Номер договора"].Value.ToString(),
                                                row.Cells["Подразделение"].Value.ToString(),
                                                row.Cells["Дожность"].Value.ToString(),
                                                row.Cells["Оклад"].Value.ToString(),
                                                row.Cells["Основание"].Value.ToString(),
                                                row.Cells["id Приёма на работу"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_аттестация.Rows)
            {
                connection.Обновить_сведения_аттестации(Табельный_номер_Box.Text,
                                                row.Cells["Дата аттестации"].Value.ToString(),
                                                row.Cells["Решение комиссии"].Value.ToString(),
                                                row.Cells["Номер протокола"].Value.ToString(),
                                                row.Cells["Дата протокола"].Value.ToString(),
                                                row.Cells["Основание"].Value.ToString(),
                                                row.Cells["id аттестации"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_квалификация.Rows)
            {
                connection.Обновить_Повышение_квалификации(Табельный_номер_Box.Text,
                                                row.Cells["Начало повышения квалификации"].Value.ToString(),
                                                row.Cells["Окончание повышения квалификации"].Value.ToString(),
                                                row.Cells["Вид повышения квалификации"].Value.ToString(),
                                                row.Cells["Наименование образовательного учреждения"].Value.ToString(),
                                                row.Cells["Наименование документа"].Value.ToString(),
                                                row.Cells["Серия документа"].Value.ToString(),
                                                row.Cells["Номер документа"].Value.ToString(),
                                                row.Cells["Дата"].Value.ToString(),
                                                row.Cells["Основание"].Value.ToString(),
                                                row.Cells["Id повышения квалификации"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_переподготовка_сотрудника.Rows)
            {
                connection.Обновить_проф_подготовку(Табельный_номер_Box.Text,
                                                row.Cells["Дата начала переподготовки"].Value.ToString(),
                                                row.Cells["Дата окончания переподготовки"].Value.ToString(),
                                                row.Cells["Специальность"].Value.ToString(),
                                                row.Cells["Наименование документа"].Value.ToString(),
                                                row.Cells["Дата"].Value.ToString(),
                                                row.Cells["Основание"].Value.ToString(),
                                                row.Cells["id переподготовки"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_награды.Rows)
            {
                connection.Обновить_награды(Табельный_номер_Box.Text,
                                                row.Cells["Наименование награды"].Value.ToString(),
                                                row.Cells["Наименование документа"].Value.ToString(),
                                                row.Cells["Дата"].Value.ToString(),
                                                row.Cells["id награды"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_льготы.Rows)
            {
                connection.Обновить_льготы(Табельный_номер_Box.Text,
                                                row.Cells["Наименование льготы"].Value.ToString(),
                                                row.Cells["Наименование документа"].Value.ToString(),
                                                row.Cells["Дата выдачи"].Value.ToString(),
                                                row.Cells["Основание"].Value.ToString(),
                                                row.Cells["id льготы"].Value.ToString());
            }

            MessageBox.Show("Сотрудник успешно изменён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Запись_в_журнал(Фамилия_Box.Text, "Изменить сотрудника", "Сотрудники", Data.UserAuthorization);
            Close();
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
        }

        private void Далее2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
        }

        private void Далее3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
        }

        private void Далее4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage5"];
        }

        private void Далее5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage6"];
        }
        private void Далее6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage7"];
        }

        private void Далее7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage8"];
        }
        private void Назад2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
        }

        private void Назад3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
        }

        private void Назад4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
        }
        private void Назад5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage5"];
        }
        private void Назад6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage6"];
        }

        private void Назад7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage7"];
        }

        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Далее_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
        }

        private void Индекс_Box_Enter(object sender, EventArgs e)
        {
            Индекс_регистрации_Box.Text = "";
        }
        private void Индекс_Box_Leave(object sender, EventArgs e)
        {
            if (Индекс_регистрации_Box.Text == "")
            {
                Индекс_регистрации_Box.Text = "0";
            }
        }
        private void Серия_образование_Box_Enter(object sender, EventArgs e)
        {
            Серия_образование_Box.Text = "";
        }

        private void Серия_образование_Box_Leave(object sender, EventArgs e)
        {
            if (Серия_образование_Box.Text == "")
            {
                Серия_образование_Box.Text = "0";
            }
        }

        private void Номер_образование_Box_Enter(object sender, EventArgs e)
        {
            Номер_образование_Box.Text = "";
        }

        private void Номер_образование_Box_Leave(object sender, EventArgs e)
        {
            if (Номер_образование_Box.Text == "")
            {
                Номер_образование_Box.Text = "0";
            }
        }

        private void Документ_Num_Box_Enter(object sender, EventArgs e)
        {
            Документ_Num_Box.Text = "";
        }

        private void Документ_Num_Box_Leave(object sender, EventArgs e)
        {
            if (Документ_Num_Box.Text == "")
            {
                Документ_Num_Box.Text = "0";
            }
        }
        private void Серия_загран_Box_Enter(object sender, EventArgs e)
        {
            Серия_загран_Box.Text = "0";
        }

        private void Серия_загран_Box_Leave(object sender, EventArgs e)
        {
            if (Серия_загран_Box.Text == "")
            {
                Серия_загран_Box.Text = "0";
            }
        }

        private void Номер_загран_Box_Enter(object sender, EventArgs e)
        {
            Номер_загран_Box.Text = "0";
        }

        private void Номер_загран_Box_Leave(object sender, EventArgs e)
        {
            if (Номер_загран_Box.Text == "")
            {
                Номер_загран_Box.Text = "0";
            }
        }
    }
}

               