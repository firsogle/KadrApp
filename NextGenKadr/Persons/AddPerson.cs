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
            try
            {
                connection.Build(
                    $"INSERT INTO General (Фамилия, Имя, Отчество, Пол, [Табельный номер],[Структурное подразделение], Должность, Телефон, [Семейное положение],[Место рождения], Гражданство, Национальность,[Номер страхового полиса], ИНН,[Номер мед. полиса],[Пенсионное свидетельство], [День Рождения],[Дата приёма на работу]) VALUES (N'{Surname_Box.Text}',N'{Name_Box.Text}',N'{Patronymic_Box.Text}',N'{Gender_Box.Text}',N'{Number_ID.Text}',N'{Structural_subdivision_Box.Text}',N'{placeofwork_Box.Text}',N'{Phone_Box.Text}',N'{Phone_Box.Text}',N'{Family_Status_Box.Text}',N'{Citizenship_Box.Text}',N'{Nationality_Box.Text}',N'{Insurance_policy_number_Box.Text}',N'{TIN_Box.Text}',N'{Medical_policy_box.Text}',N'{Pension_Certificate_Box.Text}',N'{Birthday_TimePicker.Text}',N'{Employmentdate_Picker.Text}')");
                int id = Convert.ToInt32(connection.id($"SELECT MAX(ID) FROM General"));
                connection.Build(
                    $"INSERT INTO Passport ([Серия паспорта РФ],[Номер паспорта РФ],[Дата выдачи паспорта РФ],[Кем выдан паспорт РФ],[Город регистрации], [Индекс города регистрации],[Улица города регистрации],[Город проживания],[Индекс города проживания],[Улица города проживания],[Серия загран. паспорта],[Номер загран. паспорта],[Дата выдачи загран. паспорта],[Место выдачи загран. паспорта], [Срок действия], Id) VALUES (N'{RFSeries_Box.Text}',N'{RFNumber_Box.Text}',N'{RFTime_TimePicker.Text}',N'{RFWhere_Box.Text}',N'{RFRegCity_Box.Text}', N'{RFRegIndex_Box.Text}', N'{RFRegSt_Box.Text}', N'{RFLiveCity_Box.Text}', N'{RFLiveIndex_Box.Text}', N'{RFLiveSt_Box.Text}', N'{EXSeries_Box.Text}', N'{EXNumber_Box.Text}',N'{EXDate_TimePicker.Text}',N'{EXWhere_Box.Text}', N'{EXBefore_TimePicker.Text}', '{id}')");
                connection.Build(
                    $"INSERT INTO EducMil (EDNameDoc, EDSer, EDNumber, EDNameInst, EDQual, EDSpecial, EDPost_Name, EDPost_NumbDoc, EDPost_Give, EDPost_Academ, EDPost_Dir, Mil_ZV, Mil_Zapas, Mil_VUS, Mil_Sostav, Mil_Special, Mil_Category, Mil_Commis, ID) VALUES (N'{EDNameDoc_Box.Text}',N'{EDSer_Box.Text}',N'{EDNumber_Box.Text}',N'{EDNameInst_Box.Text}',N'{EDQual_Box.Text}',N'{EDSpecial_Box.Text}',N'{EDPost_Name_Box.Text}',N'{EDPost_NumbDoc_Box.Text}',N'{EDPost_Give_Box.Text}',N'{EDPost_Academ_Box.Text}',N'{EDPost_Dir_Box.Text}',N'{Mil_ZV_Box.Text}',N'{Mil_Zapas_Box.Text}',N'{Mil_VUS_Box.Text}',N'{Mil_Sostav_Box.Text}',N'{Mil_Special_Box.Text}',N'{Mil_Category_Box.Text}',N'{Mil_Commis_Box.Text}', '{id}')");
                connection.Build(
                    $"INSERT INTO LaborActiv (DateWork, Position, NumberContract, NumberContractDate, NumOr2, NumOr2Date, ContractTerm, Salary, WorkExperience, Allowance, NumOrder, PremiumSalary, KTU, Rate, ID) VALUES (N'{DateWork_Picker.Text}',N'{Position_Box.Text}',N'{NumberContract_Box.Text}',N'{NumberContractDate_Picker.Text}',N'{NumOr2_Box.Text}',N'{NumOr2Date_Picker.Text}',N'{ContractTerm_Picker.Text}',N'{Salary_Box.Text}',N'{WorkExperience_Box.Text}',N'{Allowance_Box.Text}',N'{NumOrder_Box.Text}',N'{PremiumSalary_Box.Text}',N'{KTU_Box.Text}',N'{Rate_Box.Text}','{id}')");
                connection.Build(
                    $"INSERT INTO Journal ([User], Time, Action, Famaly, Name, Surname) VALUES (N'{Data.UserAuthorization}',N'{Data.Today}',N'{"Добавление нового сотрудника"}',N'{Surname_Box.Text}',N'{Name_Box.Text}',N'{Patronymic_Box.Text}')");
            }

            catch (Exception sit1)
            {
                MessageBox.Show(sit1.Message);
                return;
            }

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

        private void NumOrder_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
