namespace HomeWork_3_WF_Task_2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tB = new TextBox();
            btnLoad = new Button();
            btnEdit = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnSaveFile = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // tB
            // 
            tB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tB.Location = new Point(35, 50);
            tB.Margin = new Padding(4, 3, 4, 3);
            tB.Multiline = true;
            tB.Name = "tB";
            tB.ReadOnly = true;
            tB.ScrollBars = ScrollBars.Both;
            tB.Size = new Size(725, 400);
            tB.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ActiveBorder;
            btnLoad.Location = new Point(775, 50);
            btnLoad.Margin = new Padding(4, 3, 4, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 35);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Загрузить файл";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveBorder;
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(775, 111);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 50);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать файл";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = SystemColors.ActiveBorder;
            btnSaveFile.Enabled = false;
            btnSaveFile.Location = new Point(775, 189);
            btnSaveFile.Margin = new Padding(4, 3, 4, 3);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(150, 35);
            btnSaveFile.TabIndex = 3;
            btnSaveFile.Text = "Сохранить файл";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "Text";
            saveFileDialog1.Filter = "Text|*.txt";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 511);
            Controls.Add(btnSaveFile);
            Controls.Add(btnEdit);
            Controls.Add(btnLoad);
            Controls.Add(tB);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Главная форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tB;
        private Button btnLoad;
        private Button btnEdit;
        private OpenFileDialog openFileDialog1;
        private Button btnSaveFile;
        private SaveFileDialog saveFileDialog1;
    }
}