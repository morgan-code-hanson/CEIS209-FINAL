namespace Hanson_CourseProject_part2
{
    partial class MainForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.PrintPaychecksButton = new System.Windows.Forms.Button();
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(33, 41);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(169, 61);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.AddButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(214, 41);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(6);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(169, 61);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.RemoveButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.RemoveButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(441, 41);
            this.DisplayButton.Margin = new System.Windows.Forms.Padding(6);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(169, 61);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            this.DisplayButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.DisplayButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // PrintPaychecksButton
            // 
            this.PrintPaychecksButton.Location = new System.Drawing.Point(622, 41);
            this.PrintPaychecksButton.Margin = new System.Windows.Forms.Padding(6);
            this.PrintPaychecksButton.Name = "PrintPaychecksButton";
            this.PrintPaychecksButton.Size = new System.Drawing.Size(169, 61);
            this.PrintPaychecksButton.TabIndex = 3;
            this.PrintPaychecksButton.Text = "Print Paychecks";
            this.PrintPaychecksButton.UseVisualStyleBackColor = true;
            this.PrintPaychecksButton.Click += new System.EventHandler(this.PrintPaychecksButton_Click);
            this.PrintPaychecksButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.PrintPaychecksButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.HorizontalScrollbar = true;
            this.EmployeesListBox.ItemHeight = 25;
            this.EmployeesListBox.Location = new System.Drawing.Point(33, 125);
            this.EmployeesListBox.Margin = new System.Windows.Forms.Padding(6);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(758, 279);
            this.EmployeesListBox.TabIndex = 4;
            this.EmployeesListBox.DoubleClick += new System.EventHandler(this.EmployeesListBox_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(806, 428);
            this.Controls.Add(this.EmployeesListBox);
            this.Controls.Add(this.PrintPaychecksButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Payroll System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button PrintPaychecksButton;
        private System.Windows.Forms.ListBox EmployeesListBox;
    }
}

