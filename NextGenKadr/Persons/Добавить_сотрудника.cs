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
            this.StartPosition = FormStartPosition.CenterScreen;
            string TabNumber="";
            try
            {
                TabNumber = connection.Получить_сведения_из_базы_данных($"SELECT MAX ([Табельный номер]) FROM Сотрудники");
                int Param = Convert.ToInt32(TabNumber) + 1;
                Табельный_номер_Box.Text = Param.ToString();

            }

            catch (Exception)
            {
                Табельный_номер_Box.Text = "1";
            }
            Индекс_регистрации_Box.Text = "0";
            Серия_образование_Box.Text = "0";
            Номер_образование_Box.Text = "0";
            Документ_Num_Box.Text = "0";
            Серия_загран_Box.Text = Номер_загран_Box.Text= "0";
            Num_Договора_Box.Text = "0";
            Номер_мед_полиса_Box.Text = "0";
            Индекс_проживания_Box.Text = "0";

            Язык_ОКИН_Имя_Combobox.SelectedItem = "1";
            Язык_ОКИН_Степень_Combobox.SelectedItem = "1";
            Гражданство_ОКИН_Box.SelectedItem = "1";
            Код_по_ОКИН_БракBox.SelectedItem = "1";
            Образование_по_ОКИН_Box.SelectedItem = "1";
            Код_ОКСО_1_Combobox.SelectedItem = "1";
            Код_ОКСО_3_Combobox.SelectedItem = "1";
            ОКПДТР_1_comboBox.SelectedItem = "1";
            ОКПДТР_2_comboBox.SelectedItem = "1";
            Место_рождения_ОКАТА_Box.Text = "0";

            int Number = 1;
            try
            {
                 Number = Convert.ToInt32(TabNumber) + 1; ;

            }
            catch (Exception)
            {
                Number = 1; ;
                TabNumber = "1"; ;
            }
            connection.Создать_семью(Convert.ToInt32(TabNumber)+1);
            Grid_Family.DataSource = connection.ReloadGrid("SELECT [Номер родственника], [Степень родства], [Фамилия], [Имя], [Отчество], [Дата рождения] FROM [Состав семьи] where [Табельный номер сотрудника]=" + Number).Tables[0].DefaultView;
            connection.Удалить_семью(Convert.ToInt32(TabNumber)+1);

            connection.Создать_сведения_работы(Convert.ToInt32(TabNumber) + 1);
            Grid_Work.DataSource = connection.ReloadGrid("SELECT [Дата приёма на работу], [Номер договора], [Подразделение], [Дожность], [Оклад], [Основание] FROM [Приём и переводы на работу] where [Табельный номер]=" + Number).Tables[0].DefaultView;
            connection.Удалить_сведения_работы(Convert.ToInt32(TabNumber) + 1);

            connection.Создать_аттестацию(Convert.ToInt32(TabNumber) + 1);
            Grid_аттестация.DataSource = connection.ReloadGrid("SELECT [Дата аттестации], [Решение комиссии], [Номер протокола], [Дата протокола], [Основание] FROM [Аттестация] where [Табельный номер]=" + Number).Tables[0].DefaultView;
            connection.Удалить_атестацию(Convert.ToInt32(TabNumber) + 1);

            connection.Создать_повышение_квалификации(Convert.ToInt32(TabNumber) + 1);
            Grid_квалификация.DataSource = connection.ReloadGrid("SELECT [Начало повышения квалификации], [Окончание повышения квалификации], [Вид повышения квалификации], [Наименование образовательного учреждения], [Наименование документа], [Серия документа], [Номер документа], [Дата], [Основание] FROM [Повышение квалификации] where [Табельный номер]=" + Number).Tables[0].DefaultView;
            connection.Удалить_повышение_квалификации(Convert.ToInt32(TabNumber) + 1);

            connection.Создать_проф_подготовку(Convert.ToInt32(TabNumber) + 1);
            Grid_переподготовка_сотрудника.DataSource = connection.ReloadGrid("SELECT [Дата начала переподготовки], [Дата окончания переподготовки], [Специальность], [Наименование документа], [Дата], [Основание] FROM [Профессиональная переподготовка] where [Табельный номер]=" + Number).Tables[0].DefaultView;
            connection.Удалить_проф_подготовку(Convert.ToInt32(TabNumber) + 1);

            connection.Создать_награды(Convert.ToInt32(TabNumber) + 1);
            Grid_награды.DataSource = connection.ReloadGrid("SELECT [Наименование награды], [Наименование документа], [Дата] FROM [Награды и почетные звания] where [Табельный номер]=" + Number).Tables[0].DefaultView;
            connection.Удалить_награды(Convert.ToInt32(TabNumber) + 1);

            Grid_отпуск.DataSource = connection.ReloadGrid("SELECT [Номер документа], [Дата приказа], [Начало отпуска А], [Окончание отпуска А], [Начало отпуска Б], [Окончание отпуска Б] FROM [Сведения об отпусках] where [Табельный номер]=" + Number).Tables[0].DefaultView;

            connection.Создать_Льготы(Convert.ToInt32(TabNumber) + 1);
            Grid_льготы.DataSource = connection.ReloadGrid("SELECT [Наименование льготы], [Наименование документа], [Дата выдачи], [Основание] FROM [Социальные льготы] where [Табельный номер]=" + Number).Tables[0].DefaultView;
            connection.Удалить_Льготы(Convert.ToInt32(TabNumber) + 1);

        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
            if   (Документ_Num_Box.Text == "")
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
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage8"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage7"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage6"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage5"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];

            connection.Создать_сотрудника(Табельный_номер_Box.Text, Имя_Box.Text, Фамилия_Box.Text, Отчество_Box.Text, Пол_Box.Text, Телефон_Box.Text);
            connection.Внести_общие_сведения(Табельный_номер_Box.Text, Дата_составления_Picker.Text, ИНН_Box.Text, Пенсионное_свидетельство_Box.Text, Алфавит_Box.Text, Характер_работы_Box.Text, Вид_работы_Box.Text, Дата_рождения_Picker.Text, Место_рождения_Box.Text, Место_рождения_ОКАТА_Box.Text, Гражданство_Box.Text, Гражданство_ОКИН_Box.Text, Знание_языка_название_Box.Text, Язык_ОКИН_Имя_Combobox.Text, Знание_языка_степень_Box.Text, Язык_ОКИН_Степень_Combobox.Text, Семейное_положение_Box.Text, Код_по_ОКИН_БракBox.Text, Национальность_Box.Text, Номер_мед_полиса_Box.Text, Образование_comboBox.Text, Образование_по_ОКИН_Box.Text, Num_Договора_Box.Text, Дата_договора_TimePicker.Text);
            connection.Внести_сведения_паспорта(Табельный_номер_Box.Text, Серия_Box.Text, Номер_Box.Text, Дата_выдачи_Picker.Text, Кем_выдан_Box.Text, Город_регистрации_Box.Text, Индекс_регистрации_Box.Text, Адрес_регистрации_Box.Text, Дата_регистрации_Picker.Text, Город_проживания_Box.Text, Индекс_проживания_Box.Text, Адрес_проживания_Box.Text);
            connection.Внести_сведения_заграниченого_паспорта(Табельный_номер_Box.Text, Серия_загран_Box.Text, Номер_загран_Box.Text, Дата_выдачи_Picker.Text, Кем_выдан_загран_Box.Text, Срок_выдачи_загран_Picker.Text);
            connection.Внести_сведения_об_образовании(Табельный_номер_Box.Text, Наименование_учебного_заведения_Box.Text, Наименование_документа_Box.Text, Серия_образование_Box.Text, Номер_образование_Box.Text, Год_окончания_Box.Text, Квалификация_Box.Text, Специальность_Box.Text, Код_ОКСО_1_Combobox.Text, Профессия_Box.Text, ОКПДТР_1_comboBox.Text, Профессия_2_Box.Text, ОКПДТР_2_comboBox.Text);
            connection.Внести_cведения_о_послевузовском_образовании(Табельный_номер_Box.Text, Послевузовское_образование_Box.Text, Наименование_учебного_заведения_После_Box.Text, Дата_выдачи_после_Box.Text, Год_окончания_после_Box.Text, Наименование_документа_после_Box.Text, Документ_Num_Box.Text, Направление_Box.Text, Код_ОКСО_3_Combobox.Text);
            connection.Внести_сведения_о_воиснком_учёте(Табельный_номер_Box.Text, Категория_запаса_Box.Text, Воинское_звание_Box.Text, Состав_Box.Text, Номер_ВУС_Box.Text, ВУС_Box.Text, Категория_годности_Box.Text, Комиссариат_Box.Text, Общий_учет_Box.Text, Спец_учет_Box.Text, Отметка_Box.Text);


            foreach (DataGridViewRow row in Grid_Family.Rows)
            {
                connection.Внести_сведения_о_семье(row.Cells["Номер родственника"].Value.ToString(),
                                                row.Cells["Степень родства"].Value.ToString(),
                                                Табельный_номер_Box.Text,
                                                row.Cells["Фамилия"].Value.ToString(),
                                                row.Cells["Имя"].Value.ToString(),
                                                row.Cells["Отчество"].Value.ToString(),
                                                row.Cells["Дата рождения"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_Work.Rows)
            {
                connection.Внести_сведения_приёмов_и_переводов(Табельный_номер_Box.Text,
                                                row.Cells["Дата приёма на работу"].Value.ToString(),
                                                row.Cells["Номер договора"].Value.ToString(),
                                                row.Cells["Подразделение"].Value.ToString(),
                                                row.Cells["Дожность"].Value.ToString(),
                                                row.Cells["Оклад"].Value.ToString(),
                                                row.Cells["Основание"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_аттестация.Rows)
            {
                connection.Внести_сведения_аттестации(Табельный_номер_Box.Text,
                                                row.Cells["Дата аттестации"].Value.ToString(),
                                                row.Cells["Решение комиссии"].Value.ToString(),
                                                row.Cells["Номер протокола"].Value.ToString(),
                                                row.Cells["Дата протокола"].Value.ToString(),
                                                row.Cells["Основание"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_квалификация.Rows)
            {
                connection.Внести_Повышение_квалификации(Табельный_номер_Box.Text,
                                                row.Cells["Начало повышения квалификации"].Value.ToString(),
                                                row.Cells["Окончание повышения квалификации"].Value.ToString(),
                                                row.Cells["Вид повышения квалификации"].Value.ToString(),
                                                row.Cells["Наименование образовательного учреждения"].Value.ToString(),
                                                row.Cells["Наименование документа"].Value.ToString(),
                                                row.Cells["Серия документа"].Value.ToString(),
                                                row.Cells["Номер документа"].Value.ToString(),
                                                row.Cells["Дата"].Value.ToString(),
                                                row.Cells["Основание"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_переподготовка_сотрудника.Rows)
            {
                connection.Внести_проф_подготовку(Табельный_номер_Box.Text,
                                                row.Cells["Дата начала переподготовки"].Value.ToString(),
                                                row.Cells["Дата окончания переподготовки"].Value.ToString(),
                                                row.Cells["Специальность"].Value.ToString(),
                                                row.Cells["Наименование документа"].Value.ToString(),
                                                row.Cells["Дата"].Value.ToString(),
                                                row.Cells["Основание"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_награды.Rows)
            {
                connection.Внести_награды(Табельный_номер_Box.Text,
                                                row.Cells["Наименование награды"].Value.ToString(),
                                                row.Cells["Наименование документа"].Value.ToString(),
                                                row.Cells["Дата"].Value.ToString());
            }

            foreach (DataGridViewRow row in Grid_льготы.Rows)
            {
                connection.Внести_льготы(Табельный_номер_Box.Text,
                                                row.Cells["Наименование льготы"].Value.ToString(),
                                                row.Cells["Наименование документа"].Value.ToString(),
                                                row.Cells["Дата выдачи"].Value.ToString(),
                                                row.Cells["Основание"].Value.ToString());
            }

            MessageBox.Show("Сотрудник успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Запись_в_журнал(Фамилия_Box.Text, "Добавить сотруника", "Сотрудники", Data.UserAuthorization);
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

        private void Гражданство_comboBox_Click(object sender, EventArgs e)
        {
            Гражданство_comboBox.Text = "";
        }

        private void Табельный_номер_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Okato_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://classifikators.ru/okato");
        }

        private void ОКПДТР_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://okpdtr.ru/");
        }

        private void ОКСО_Button(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://classifikators.ru/okso");
        }

    }
}
