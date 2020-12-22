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
    public partial class ReportsDelete : Form
    {

        public ReportsDelete(int number)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (number == 1)
            {
                Поле_удаления_отчета.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения о командировках]").Tables[0].DefaultView;
            }
            if (number == 2)
            {
                Поле_удаления_отчета.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения о больничных]").Tables[0].DefaultView;
            }
            if (number == 3)
            {
                Поле_удаления_отчета.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения об уволенных]").Tables[0].DefaultView;
            }
            if (number == 4)
            {
                Поле_удаления_отчета.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения об отпусках]").Tables[0].DefaultView;
            }
            MyProperty=number;

        }
        private void Удалить_отчет(object sender, EventArgs e)
        {
            int Station = MyProperty;
            string id = string.Empty;
            if (Station == 1)
            {
                id = Поле_удаления_отчета.Rows[Поле_удаления_отчета.CurrentCell.RowIndex].Cells["Id командировки"].Value.ToString();
                connection.Получить_сведения_из_базы_данных($"delete FROM [Сведения о командировках] where [Id командировки] ={id}");
                Поле_удаления_отчета.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения о командировках]").Tables[0].DefaultView;
            }
            if (Station == 2)
            {
                id = Поле_удаления_отчета.Rows[Поле_удаления_отчета.CurrentCell.RowIndex].Cells["Id больничного"].Value.ToString();
                connection.Получить_сведения_из_базы_данных($"delete FROM [Сведения о больничных] where [Id больничного] ={id}");
                Поле_удаления_отчета.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения о больничных]").Tables[0].DefaultView;
            }
            if (Station == 3)
            {
                id = Поле_удаления_отчета.Rows[Поле_удаления_отчета.CurrentCell.RowIndex].Cells["Id увольнения"].Value.ToString();
                connection.Получить_сведения_из_базы_данных($"delete FROM [Сведения об уволенных] where [Id увольнения] ={id}");
                Поле_удаления_отчета.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения об уволенных]").Tables[0].DefaultView;
            }
            if (Station == 4)
            {
                id = Поле_удаления_отчета.Rows[Поле_удаления_отчета.CurrentCell.RowIndex].Cells["Id отпуска"].Value.ToString();
                connection.Получить_сведения_из_базы_данных($"delete FROM [Сведения об отпусках] where [Id отпуска] ={id}");
                Поле_удаления_отчета.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения об отпусках]").Tables[0].DefaultView;
            }
        }
        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int myVar;
        public int MyProperty
        {
            get {return myVar; }
            set {myVar = value; }
        }
    }
}
 