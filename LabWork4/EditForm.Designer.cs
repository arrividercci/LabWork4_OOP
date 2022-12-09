namespace LabWork4
{
    partial class EditForm
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
            this.patronimycTextBox = new System.Windows.Forms.TextBox();
            this.facultyTextBox = new System.Windows.Forms.TextBox();
            this.departamentTextBox = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.academicRankTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // patronimycTextBox
            // 
            this.patronimycTextBox.Location = new System.Drawing.Point(239, 21);
            this.patronimycTextBox.Name = "patronimycTextBox";
            this.patronimycTextBox.Size = new System.Drawing.Size(110, 22);
            this.patronimycTextBox.TabIndex = 0;
            // 
            // facultyTextBox
            // 
            this.facultyTextBox.Location = new System.Drawing.Point(355, 21);
            this.facultyTextBox.Name = "facultyTextBox";
            this.facultyTextBox.Size = new System.Drawing.Size(110, 22);
            this.facultyTextBox.TabIndex = 1;
            // 
            // departamentTextBox
            // 
            this.departamentTextBox.Location = new System.Drawing.Point(471, 21);
            this.departamentTextBox.Name = "departamentTextBox";
            this.departamentTextBox.Size = new System.Drawing.Size(110, 22);
            this.departamentTextBox.TabIndex = 2;
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.Location = new System.Drawing.Point(587, 21);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(128, 22);
            this.degreeTextBox.TabIndex = 3;
            // 
            // academicRankTextBox
            // 
            this.academicRankTextBox.Location = new System.Drawing.Point(721, 21);
            this.academicRankTextBox.Name = "academicRankTextBox";
            this.academicRankTextBox.Size = new System.Drawing.Size(132, 22);
            this.academicRankTextBox.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(859, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(173, 40);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Редагувати";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(123, 21);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(110, 22);
            this.surnameTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(7, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(110, 22);
            this.nameTextBox.TabIndex = 7;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 61);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.academicRankTextBox);
            this.Controls.Add(this.degreeTextBox);
            this.Controls.Add(this.departamentTextBox);
            this.Controls.Add(this.facultyTextBox);
            this.Controls.Add(this.patronimycTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patronimycTextBox;
        private System.Windows.Forms.TextBox facultyTextBox;
        private System.Windows.Forms.TextBox departamentTextBox;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.TextBox academicRankTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}