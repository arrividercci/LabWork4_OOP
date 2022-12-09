namespace LabWork4
{
    partial class AddForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronimycTextBox = new System.Windows.Forms.TextBox();
            this.facultyTextBox = new System.Windows.Forms.TextBox();
            this.departamentTextBox = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.academicRankTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(58, 172);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(263, 50);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(12, 26);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(121, 22);
            this.surnameTextBox.TabIndex = 1;
            this.surnameTextBox.Text = "Прізвище";
            this.surnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(139, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 22);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Text = "Ім\'я";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patronimycTextBox
            // 
            this.patronimycTextBox.Location = new System.Drawing.Point(266, 26);
            this.patronimycTextBox.Name = "patronimycTextBox";
            this.patronimycTextBox.Size = new System.Drawing.Size(121, 22);
            this.patronimycTextBox.TabIndex = 3;
            this.patronimycTextBox.Text = "По батькові";
            this.patronimycTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // facultyTextBox
            // 
            this.facultyTextBox.Location = new System.Drawing.Point(58, 77);
            this.facultyTextBox.Name = "facultyTextBox";
            this.facultyTextBox.Size = new System.Drawing.Size(121, 22);
            this.facultyTextBox.TabIndex = 4;
            this.facultyTextBox.Text = "Факультет";
            this.facultyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // departamentTextBox
            // 
            this.departamentTextBox.Location = new System.Drawing.Point(200, 77);
            this.departamentTextBox.Name = "departamentTextBox";
            this.departamentTextBox.Size = new System.Drawing.Size(121, 22);
            this.departamentTextBox.TabIndex = 5;
            this.departamentTextBox.Text = "Кафедра";
            this.departamentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.Location = new System.Drawing.Point(200, 115);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(121, 22);
            this.degreeTextBox.TabIndex = 6;
            this.degreeTextBox.Text = "Науковий ступінь";
            this.degreeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // academicRankTextBox
            // 
            this.academicRankTextBox.Location = new System.Drawing.Point(58, 115);
            this.academicRankTextBox.Name = "academicRankTextBox";
            this.academicRankTextBox.Size = new System.Drawing.Size(121, 22);
            this.academicRankTextBox.TabIndex = 7;
            this.academicRankTextBox.Text = "Вчене звання";
            this.academicRankTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 264);
            this.Controls.Add(this.academicRankTextBox);
            this.Controls.Add(this.degreeTextBox);
            this.Controls.Add(this.departamentTextBox);
            this.Controls.Add(this.facultyTextBox);
            this.Controls.Add(this.patronimycTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patronimycTextBox;
        private System.Windows.Forms.TextBox facultyTextBox;
        private System.Windows.Forms.TextBox departamentTextBox;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.TextBox academicRankTextBox;
    }
}