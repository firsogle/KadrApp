using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;

namespace NextGenKadr
{
    public partial class ViewPerson : Form
    {


        public ViewPerson(string id)
        {
           InitializeComponent();
           this.StartPosition = FormStartPosition.CenterScreen;
           Имя_Box.Text =  connection.Получить_сведения_из_базы_данных($"SELECT Имя FROM Сотрудники WHERE [Табельный номер] = {id}");
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

            Grid_Family.DataSource = connection.ReloadGrid($"SELECT [Номер родственника], [Степень родства], [Фамилия], [Имя], [Отчество], [Дата рождения] FROM [Состав семьи] where [Табельный номер сотрудника]= {id}").Tables[0].DefaultView;
            Grid_Work.DataSource = connection.ReloadGrid($"SELECT [Дата приёма на работу], [Номер договора], [Подразделение], [Дожность], [Оклад], [Основание] FROM [Приём и переводы на работу] where [Табельный номер]= {id}").Tables[0].DefaultView;
            Grid_аттестация.DataSource = connection.ReloadGrid($"SELECT [Дата аттестации], [Решение комиссии], [Номер протокола], [Дата протокола], [Основание] FROM [Аттестация] where [Табельный номер]= {id}").Tables[0].DefaultView;
            Grid_квалификация.DataSource = connection.ReloadGrid($"SELECT [Начало повышения квалификации], [Окончание повышения квалификации], [Вид повышения квалификации], [Наименование образовательного учреждения], [Наименование документа], [Серия документа], [Номер документа], [Дата], [Основание] FROM [Повышение квалификации] where [Табельный номер]= {id}").Tables[0].DefaultView;
            Grid_переподготовка_сотрудника.DataSource = connection.ReloadGrid($"SELECT [Дата начала переподготовки], [Дата окончания переподготовки], [Специальность], [Наименование документа], [Дата], [Основание] FROM [Профессиональная переподготовка] where [Табельный номер]= {id}").Tables[0].DefaultView;
            Grid_награды.DataSource = connection.ReloadGrid($"SELECT [Наименование награды], [Наименование документа], [Дата] FROM [Награды и почетные звания] where [Табельный номер]={id}").Tables[0].DefaultView;
            Grid_отпуск.DataSource = connection.ReloadGrid($"SELECT [Номер документа], [Дата приказа], [Начало отпуска А], [Окончание отпуска А], [Начало отпуска Б], [Окончание отпуска Б] FROM [Сведения об отпусках] where [Табельный номер]= {id}").Tables[0].DefaultView;
            Grid_льготы.DataSource = connection.ReloadGrid($"SELECT[Наименование льготы], [Наименование документа], [Дата выдачи], [Основание] FROM[Социальные льготы] where[Табельный номер] = { id}").Tables[0].DefaultView;

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
        private void Cоздать_Click(object sender, EventArgs e)
        {

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

        private void Т2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage8"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage7"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage6"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage5"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];

            var wordApp = new Word.Application();
            var WordDoc = wordApp.Documents.Open(Path.Combine(System.Windows.Forms.Application.StartupPath, "Т-2.docx"));

            string YearДеньРождения = DateTime.Parse(Дата_рождения_Picker.Text).ToString("yyyy");
            string стаж1 = DateTime.Parse(Стаж_на_момент_Picker.Text).ToString("dd");
            string стаж2 = DateTime.Parse(Стаж_на_момент_Picker.Text).ToString("MM");
            string стаж3 = DateTime.Parse(Стаж_на_момент_Picker.Text).ToString("yy");

            ReplaceWordStub("[Дата]", Дата_составления_Picker.Text, WordDoc);
            ReplaceWordStub("[Табельный номер]", Табельный_номер_Box.Text, WordDoc);
            ReplaceWordStub("[ИНН]", ИНН_Box.Text, WordDoc);
            ReplaceWordStub("[Пенсионное свидетельство]", Пенсионное_свидетельство_Box.Text, WordDoc);
            ReplaceWordStub("[Алфавит]", Алфавит_Box.Text, WordDoc);
            ReplaceWordStub("[Характер работы]", Характер_работы_Box.Text, WordDoc);
            ReplaceWordStub("[Вид работы]", Вид_работы_Box.Text, WordDoc);
            ReplaceWordStub("[Пол]", Пол_Box.Text, WordDoc);
            ReplaceWordStub("[Num_Договора]", Num_Договора_Box.Text, WordDoc);
            ReplaceWordStub("[Дата_договора]", Дата_договора_TimePicker.Text, WordDoc);
            ReplaceWordStub("[Фамилия]", Фамилия_Box.Text, WordDoc);
            ReplaceWordStub("[Имя]", Имя_Box.Text, WordDoc);
            ReplaceWordStub("[Отчество]", Отчество_Box.Text, WordDoc);
            ReplaceWordStub("[Телефон]", Телефон_Box.Text, WordDoc);
            ReplaceWordStub("[Дата рождения]", Дата_рождения_Picker.Text, WordDoc);
            ReplaceWordStub("[ДАТА]", YearДеньРождения, WordDoc);
            ReplaceWordStub("[Место рождения]", Место_рождения_Box.Text, WordDoc);
            ReplaceWordStub("[ОКАТО]", Место_рождения_ОКАТА_Box.Text, WordDoc);
            ReplaceWordStub("[Гражданство]", Гражданство_Box.Text, WordDoc);
            ReplaceWordStub("[ОКИН_граднство]", Гражданство_ОКИН_Box.Text, WordDoc);
            ReplaceWordStub("[Знание_языка_название]", Знание_языка_название_Box.Text, WordDoc);
            ReplaceWordStub("[ОКИН_язык]", Язык_ОКИН_Имя_Combobox.Text, WordDoc);
            ReplaceWordStub("[Знание_языка_степень]", Знание_языка_степень_Box.Text, WordDoc);
            ReplaceWordStub("[ОКИН_степень]", Язык_ОКИН_Степень_Combobox.Text, WordDoc);
            ReplaceWordStub("[Образование]", Образование_comboBox.Text, WordDoc);
            ReplaceWordStub("[ОКИН_образование]", Образование_по_ОКИН_Box.Text, WordDoc);
            ReplaceWordStub("[Наименование учебного заведения]", Наименование_учебного_заведения_Box.Text, WordDoc);
            ReplaceWordStub("[Наименование_ДООБ]", Наименование_документа_Box.Text, WordDoc);
            ReplaceWordStub("[Серия_ДООБ]", Серия_образование_Box.Text, WordDoc);
            ReplaceWordStub("[Номер_ДООБ]", Номер_образование_Box.Text, WordDoc);
            ReplaceWordStub("[Год окончания_ДООБ]", Год_окончания_Box.Text, WordDoc);
            ReplaceWordStub("[Квалификация]", Квалификация_Box.Text, WordDoc);
            ReplaceWordStub("[Направление или специальность]]", Специальность_Box.Text, WordDoc);
            ReplaceWordStub("[ОКСО_Специальность]", Код_ОКСО_1_Combobox.Text, WordDoc);
            ReplaceWordStub("[Наименование_учебного_заведения_После]", Наименование_учебного_заведения_После_Box.Text, WordDoc);
            ReplaceWordStub("[Наименование_документа_после]", Наименование_документа_после_Box.Text, WordDoc);
            ReplaceWordStub("[Год_окончания_после]", Год_окончания_после_Box.Text, WordDoc);
            ReplaceWordStub("[Документ_Num]", Документ_Num_Box.Text, WordDoc);
            ReplaceWordStub("[Дата_выдачи_после]", Дата_выдачи_после_Box.Text, WordDoc);
            ReplaceWordStub("[Направление или специальность2]", Направление_Box.Text, WordDoc);
            ReplaceWordStub("[ОКСО_Специальность2]", Код_ОКСО_3_Combobox.Text, WordDoc);
            ReplaceWordStub("[Профессия]", Профессия_Box.Text, WordDoc);
            ReplaceWordStub("[ОКПДТР_Основная]", ОКПДТР_1_comboBox.Text, WordDoc);
            ReplaceWordStub("[Профессия2]", Профессия_2_Box.Text, WordDoc);
            ReplaceWordStub("[ОКПДТР_другая]", ОКПДТР_2_comboBox.Text, WordDoc);
            ReplaceWordStub("[Стаж_дд]", стаж1, WordDoc);
            ReplaceWordStub("[Стаж_мм]", стаж2, WordDoc);
            ReplaceWordStub("[Стаж_гг]", стаж3, WordDoc);
            ReplaceWordStub("[Общий_Дней]", Общий_Дней_Box.Text, WordDoc);
            ReplaceWordStub("[Общий_Месяцев]", Общий_Месяцев_Box.Text, WordDoc);
            ReplaceWordStub("[Общий_Лет]", Общий_Лет_Box.Text, WordDoc);
            ReplaceWordStub("[Непрерывный_дней]", Непрерывный_дней_Box.Text, WordDoc);
            ReplaceWordStub("[Непрерывный_месяцев]", Непрерывный_месяцев_Box.Text, WordDoc);
            ReplaceWordStub("[Непрерывный_лет]", Непрерывный_лет_Box.Text, WordDoc);
            ReplaceWordStub("[Выслуга_лет_Дней]", Выслуга_лет_Дней_Box.Text, WordDoc);
            ReplaceWordStub("[Выслуга_лет_Месяцев]", Выслуга_лет_Месяцев_Box.Text, WordDoc);
            ReplaceWordStub("[Выслуга_лет_Лет]", Выслуга_лет_Лет_Box.Text, WordDoc);
            ReplaceWordStub("[Состояние в браке]", Семейное_положение_Box.Text, WordDoc);
            ReplaceWordStub("[ОКИН Брак]", Код_по_ОКИН_БракBox.Text, WordDoc);
            ReplaceWordStub("[Стаж_гг]", стаж3, WordDoc);
            ReplaceWordStub("[Стаж_гг]", стаж3, WordDoc);
            ReplaceWordStub("[Стаж_гг]", стаж3, WordDoc);
            int i = 1;
            foreach (DataGridViewRow row in Grid_Family.Rows)
            {
               
                Bookmark($"СоставСемьи_Год_рождения{i}", row.Cells["Дата рождения"].Value.ToString(), WordDoc);
                Bookmark($"СоставСемьи_Имя{i}", row.Cells["Имя"].Value.ToString(), WordDoc);
                Bookmark($"СоставСемьи_Отчество{i}", row.Cells["Отчество"].Value.ToString(), WordDoc);
                Bookmark($"СоставСемьи_СтепеньРодства{i}", row.Cells["Степень родства"].Value.ToString(), WordDoc);
                Bookmark($"СоставСемьи_Фамилия{i}", row.Cells["Фамилия"].Value.ToString(), WordDoc);
                 i =i+ 1;

            }
            string паспорт1 = DateTime.Parse(Дата_выдачи_Picker.Text).ToString("dd");
            string паспорт2 = DateTime.Parse(Дата_выдачи_Picker.Text).ToString("MM");
            string паспорт3 = DateTime.Parse(Дата_выдачи_Picker.Text).ToString("yy");

            string регистрация1 = DateTime.Parse(Дата_регистрации_Picker.Text).ToString("dd");
            string регистрация2 = DateTime.Parse(Дата_регистрации_Picker.Text).ToString("MM");
            string регистрация3 = DateTime.Parse(Дата_регистрации_Picker.Text).ToString("yy");

            ReplaceWordStub("[Серия] ", Серия_Box.Text, WordDoc);
            ReplaceWordStub("[Номер]", Номер_Box.Text, WordDoc);
            ReplaceWordStub("[Дата выдачидд]", паспорт1, WordDoc);
            ReplaceWordStub("[Дата выдачимм]", паспорт2, WordDoc);
            ReplaceWordStub("[Дата выдачигг]", паспорт3, WordDoc);
            ReplaceWordStub("[Кем выдан]", Кем_выдан_Box.Text, WordDoc);
            ReplaceWordStub("[Индекс_регистрации]", Индекс_регистрации_Box.Text, WordDoc);
            ReplaceWordStub("[Город_регистрации] ", Город_регистрации_Box.Text, WordDoc);
            ReplaceWordStub("[Адрес_регистрации]", Адрес_регистрации_Box.Text, WordDoc);
            ReplaceWordStub("[Индекс_проживания]", Индекс_проживания_Box.Text, WordDoc);
            ReplaceWordStub("[Город_проживания]", Город_проживания_Box.Text, WordDoc);
            ReplaceWordStub("[Адрес_проживания] ", Адрес_регистрации_Box.Text, WordDoc);
            ReplaceWordStub("[Дата_регистрациидд]", регистрация1, WordDoc);
            ReplaceWordStub("[Дата_регистрациимм]", регистрация2, WordDoc);
            ReplaceWordStub("[Дата_регистрациигг]", регистрация3, WordDoc);
            ReplaceWordStub("[Категория запаса] ", Категория_запаса_Box.Text, WordDoc);
            ReplaceWordStub("[Воинское звание]", Воинское_звание_Box.Text, WordDoc);
            ReplaceWordStub("[Состав]", Состав_Box.Text, WordDoc);
            ReplaceWordStub("[Номер_ВУС]", Номер_ВУС_Box.Text, WordDoc);
            ReplaceWordStub("[ВУС]", ВУС_Box.Text, WordDoc);
            ReplaceWordStub("[Категория_годности]", Категория_годности_Box.Text, WordDoc);
            ReplaceWordStub("[Комиссариат]", Комиссариат_Box.Text, WordDoc);
            ReplaceWordStub("[Общий_учет]", Общий_учет_Box.Text, WordDoc);
            ReplaceWordStub("[Спец_учет]", Спец_учет_Box.Text, WordDoc);
            ReplaceWordStub("[Отметка]", Отметка_Box.Text, WordDoc);

            int a = 1;
            foreach (DataGridViewRow row in Grid_Work.Rows)
            {

                Bookmark($"ДатаРабота{a}", row.Cells["Дата приёма на работу"].Value.ToString(), WordDoc);
                Bookmark($"Подразделение{a}", row.Cells["Подразделение"].Value.ToString(), WordDoc);
                Bookmark($"Должность{a}", row.Cells["Дожность"].Value.ToString(), WordDoc);
                Bookmark($"Оклад{a}", row.Cells["Оклад"].Value.ToString(), WordDoc);
                Bookmark($"ОснованиеПриёма{a}", row.Cells["Основание"].Value.ToString(), WordDoc);
                a = a + 1;

            }

            int r = 1;
            foreach (DataGridViewRow row in Grid_аттестация.Rows)
            {

                Bookmark($"ДатаАттестации{r}", row.Cells["Дата аттестации"].Value.ToString(), WordDoc);
                Bookmark($"Решение{r}", row.Cells["Решение комиссии"].Value.ToString(), WordDoc);
                Bookmark($"АттестацияНомер{r}", row.Cells["Номер протокола"].Value.ToString(), WordDoc);
                Bookmark($"АттестацияДата{r}", row.Cells["Дата протокола"].Value.ToString(), WordDoc);
                Bookmark($"АттестацияОснование{r}", row.Cells["Основание"].Value.ToString(), WordDoc);
                r = r + 1;

            }

            int ff = 1;
            foreach (DataGridViewRow row in Grid_квалификация.Rows)
            {

                Bookmark($"КвалификацияНачало{ff}", row.Cells["Начало повышения квалификации"].Value.ToString(), WordDoc);
                Bookmark($"КвалификацияКонец{ff}", row.Cells["Окончание повышения квалификации"].Value.ToString(), WordDoc);
                Bookmark($"КвалификацияВид{ff}", row.Cells["Вид повышения квалификации"].Value.ToString(), WordDoc);
                Bookmark($"КвалификацияУчреждение{ff}", row.Cells["Наименование образовательного учреждения"].Value.ToString(), WordDoc);
                Bookmark($"КвалификацияИмяСвидетельство{ff}", row.Cells["Наименование документа"].Value.ToString(), WordDoc);
                Bookmark($"КвалификацияНомер{ff}", row.Cells["Номер документа"].Value.ToString(), WordDoc);
                Bookmark($"КвалификацияИмяСерия{ff}", row.Cells["Серия документа"].Value.ToString(), WordDoc);
                Bookmark($"КвалификацияДата{ff}", row.Cells["Дата"].Value.ToString(), WordDoc);
                Bookmark($"КвалификацияОснование{ff}", row.Cells["Основание"].Value.ToString(), WordDoc);
                ff = ff + 1;

            }

            int ggg = 1;
            foreach (DataGridViewRow row in Grid_переподготовка_сотрудника.Rows)
            {

                Bookmark($"ПереподготовкаНачало{ggg}", row.Cells["Дата начала переподготовки"].Value.ToString(), WordDoc);
                Bookmark($"ПереподготовкаОкончание{ggg}", row.Cells["Дата окончания переподготовки"].Value.ToString(), WordDoc);
                Bookmark($"Переподготовка_Специальность{ggg}", row.Cells["Специальность"].Value.ToString(), WordDoc);
                Bookmark($"Переподготовка_наименование{ggg}", row.Cells["Наименование документа"].Value.ToString(), WordDoc);
                Bookmark($"Переподготовка_дата{ggg}", row.Cells["Дата"].Value.ToString(), WordDoc);
                Bookmark($"Переподготовка_основание{ggg}", row.Cells["Основание"].Value.ToString(), WordDoc);

                ggg = ggg + 1;

            }
            var name = DateTime.Now.ToShortDateString() + ".docx";
            try
            {
                wordApp.ActiveDocument.SaveAs(FileName: name);
                wordApp.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Закройте прошлый отчет");
                throw;
            }

        }
        private static void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }

        private static void Bookmark(string stubToReplace, string text, Word.Document wordDocument)
        {
            string bookmark = "BookmarkName";
            try
            {
                Bookmark bm = wordDocument.Bookmarks[stubToReplace];
                Range range = bm.Range;
                range.Text = $"{text} ";
                wordDocument.Bookmarks.Add(bookmark, range);
            }
            catch (Exception)
            {

            }

        }

    }
}