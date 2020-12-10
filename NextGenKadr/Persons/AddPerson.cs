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
            try
            {
                string TabNumber = connection.ReadDB($"SELECT MAX ([Табельный номер]) FROM Сотрудники");
                int Param = Convert.ToInt32(TabNumber) + 1;
                Табельный_номер_Box.Text = Param.ToString();

            }
            catch (Exception)
            {
                Табельный_номер_Box.Text = "1";
            }
         
           
            Индекс_Box.Text = "0";
            Серия_образование_Box.Text = "0";
            Номер_образование_Box.Text = "0";
            Документ_Num_Box.Text = "0";
            Надбавка_Box.Text = "0";
            Оклад_Box.Text = Ставка_Box.Text = Стаж_работы_Box.Text = "0";
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


            connection.Сведения_о_сотрудниках(Табельный_номер_Box.Text, Имя_Box.Text, Фамилия_Box.Text, Отчество_Box.Text, Пол_Box.Text);
            connection.Внести_общие_сведения(Табельный_номер_Box.Text, Телефон_Box.Text, Дата_рождения_Picker.Text, Подразделение_Box.Text,Семейное_положение_Box.Text, Гражданство_Box.Text, Национальность_Box.Text, Номер_страхового_полиса_Box.Text, ИНН_Box.Text, Номер_мед_полиса_Box.Text, Пенсионное_свидетельство_Box.Text);
            connection.Внести_сведения_паспорта(Табельный_номер_Box.Text, Серия_Box.Text, Номер_Box.Text, Дата_выдачи_Picker.Text, Кем_выдан_Box.Text, Город_Box.Text,Индекс_Box.Text, Улица_Box.Text);
            connection.Внести_сведения_заграниченого_паспорта(Табельный_номер_Box.Text, Серия_загран_Box.Text, Номер_загран_Box.Text, Дата_выдачи_Picker.Text, Кем_выдан_загран_Box.Text, Срок_выдачи_загран_Picker.Text);
            connection.Внести_сведения_об_образовании(Табельный_номер_Box.Text, Наименование_документа_Box.Text, Номер_образование_Box.Text,  Серия_образование_Box.Text, Наименование_учебного_заведения_Box.Text, Квалификация_Box.Text, Специальность_Box.Text);
            connection.Внести_cведения_о_послевузовском_образовании(Табельный_номер_Box.Text, Название_документа_Box.Text, Документ_Num_Box.Text, Наименование_учебного_заведения_После_Box.Text, Направление_Box.Text, Ученая_степень_Box.Text);
            connection.Внести_сведения_о_воиснком_учёте(Табельный_номер_Box.Text, Воинское_звание_Box.Text, Номер_ВУС_Box.Text, Военно_учетная_специальность_Box.Text, Коммисариат_Box.Text, Категория_запаса_Box.Text, Состав_Box.Text, Категория_годности_Box.Text);
            connection.Внести_трудовую_деятельность(Табельный_номер_Box.Text, Дата_приёма_на_работу_TimePicker.Text, Num_Договора_Box.Text, Дата_договора_TimePicker.Text, Num_Приказа_Box.Text, Дата_приказа_Box.Text, Срок_договора_Box.Text);
            connection.Внести_cведения_о_заработной_плате(Табельный_номер_Box.Text, Должность_Box.Text, Надбавка_Box.Text, Категория_Box.Text, Оклад_Box.Text, Ставка_Box.Text, Стаж_работы_Box.Text);
        
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

        private void Индекс_Box_Enter(object sender, EventArgs e)
        {
            Индекс_Box.Text = "";
        }

        private void Индекс_Box_Leave(object sender, EventArgs e)
        {
            if (Индекс_Box.Text == "")
            {
                Индекс_Box.Text = "0";
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

        private void Надбавка_Box_Enter(object sender, EventArgs e)
        {
            Надбавка_Box.Text = "";
        }

        private void Надбавка_Box_Leave(object sender, EventArgs e)
        {
            if (Надбавка_Box.Text == "")
            {
                Надбавка_Box.Text = "0";
            }
        }

        private void Оклад_Box_Enter(object sender, EventArgs e)
        {
            Оклад_Box.Text = "";
        }

        private void Оклад_Box_Leave(object sender, EventArgs e)
        {
            if (Оклад_Box.Text == "")
            {
                Оклад_Box.Text = "0";
            }
        }

        private void Ставка_Box_Enter(object sender, EventArgs e)
        {
            Ставка_Box.Text = "";
        }

        private void Ставка_Box_Leave(object sender, EventArgs e)
        {
            if (Ставка_Box.Text == "")
            {
                Ставка_Box.Text = "0";
            }
        }

        private void Стаж_работы_Box_Enter(object sender, EventArgs e)
        {
            Стаж_работы_Box.Text = "0";
        }

        private void Стаж_работы_Box_Leave(object sender, EventArgs e)
        {
            if (Стаж_работы_Box.Text == "")
            {
                Стаж_работы_Box.Text = "0";
            }
        }
    }
}
