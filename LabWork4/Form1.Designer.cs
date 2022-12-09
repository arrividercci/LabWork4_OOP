namespace LabWork4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scientistDataGridView = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scientistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddScientistButton = new System.Windows.Forms.Button();
            this.RemoveScientistButton = new System.Windows.Forms.Button();
            this.EditScientistDataButton = new System.Windows.Forms.Button();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSaveButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonSaveButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLoadButtonStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonLoadButtonStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFilePathTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Exit = new System.Windows.Forms.ToolStripButton();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.findByFacultyButton = new System.Windows.Forms.Button();
            this.findLongestSurnameButton = new System.Windows.Forms.Button();
            this.sortByDescendingButton = new System.Windows.Forms.Button();
            this.facultySearchtextBox = new System.Windows.Forms.TextBox();
            this.aboutProgramtoolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.scientistDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientistBindingSource)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // scientistDataGridView
            // 
            this.scientistDataGridView.AllowUserToAddRows = false;
            this.scientistDataGridView.AllowUserToDeleteRows = false;
            this.scientistDataGridView.AutoGenerateColumns = false;
            this.scientistDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scientistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scientistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Faculty,
            this.Departament,
            this.Degree,
            this.AcademicRank});
            this.scientistDataGridView.DataSource = this.scientistBindingSource;
            this.scientistDataGridView.Location = new System.Drawing.Point(24, 85);
            this.scientistDataGridView.Name = "scientistDataGridView";
            this.scientistDataGridView.ReadOnly = true;
            this.scientistDataGridView.RowHeadersWidth = 51;
            this.scientistDataGridView.RowTemplate.Height = 24;
            this.scientistDataGridView.Size = new System.Drawing.Size(918, 459);
            this.scientistDataGridView.TabIndex = 0;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Повне ім\'я";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Faculty
            // 
            this.Faculty.DataPropertyName = "Faculty";
            this.Faculty.HeaderText = "Факультет";
            this.Faculty.MinimumWidth = 6;
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            // 
            // Departament
            // 
            this.Departament.DataPropertyName = "Departament";
            this.Departament.HeaderText = "Кафедра";
            this.Departament.MinimumWidth = 6;
            this.Departament.Name = "Departament";
            this.Departament.ReadOnly = true;
            // 
            // Degree
            // 
            this.Degree.DataPropertyName = "Degree";
            this.Degree.HeaderText = "Науковий ступінь";
            this.Degree.MinimumWidth = 6;
            this.Degree.Name = "Degree";
            this.Degree.ReadOnly = true;
            // 
            // AcademicRank
            // 
            this.AcademicRank.DataPropertyName = "AcademicRank";
            this.AcademicRank.HeaderText = "Вчене звання";
            this.AcademicRank.MinimumWidth = 6;
            this.AcademicRank.Name = "AcademicRank";
            this.AcademicRank.ReadOnly = true;
            // 
            // AddScientistButton
            // 
            this.AddScientistButton.Location = new System.Drawing.Point(24, 43);
            this.AddScientistButton.Name = "AddScientistButton";
            this.AddScientistButton.Size = new System.Drawing.Size(116, 36);
            this.AddScientistButton.TabIndex = 1;
            this.AddScientistButton.Text = "Додати";
            this.AddScientistButton.UseVisualStyleBackColor = true;
            this.AddScientistButton.Click += new System.EventHandler(this.AddScientistButton_Click);
            // 
            // RemoveScientistButton
            // 
            this.RemoveScientistButton.Location = new System.Drawing.Point(146, 43);
            this.RemoveScientistButton.Name = "RemoveScientistButton";
            this.RemoveScientistButton.Size = new System.Drawing.Size(116, 36);
            this.RemoveScientistButton.TabIndex = 2;
            this.RemoveScientistButton.Text = "Видалити";
            this.RemoveScientistButton.UseVisualStyleBackColor = true;
            this.RemoveScientistButton.Click += new System.EventHandler(this.RemoveScientistButton_Click);
            // 
            // EditScientistDataButton
            // 
            this.EditScientistDataButton.Location = new System.Drawing.Point(268, 43);
            this.EditScientistDataButton.Name = "EditScientistDataButton";
            this.EditScientistDataButton.Size = new System.Drawing.Size(116, 36);
            this.EditScientistDataButton.TabIndex = 3;
            this.EditScientistDataButton.Text = "Редагувати";
            this.EditScientistDataButton.UseVisualStyleBackColor = true;
            this.EditScientistDataButton.Click += new System.EventHandler(this.EditScientistDataButton_Click);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripFilePathTextBox,
            this.Exit,
            this.aboutProgramtoolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1139, 33);
            this.mainToolStrip.TabIndex = 4;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.AutoSize = false;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem,
            this.відкритиToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(70, 30);
            this.toolStripSplitButton1.Text = "Файл";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSaveButtonToolStripMenuItem,
            this.jsonSaveButtonToolStripMenuItem});
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // txtSaveButtonToolStripMenuItem
            // 
            this.txtSaveButtonToolStripMenuItem.Name = "txtSaveButtonToolStripMenuItem";
            this.txtSaveButtonToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.txtSaveButtonToolStripMenuItem.Text = "Txt формат";
            this.txtSaveButtonToolStripMenuItem.Click += new System.EventHandler(this.txtSaveButtonToolStripMenuItem_Click);
            // 
            // jsonSaveButtonToolStripMenuItem
            // 
            this.jsonSaveButtonToolStripMenuItem.Name = "jsonSaveButtonToolStripMenuItem";
            this.jsonSaveButtonToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.jsonSaveButtonToolStripMenuItem.Text = "Json формат";
            this.jsonSaveButtonToolStripMenuItem.Click += new System.EventHandler(this.jsonSaveButtonToolStripMenuItem_Click);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtLoadButtonStripMenuItem,
            this.jsonLoadButtonStripMenuItem});
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            // 
            // txtLoadButtonStripMenuItem
            // 
            this.txtLoadButtonStripMenuItem.Name = "txtLoadButtonStripMenuItem";
            this.txtLoadButtonStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.txtLoadButtonStripMenuItem.Text = "Txt файл";
            this.txtLoadButtonStripMenuItem.Click += new System.EventHandler(this.txtLoadButtonStripMenuItem_Click);
            // 
            // jsonLoadButtonStripMenuItem
            // 
            this.jsonLoadButtonStripMenuItem.Name = "jsonLoadButtonStripMenuItem";
            this.jsonLoadButtonStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.jsonLoadButtonStripMenuItem.Text = "Json файл";
            this.jsonLoadButtonStripMenuItem.Click += new System.EventHandler(this.jsonLoadButtonStripMenuItem_Click);
            // 
            // toolStripFilePathTextBox
            // 
            this.toolStripFilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripFilePathTextBox.Name = "toolStripFilePathTextBox";
            this.toolStripFilePathTextBox.Size = new System.Drawing.Size(200, 33);
            this.toolStripFilePathTextBox.Text = "Введіть шлях до файлу";
            // 
            // Exit
            // 
            this.Exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 30);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(1020, 43);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(44, 24);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Time";
            this.timeLabel.UseCompatibleTextRendering = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // findByFacultyButton
            // 
            this.findByFacultyButton.Location = new System.Drawing.Point(949, 207);
            this.findByFacultyButton.Name = "findByFacultyButton";
            this.findByFacultyButton.Size = new System.Drawing.Size(185, 45);
            this.findByFacultyButton.TabIndex = 6;
            this.findByFacultyButton.Text = "Знайти науковців по факультету";
            this.findByFacultyButton.UseVisualStyleBackColor = true;
            this.findByFacultyButton.Click += new System.EventHandler(this.findByFacultyButton_Click);
            // 
            // findLongestSurnameButton
            // 
            this.findLongestSurnameButton.Location = new System.Drawing.Point(949, 140);
            this.findLongestSurnameButton.Name = "findLongestSurnameButton";
            this.findLongestSurnameButton.Size = new System.Drawing.Size(185, 61);
            this.findLongestSurnameButton.TabIndex = 7;
            this.findLongestSurnameButton.Text = "Знайти науковця з найдовшим прізвищем";
            this.findLongestSurnameButton.UseVisualStyleBackColor = true;
            this.findLongestSurnameButton.Click += new System.EventHandler(this.findLongestSurnameButton_Click);
            // 
            // sortByDescendingButton
            // 
            this.sortByDescendingButton.Location = new System.Drawing.Point(949, 85);
            this.sortByDescendingButton.Name = "sortByDescendingButton";
            this.sortByDescendingButton.Size = new System.Drawing.Size(185, 49);
            this.sortByDescendingButton.TabIndex = 8;
            this.sortByDescendingButton.Text = "Сортувати по спаданню";
            this.sortByDescendingButton.UseVisualStyleBackColor = true;
            this.sortByDescendingButton.Click += new System.EventHandler(this.sortByDescendingButton_Click);
            // 
            // facultySearchtextBox
            // 
            this.facultySearchtextBox.Location = new System.Drawing.Point(949, 268);
            this.facultySearchtextBox.Name = "facultySearchtextBox";
            this.facultySearchtextBox.Size = new System.Drawing.Size(185, 22);
            this.facultySearchtextBox.TabIndex = 9;
            this.facultySearchtextBox.Text = "Введіть назву факультету";
            this.facultySearchtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aboutProgramtoolStripButton
            // 
            this.aboutProgramtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutProgramtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutProgramtoolStripButton.Image")));
            this.aboutProgramtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutProgramtoolStripButton.Name = "aboutProgramtoolStripButton";
            this.aboutProgramtoolStripButton.Size = new System.Drawing.Size(67, 30);
            this.aboutProgramtoolStripButton.Text = "Довідка";
            this.aboutProgramtoolStripButton.Click += new System.EventHandler(this.aboutProgramtoolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1139, 556);
            this.Controls.Add(this.facultySearchtextBox);
            this.Controls.Add(this.sortByDescendingButton);
            this.Controls.Add(this.findLongestSurnameButton);
            this.Controls.Add(this.findByFacultyButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.EditScientistDataButton);
            this.Controls.Add(this.RemoveScientistButton);
            this.Controls.Add(this.AddScientistButton);
            this.Controls.Add(this.scientistDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scientistDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientistBindingSource)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scientistDataGridView;
        private System.Windows.Forms.Button AddScientistButton;
        private System.Windows.Forms.BindingSource scientistBindingSource;
        private System.Windows.Forms.Button RemoveScientistButton;
        private System.Windows.Forms.Button EditScientistDataButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departament;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicRank;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtSaveButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonSaveButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtLoadButtonStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonLoadButtonStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripFilePathTextBox;
        private System.Windows.Forms.ToolStripButton Exit;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button findByFacultyButton;
        private System.Windows.Forms.Button findLongestSurnameButton;
        private System.Windows.Forms.Button sortByDescendingButton;
        private System.Windows.Forms.TextBox facultySearchtextBox;
        private System.Windows.Forms.ToolStripButton aboutProgramtoolStripButton;
    }
}

