using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Hanson_CourseProject_part2
{
  
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Great now write to file
        private void WriteEmpsToFile()
        {
            string filename = "Employees.csv";
            StreamWriter sw = new StreamWriter(filename);
            foreach (Employee emp in EmployeesListBox.Items)
            {
                sw.WriteLine(emp.FirstName + ','
                    + emp.LastName + ','
                    + emp.SSN + ','
                    + emp.HireDate.ToShortDateString() + ','
                    + emp.BenefitsEmp.HealthInsurance + ',' 
                    + emp.BenefitsEmp.LifeInsurance + ','
                    + emp.BenefitsEmp.Vacation);
            }

            sw.Close();
        }
        private void ReadEmpsToFile()
        {
            //clear Employee List Box
            EmployeesListBox.Items.Clear();
            //read employees from file
            string filename = "Employees.csv";
            StreamReader sr = new StreamReader(filename);
            while( sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] parts = line.Split(',');
                string firstName = parts[0];
                string lastName = parts[1];
                string ssn = parts[2];
                DateTime hireDate = DateTime.Parse(parts[3]);
                string healthIns = parts[4];
                int lifeIns = int.Parse(parts[5]);
                int vacation = int.Parse(parts[6]);

                Benefits ben = new Benefits(healthIns, lifeIns, vacation);
                
                Employee emp = new Employee(firstName, lastName, ssn, hireDate, ben);
                EmployeesListBox.Items.Add(emp);
            }
            sr.Close();
        }
        private void button_MouseLeave(object sender, System.EventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                // not a button, do nothing
                return;
            }
            else
            {
                button.BackColor = SystemColors.ButtonFace;
            }

        }

            private void button_MouseHover(object sender, System.EventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                // not a button, do nothing
                return;
            }

            if (sender.Equals(AddButton))
            {
                button.BackColor = Color.Green;
            }
            else if (sender.Equals(RemoveButton))
            {
                button.BackColor = Color.Red;
            }
            else if (sender.Equals(PrintPaychecksButton))
            {
                button.BackColor = Color.BlueViolet;
            }
            else if (sender.Equals(DisplayButton))
            {
                button.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button.BackColor = SystemColors.ButtonShadow;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            //add item to employeelistbox
            InputForm frmInput = new InputForm();
            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();
                //see if form was cancelled
                if (result == DialogResult.Cancel)
                    return;
                //get user input, create employee object
                string fName = frmInput.FirstNameTextBox.Text;
                string lName = frmInput.LastNameTextBox.Text;
                string ssn = frmInput.SSNTextBox.Text;
                string date = frmInput.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmInput.HealthInsuranceTextBox.Text;
                int lifeIns = int.Parse(frmInput.LifeInsuranceTextBox.Text);
                int vacation = int.Parse(frmInput.VacationDaysTextBox.Text);

                Benefits ben = new Benefits(healthIns, lifeIns, vacation);

                Employee emp = new Employee(fName, lName, ssn, hireDate, ben);
                // add Employee object to employee listbox
                EmployeesListBox.Items.Add(emp);
            }
            WriteEmpsToFile();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // remove the selected item from the employee listbox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }
            WriteEmpsToFile();

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying all employees...");
            ReadEmpsToFile();
        }
       

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all Employees...");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try { ReadEmpsToFile(); }
            catch { MessageBox.Show("No preexisting records detected"); }
        }

        private void EmployeesListBox_DoubleClick(object sender, EventArgs e)
        {
            //get selected Employee Object 
            Employee emp = EmployeesListBox.SelectedItem as Employee;

            //show input/update form with employee information
            InputForm frmUpdate = new InputForm();
            frmUpdate.SubmitButton.Text = "Update";
            frmUpdate.FirstNameTextBox.Text = emp.FirstName;
            frmUpdate.LastNameTextBox.Text = emp.LastName;
            frmUpdate.SSNTextBox.Text = emp.SSN;
            frmUpdate.HireDateTextBox.Text = emp.HireDate.ToShortDateString();
            frmUpdate.HealthInsuranceTextBox.Text = emp.BenefitsEmp.HealthInsurance;
            frmUpdate.LifeInsuranceTextBox.Text = emp.BenefitsEmp.LifeInsurance.ToString();
            frmUpdate.VacationDaysTextBox.Text = emp.BenefitsEmp.Vacation.ToString();
            
            DialogResult result = frmUpdate.ShowDialog();

            //if cancelled, stop method
            if (result == DialogResult.Cancel)
                return; //end method
            //otherwise delete the selected object, to replace
            int position = EmployeesListBox.SelectedIndex;
            EmployeesListBox.Items.RemoveAt(position);
            //create new employee using updated info
            Employee newEmp = new Employee();
            newEmp.FirstName = frmUpdate.FirstNameTextBox.Text;
            newEmp.LastName = frmUpdate.LastNameTextBox.Text;
            newEmp.SSN = frmUpdate.SSNTextBox.Text;
            newEmp.HireDate = DateTime.Parse(frmUpdate.HireDateTextBox.Text);
            newEmp.BenefitsEmp.HealthInsurance = frmUpdate.HealthInsuranceTextBox.Text;
            newEmp.BenefitsEmp.LifeInsurance = int.Parse(frmUpdate.LifeInsuranceTextBox.Text);
            newEmp.BenefitsEmp.Vacation = int.Parse(frmUpdate.VacationDaysTextBox.Text);

            // add new employee to listbox
            EmployeesListBox.Items.Add(newEmp);




        }
    }
}

