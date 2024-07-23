namespace HomeWork_3_WF_Task_2
{
    public partial class MainForm : Form
    {
        string fileName_; // Путь к файлу
        Form form; // Вторая форма
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName_ = openFileDialog1.FileName; // Путь к файлу
            }
            StreamReader sr = new StreamReader(fileName_); // Создаём поток для чтения из файла
            tB.Text = sr.ReadToEnd(); // Считываем в texbox информацию из файла
            sr.Close();
            btnEdit.Enabled = true; // Разблокируем кнопку вызова второй формы
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Если форма пустая или не создана
            if ((form is null) || (!form.Created))
            {
                form = new FormEdit(tB, btnSaveFile); // Заполняем textbox второй формы текстом из textbox первой формы
                form.Show();
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName_ = saveFileDialog1.FileName; // Путь для сохранения файла
                StreamWriter sw = new StreamWriter(fileName_); // Открываем поток для записи в файл
                sw.Write(tB.Text); // Записываем текст из tB в файл
                sw.Close();
            }
        }
    }
}