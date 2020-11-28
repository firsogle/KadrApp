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

        public UpdatePerson(string id = "")
        {
            InitializeComponent();
            key = id;
            try
            {
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
                if (!string.IsNullOrEmpty(Gender_Box.Text = connection.ReadDB($"SELECT Пол FROM General WHERE ID = {key}")))
                {
                    Gender_Box.Text = connection.ReadDB($"SELECT Пол FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Number_ID.Text = connection.ReadDB($"SELECT [Табельный номер] FROM General WHERE ID = {key}")))
                {
                    Number_ID.Text = connection.ReadDB($"SELECT [Табельный номер] FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Structural_subdivision_Box.Text = connection.ReadDB($"SELECT [Структурное подразделение] FROM General WHERE ID = {key}")))
                {
                    Structural_subdivision_Box.Text = connection.ReadDB($"SELECT [Структурное подразделение] FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(placeofwork_Box.Text = connection.ReadDB($"SELECT Должность FROM General WHERE ID = {key}")))
                {
                    placeofwork_Box.Text = connection.ReadDB($"SELECT Должность FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Phone_Box.Text = connection.ReadDB($"SELECT Телефон FROM General WHERE ID = {key}")))
                {
                    Phone_Box.Text = connection.ReadDB($"SELECT Телефон FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Family_Status_Box.Text = connection.ReadDB($"SELECT [Семейное положение] FROM General WHERE ID = {key}")))
                {
                    Family_Status_Box.Text = connection.ReadDB($"SELECT [Семейное положение] FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Place_Of_Birth_Box.Text = connection.ReadDB($"SELECT [Место рождения] FROM General WHERE ID = {key}")))
                {
                    Place_Of_Birth_Box.Text = connection.ReadDB($"SELECT [Место рождения] FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Citizenship_Box.Text = connection.ReadDB($"SELECT Гражданство FROM General WHERE ID = {key}")))
                {
                    Citizenship_Box.Text = connection.ReadDB($"SELECT Гражданство FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Nationality_Box.Text = connection.ReadDB($"SELECT Национальность FROM General WHERE ID = {key}")))
                {
                    Nationality_Box.Text = connection.ReadDB($"SELECT Национальность FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Insurance_policy_number_Box.Text = connection.ReadDB($"SELECT [Номер страхового полиса] FROM General WHERE ID = {key}")))
                {
                    Insurance_policy_number_Box.Text = connection.ReadDB($"SELECT [Номер страхового полиса] FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(TIN_Box.Text = connection.ReadDB($"SELECT ИНН FROM General WHERE ID = {key}")))
                {
                    TIN_Box.Text = connection.ReadDB($"SELECT ИНН FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Medical_policy_box.Text = connection.ReadDB($"SELECT [Номер мед. полиса] FROM General WHERE ID = {key}")))
                {
                    Medical_policy_box.Text = connection.ReadDB($"SELECT [Номер мед. полиса] FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Pension_Certificate_Box.Text = connection.ReadDB($"SELECT [Пенсионное свидетельство] FROM General WHERE ID = {key}")))
                {
                    Pension_Certificate_Box.Text = connection.ReadDB($"SELECT [Пенсионное свидетельство] FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Birthday_TimePicker.Text = connection.ReadDB($"SELECT [День Рождения] FROM General WHERE ID = {key}")))
                {
                    Birthday_TimePicker.Text = connection.ReadDB($"SELECT [День Рождения] FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Employmentdate_Picker.Text = connection.ReadDB($"SELECT [Дата приёма на работу] FROM General WHERE ID = {key}")))
                {
                    Employmentdate_Picker.Text = connection.ReadDB($"SELECT [Дата приёма на работу] FROM General WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(RFSeries_Box.Text = connection.ReadDB($"SELECT [Серия паспорта РФ] FROM Passport WHERE ID = {key}")))
                {
                    RFSeries_Box.Text = connection.ReadDB($"SELECT [Серия паспорта РФ] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(RFNumber_Box.Text = connection.ReadDB($"SELECT [Номер паспорта РФ] FROM Passport WHERE ID = {key}")))
                {
                    RFNumber_Box.Text = connection.ReadDB($"SELECT [Номер паспорта РФ] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(RFTime_TimePicker.Text = connection.ReadDB($"SELECT [Дата выдачи паспорта РФ] FROM Passport WHERE ID = {key}")))
                {
                    RFTime_TimePicker.Text = connection.ReadDB($"SELECT [Дата выдачи паспорта РФ] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(RFWhere_Box.Text = connection.ReadDB($"SELECT [Кем выдан паспорт РФ] FROM Passport WHERE ID = {key}")))
                {
                    RFWhere_Box.Text = connection.ReadDB($"SELECT [Кем выдан паспорт РФ] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(RFRegCity_Box.Text = connection.ReadDB($"SELECT [Город регистрации] FROM Passport WHERE ID = {key}")))
                {
                    RFRegCity_Box.Text = connection.ReadDB($"SELECT [Город регистрации] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(RFRegIndex_Box.Text = connection.ReadDB($"SELECT [Индекс города регистрации] FROM Passport WHERE ID = {key}")))
                {
                    RFRegIndex_Box.Text = connection.ReadDB($"SELECT [Индекс города регистрации] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(RFRegSt_Box.Text = connection.ReadDB($"SELECT [Улица города регистрации] FROM Passport WHERE ID = {key}")))
                {
                    RFRegSt_Box.Text = connection.ReadDB($"SELECT [Улица города регистрации] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(RFLiveCity_Box.Text = connection.ReadDB($"SELECT [Город проживания] FROM Passport WHERE ID = {key}")))
                {
                    RFLiveCity_Box.Text = connection.ReadDB($"SELECT [Город проживания] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(RFLiveIndex_Box.Text = connection.ReadDB($"SELECT [Индекс города проживания] FROM Passport WHERE ID = {key}")))
                {
                    RFLiveIndex_Box.Text = connection.ReadDB($"SELECT [Индекс города проживания] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(RFLiveSt_Box.Text = connection.ReadDB($"SELECT [Улица города проживания] FROM Passport WHERE ID = {key}")))
                {
                    RFLiveSt_Box.Text = connection.ReadDB($"SELECT [Улица города проживания] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EXSeries_Box.Text = connection.ReadDB($"SELECT [Серия загран. паспорта] FROM Passport WHERE ID = {key}")))
                {
                    EXSeries_Box.Text = connection.ReadDB($"SELECT [Серия загран. паспорта] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EXNumber_Box.Text = connection.ReadDB($"SELECT [Номер загран. паспорта] FROM Passport WHERE ID = {key}")))
                {
                    EXNumber_Box.Text = connection.ReadDB($"SELECT [Номер загран. паспорта] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EXDate_TimePicker.Text = connection.ReadDB($"SELECT [Дата выдачи загран. паспорта] FROM Passport WHERE ID = {key}")))
                {
                    EXDate_TimePicker.Text = connection.ReadDB($"SELECT [Дата выдачи загран. паспорта] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EXWhere_Box.Text = connection.ReadDB($"SELECT [Место выдачи загран. паспорта] FROM Passport WHERE ID = {key}")))
                {
                    EXWhere_Box.Text = connection.ReadDB($"SELECT [Место выдачи загран. паспорта] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EXBefore_TimePicker.Text = connection.ReadDB($"SELECT [Срок действия] FROM Passport WHERE ID = {key}")))
                {
                    EXBefore_TimePicker.Text = connection.ReadDB($"SELECT [Срок действия] FROM Passport WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDNameDoc_Box.Text = connection.ReadDB($"SELECT [EDNameDoc] FROM EducMil WHERE ID = {key}")))
                {
                    EDNameDoc_Box.Text = connection.ReadDB($"SELECT EDNameDoc FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDSer_Box.Text = connection.ReadDB($"SELECT EDSer FROM EducMil WHERE ID = {key}")))
                {
                    EDSer_Box.Text = connection.ReadDB($"SELECT EDSer FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDNumber_Box.Text = connection.ReadDB($"SELECT EDNumber FROM EducMil WHERE ID = {key}")))
                {
                    EDNumber_Box.Text = connection.ReadDB($"SELECT EDNumber FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDNameInst_Box.Text = connection.ReadDB($"SELECT EDNameInst FROM EducMil WHERE ID = {key}")))
                {
                    EDNameInst_Box.Text = connection.ReadDB($"SELECT EDNameInst FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDQual_Box.Text = connection.ReadDB($"SELECT EDQual FROM EducMil WHERE ID = {key}")))

                {
                    EDQual_Box.Text = connection.ReadDB($"SELECT EDQual FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDSpecial_Box.Text = connection.ReadDB($"SELECT EDSpecial FROM EducMil WHERE ID = {key}")))

                {
                    EDSpecial_Box.Text = connection.ReadDB($"SELECT EDSpecial FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDPost_Name_Box.Text = connection.ReadDB($"SELECT EDPost_Name FROM EducMil WHERE ID = {key}")))

                {
                    EDPost_Name_Box.Text = connection.ReadDB($"SELECT EDPost_Name FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDPost_NumbDoc_Box.Text = connection.ReadDB($"SELECT EDPost_NumbDoc FROM EducMil WHERE ID = {key}")))

                {
                    EDPost_NumbDoc_Box.Text = connection.ReadDB($"SELECT EDPost_NumbDoc FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDPost_Give_Box.Text = connection.ReadDB($"SELECT EDPost_Give FROM EducMil WHERE ID = {key}")))

                {
                    EDPost_Give_Box.Text = connection.ReadDB($"SELECT EDPost_Give FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDPost_Academ_Box.Text = connection.ReadDB($"SELECT EDPost_Academ FROM EducMil WHERE ID = {key}")))

                {
                    EDPost_Academ_Box.Text = connection.ReadDB($"SELECT EDPost_Academ FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDPost_Dir_Box.Text = connection.ReadDB($"SELECT EDPost_Dir FROM EducMil WHERE ID = {key}")))

                {
                    EDPost_Dir_Box.Text = connection.ReadDB($"SELECT EDPost_Dir FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Mil_ZV_Box.Text = connection.ReadDB($"SELECT Mil_ZV FROM EducMil WHERE ID = {key}")))

                {
                    Mil_ZV_Box.Text = connection.ReadDB($"SELECT Mil_ZV FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Mil_Zapas_Box.Text = connection.ReadDB($"SELECT Mil_Zapas FROM EducMil WHERE ID = {key}")))
                {
                    Mil_Zapas_Box.Text = connection.ReadDB($"SELECT Mil_Zapas FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Mil_VUS_Box.Text = connection.ReadDB($"SELECT Mil_VUS FROM EducMil WHERE ID = {key}")))
                {
                    Mil_VUS_Box.Text = connection.ReadDB($"SELECT Mil_VUS FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Mil_Sostav_Box.Text = connection.ReadDB($"SELECT Mil_Sostav FROM EducMil WHERE ID = {key}")))

                {
                    Mil_Sostav_Box.Text = connection.ReadDB($"SELECT Mil_Sostav FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Mil_Special_Box.Text = connection.ReadDB($"SELECT Mil_Special FROM EducMil WHERE ID = {key}")))

                {
                    Mil_Special_Box.Text = connection.ReadDB($"SELECT Mil_Special FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Mil_Category_Box.Text = connection.ReadDB($"SELECT Mil_Category FROM EducMil WHERE ID = {key}")))

                {
                    Mil_Category_Box.Text = connection.ReadDB($"SELECT Mil_Category FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Mil_Commis_Box.Text = connection.ReadDB($"SELECT Mil_Commis FROM EducMil WHERE ID = {key}")))
                {
                    Mil_Commis_Box.Text = connection.ReadDB($"SELECT Mil_Commis FROM EducMil WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(DateWork_Picker.Text = connection.ReadDB($"SELECT DateWork FROM LaborActiv WHERE ID = {key}")))
                {
                    DateWork_Picker.Text = connection.ReadDB($"SELECT DateWork FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Position_Box.Text = connection.ReadDB($"SELECT Position FROM LaborActiv WHERE ID = {key}")))
                {
                    Position_Box.Text = connection.ReadDB($"SELECT Position FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(NumberContract_Box.Text = connection.ReadDB($"SELECT NumberContract FROM LaborActiv WHERE ID = {key}")))
                {
                    NumberContract_Box.Text = connection.ReadDB($"SELECT NumberContract FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(NumberContractDate_Picker.Text = connection.ReadDB($"SELECT NumberContractDate FROM LaborActiv WHERE ID = {key}")))
                {
                    NumberContractDate_Picker.Text = connection.ReadDB($"SELECT NumberContractDate FROM LaborActiv WHERE ID = {key}");
                }

                if (!string.IsNullOrEmpty(NumOr2_Box.Text = connection.ReadDB($"SELECT NumOr2 FROM LaborActiv WHERE ID = {key}")))
                {
                    NumOr2_Box.Text = connection.ReadDB($"SELECT NumOr2 FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(NumOr2Date_Picker.Text = connection.ReadDB($"SELECT NumOr2Date FROM LaborActiv WHERE ID = {key}")))
                {
                    NumOr2Date_Picker.Text = connection.ReadDB($"SELECT NumOr2Date FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(ContractTerm_Picker.Text = connection.ReadDB($"SELECT ContractTerm FROM LaborActiv WHERE ID = {key}")))
                {
                    ContractTerm_Picker.Text = connection.ReadDB($"SELECT ContractTerm FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Salary_Box.Text = connection.ReadDB($"SELECT Salary FROM LaborActiv WHERE ID = {key}")))
                {
                    Salary_Box.Text = connection.ReadDB($"SELECT Salary FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(WorkExperience_Box.Text = connection.ReadDB($"SELECT WorkExperience FROM LaborActiv WHERE ID = {key}")))
                {
                    WorkExperience_Box.Text = connection.ReadDB($"SELECT WorkExperience FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(Allowance_Box.Text = connection.ReadDB($"SELECT Allowance FROM LaborActiv WHERE ID = {key}")))
                {
                    Allowance_Box.Text = connection.ReadDB($"SELECT Allowance FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(NumOrder_Box.Text = connection.ReadDB($"SELECT NumOrder FROM LaborActiv WHERE ID = {key}")))
                {
                    NumOrder_Box.Text = connection.ReadDB($"SELECT NumOrder FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(PremiumSalary_Box.Text = connection.ReadDB($"SELECT PremiumSalary FROM LaborActiv WHERE ID = {key}")))
                {
                    PremiumSalary_Box.Text = connection.ReadDB($"SELECT PremiumSalary FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(KTU_Box.Text = connection.ReadDB($"SELECT KTU FROM LaborActiv WHERE ID = {key}")))
                {
                    KTU_Box.Text = connection.ReadDB($"SELECT KTU FROM LaborActiv WHERE ID = {key}");
                }
                if (!string.IsNullOrEmpty(EDNameDoc_Box.Text = connection.ReadDB($"SELECT [EDNameDoc] FROM EducMil WHERE ID = {key}")))
                {
                    Rate_Box.Text = connection.ReadDB($"SELECT Rate FROM LaborActiv WHERE ID = {key}");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Запись пуста, не выбрана или допущена ошибка!");
                return;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
            try
            {
                connection.Build($"UPDATE General SET Фамилия=N'{Surname_Box.Text}',Имя=N'{Name_Box.Text}',Отчество=N'{Patronymic_Box.Text}',Пол=N'{Gender_Box.Text}',[Табельный номер]=N'{Number_ID.Text}',[Структурное подразделение]=N'{Structural_subdivision_Box.Text}',Должность=N'{placeofwork_Box.Text}',Телефон=N'{Phone_Box.Text}',[Семейное положение]=N'{Family_Status_Box.Text}',[Место рождения]=N'{Place_Of_Birth_Box.Text}',Гражданство=N'{Citizenship_Box.Text}',Национальность=N'{Nationality_Box.Text}',[Номер страхового полиса]=N'{Insurance_policy_number_Box.Text}',ИНН=N'{TIN_Box.Text}',[Номер мед. полиса]=N'{Medical_policy_box.Text}',[Пенсионное свидетельство]=N'{Pension_Certificate_Box.Text}',[День Рождения]=N'{Birthday_TimePicker.Text}',[Дата приёма на работу]=N'{Employmentdate_Picker.Text}' WHERE ID = {key}");
                connection.Build($"UPDATE Passport SET [Серия паспорта РФ]=N'{RFSeries_Box.Text}',[Номер паспорта РФ]=N'{RFNumber_Box.Text}',[Дата выдачи паспорта РФ]=N'{RFTime_TimePicker.Text}',[Кем выдан паспорт РФ]=N'{RFWhere_Box.Text}',[Город регистрации]=N'{RFRegCity_Box.Text}',[Индекс города регистрации]=N'{RFRegIndex_Box.Text}',[Улица города регистрации]=N'{RFRegSt_Box.Text}',[Город проживания]=N'{RFLiveCity_Box.Text}',[Индекс города проживания]=N'{RFLiveIndex_Box.Text}',[Улица города проживания]=N'{RFLiveSt_Box.Text}',[Серия загран. паспорта]=N'{EXSeries_Box.Text}',[Номер загран. паспорта]=N'{EXNumber_Box.Text}',[Дата выдачи загран. паспорта]=N'{EXDate_TimePicker.Text}',[Место выдачи загран. паспорта] = N'{EXWhere_Box.Text}',[Срок действия]=N'{EXBefore_TimePicker.Text}' WHERE ID = {key}");
                connection.Build($"Update EducMil SET EDNameDoc=N'{EDNameDoc_Box.Text}',EDSer=N'{EDSer_Box.Text}',EDNumber=N'{EDNumber_Box.Text}',EDNameInst=N'{EDNameInst_Box.Text}',EDQual=N'{EDQual_Box.Text}',EDSpecial=N'{EDSpecial_Box.Text}',EDPost_Name=N'{EDPost_Name_Box.Text}',EDPost_NumbDoc=N'{EDPost_NumbDoc_Box.Text}',EDPost_Give=N'{EDPost_Give_Box.Text}',EDPost_Academ=N'{EDPost_Academ_Box.Text}',EDPost_Dir=N'{EDPost_Dir_Box.Text}',Mil_ZV=N'{Mil_ZV_Box.Text}',Mil_Zapas=N'{Mil_Zapas_Box.Text}',Mil_VUS=N'{Mil_VUS_Box.Text}',Mil_Sostav=N'{Mil_Sostav_Box.Text}',Mil_Special=N'{Mil_Special_Box.Text}',Mil_Category=N'{Mil_Category_Box.Text}',Mil_Commis=N'{Mil_Commis_Box.Text}' WHERE ID = {key}");
                connection.Build($"Update LaborActiv SET DateWork=N'{DateWork_Picker.Text}',Position=N'{Position_Box.Text}',NumberContract=N'{NumberContract_Box.Text}',NumberContractDate=N'{NumberContractDate_Picker.Text}',NumOr2=N'{NumOr2_Box.Text}',NumOr2Date=N'{NumOr2Date_Picker.Text}',ContractTerm=N'{ContractTerm_Picker.Text}',Salary=N'{Salary_Box.Text}',WorkExperience=N'{WorkExperience_Box.Text}',Allowance=N'{Allowance_Box.Text}',NumOrder=N'{NumOrder_Box.Text}',PremiumSalary=N'{PremiumSalary_Box.Text}',KTU =N'{KTU_Box.Text}',Rate=N'{Rate_Box.Text}' WHERE ID = {key}");
                connection.Build($"INSERT INTO Journal ([User], Time, Action, Famaly, Name, Surname) VALUES (N'{Data.UserAuthorization}',N'{Data.Today}',N'{"Изненение данных сотрудника"}',N'{Surname_Box.Text}',N'{Name_Box.Text}',N'{Patronymic_Box.Text}')");
            }
            catch (Exception sit2)
            {
                MessageBox.Show(sit2.Message);
            }


        }
    }
}

               