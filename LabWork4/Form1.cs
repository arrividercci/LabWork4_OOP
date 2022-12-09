using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LabWork4
{
    public partial class Form1 : Form
    {
        private AddForm addForm;
        private EditForm editForm;
        private AboutProgramForm aboutProgramForm;
        private BindingList<Classes.Scientist> scientistList;
        private Classes.FileManager fileManager;
        private Classes.Helper helper;
        private readonly string reserveTxtFilePath = "ReserveTextFile.txt";
        private readonly string reserveJsonFilePath = "ReservJsonFile.json";
        
        private void SetBindingSource(BindingList<Classes.Scientist> scientists)
        {
            scientistList = scientists;
            scientistBindingSource.DataSource = scientists;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetBindingSource(new BindingList<Classes.Scientist>());
            timer.Start();
            helper = new Classes.Helper();
            fileManager = new Classes.FileManager();
            helper.StartStopwatch();
        }

        private void AddScientistButton_Click(object sender, EventArgs e)
        {
            addForm = new AddForm();
            addForm.ShowDialog();
            if (ScientistData.scientist != null) scientistList.Add(ScientistData.scientist);
        }

        private void RemoveScientistButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in scientistDataGridView.SelectedRows)
            {
                scientistList.RemoveAt(item.Index);
            }
        }

        private void EditScientistDataButton_Click(object sender, EventArgs e)
        {
            int countSelectedRows = scientistDataGridView.SelectedRows.Count;
            if (countSelectedRows == 1)
            {
                var index = scientistDataGridView.SelectedRows[0].Index;
                ScientistData.scientist = scientistList[index];
                editForm = new EditForm();
                editForm.ShowDialog();
                scientistList[index] = ScientistData.scientist;
            }
            else
            {
                MessageBox.Show("Не можна редагувати одночасно декілька рядків");
            }
        }

        private void txtSaveButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = toolStripFilePathTextBox.Text;
                fileManager.SetSaveStrategy(new Classes.TxtSaveStrategy());
                if (System.IO.File.Exists(path))
                {
                    fileManager.Save(path, scientistList);
                }
                else
                {
                    fileManager.Save(reserveTxtFilePath, scientistList);
                    MessageBox.Show("Такого файлу не існує\nДанні збережено в ReservTextFile.txt");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jsonSaveButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = toolStripFilePathTextBox.Text;
                fileManager.SetSaveStrategy(new Classes.JsonSaveStrategy());
                if (System.IO.File.Exists(path))
                {
                    fileManager.Save(path, scientistList);
                }
                else
                {
                    fileManager.Save(reserveJsonFilePath, scientistList);
                    MessageBox.Show("Такого файлу не існує\nДанні збережено в ReservJsonFile.json");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtLoadButtonStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = toolStripFilePathTextBox.Text;
                fileManager.SetLoadStrategy(new Classes.TxtLoadStrategy());
                if (System.IO.File.Exists(path))
                {
                    SetBindingSource(fileManager.Load(path));
                }
                else
                {
                    SetBindingSource(fileManager.Load(reserveTxtFilePath));
                    MessageBox.Show("Такого файлу не існує\nДанні завантажено з ReservTextFile.txt");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jsonLoadButtonStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = toolStripFilePathTextBox.Text;
                fileManager.SetLoadStrategy(new Classes.JsonLoadStrategy());
                if (System.IO.File.Exists(path))
                {
                    SetBindingSource(fileManager.Load(path));
                }
                else
                {
                    SetBindingSource(fileManager.Load(reserveJsonFilePath));
                    MessageBox.Show("Такого файлу не існує\nДанні завантажено з ReservJsonFile.txt");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = "Час роботи програми " + helper.GetStopWatchTime();
        }

        private void sortByDescendingButton_Click(object sender, EventArgs e)
        {
            SetBindingSource(helper.SortDescending(scientistList));
        }

        private void findLongestSurnameButton_Click(object sender, EventArgs e)
        {
            scientistBindingSource.DataSource = helper.FindLongestSurname(scientistList);
        }

        private void findByFacultyButton_Click(object sender, EventArgs e)
        {
            var criterion = facultySearchtextBox.Text;
            if (string.IsNullOrWhiteSpace(criterion))
            {
                MessageBox.Show("Критерій не може бути пустим!");
            }
            SetBindingSource(helper.FindScientistsByFaculty(criterion, scientistList));
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutProgramtoolStripButton_Click(object sender, EventArgs e)
        {
            aboutProgramForm = new AboutProgramForm();
            aboutProgramForm.ShowDialog();
        }
    }
}
