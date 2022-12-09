using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabWork4
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var surname = surnameTextBox.Text;
            var patronimyc = patronimycTextBox.Text;
            var faculty = facultyTextBox.Text;
            var departament = departamentTextBox.Text;
            var degree = degreeTextBox.Text;
            var academicRank = academicRankTextBox.Text;
    
            try
            {
                ScientistData.scientist = new Classes.Scientist(name, surname, patronimyc, faculty, departament, degree, academicRank);
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = ScientistData.scientist.Name;
            surnameTextBox.Text = ScientistData.scientist.Surname;
            patronimycTextBox.Text = ScientistData.scientist.Patronimyc;
            facultyTextBox.Text = ScientistData.scientist.Faculty;
            departamentTextBox.Text = ScientistData.scientist.Departament;
            degreeTextBox.Text = ScientistData.scientist.Degree;
            academicRankTextBox.Text = ScientistData.scientist.AcademicRank;
        }
    }
}
