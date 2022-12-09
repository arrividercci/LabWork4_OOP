using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork4
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
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
    }
}
