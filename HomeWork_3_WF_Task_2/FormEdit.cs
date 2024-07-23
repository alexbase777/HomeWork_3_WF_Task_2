using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_3_WF_Task_2
{
    public partial class FormEdit : Form
    {
        private TextBox tbEdit_; // Переменная для хранения ссылки на tB главной формы
        private Button btnSaveFile_; // Переменная для хранения ссылки на кнопку "Сохранить файл" главной формы
        public FormEdit()
        {
            InitializeComponent();
        }

        public FormEdit(TextBox obj, Button btn) // В конструктор второй формы передаём объект из первой формы
        {
            InitializeComponent();
            this.tBEdit.Text = obj.Text; // Записываем в tBEdit текст из переданного obj         
            tbEdit_ = obj; // tBEdit_ - ссылка на tB главной формы
            this.btnSaveFile_ = btn; // Ссылка на кнопку "Сохранить файл"
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем окно
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbEdit_.Text = tBEdit.Text; // Через ссылку меняем текст в tB главного окна
            btnSaveFile_.Enabled = true; // Разблокируем кнопку "Сохранить файл" на главной форме
            this.Close();            
        }
    }
}
