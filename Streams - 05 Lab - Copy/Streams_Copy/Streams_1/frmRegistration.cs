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
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Streams_1
{
    public partial class frmRegistration : Form
    {
        public StudentInfoClass RegisteredStudent { get; private set; }
        public frmRegistration()
        {
            InitializeComponent();
        }

        // REGISTER
        private void register_btn_Click(object sender, EventArgs e)
        {
            Register(); 
        }
        // Register method

        public void Register()
        {
            

            // Create a new StudentInfoClass object
            RegisteredStudent = new StudentInfoClass
            {
                studentNo = studentNoTxt.Text,
                lastName = lastNameTxt.Text,
                firstName = firstNameTxt.Text,
                middleName = middleNameTxt.Text,
                program = prog_cb.Text,
                gender = gender_cb.Text,
                age = ageTxt.Text,
                birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                contactNo = contactNumTxt.Text
            };

            try
            {
                // Input validation
                if (string.IsNullOrWhiteSpace(RegisteredStudent.studentNo) ||
                    string.IsNullOrWhiteSpace(RegisteredStudent.program) ||
                    string.IsNullOrWhiteSpace(RegisteredStudent.gender) ||
                    string.IsNullOrWhiteSpace(RegisteredStudent.age) ||
                    string.IsNullOrWhiteSpace(RegisteredStudent.birthday)||
                    string.IsNullOrWhiteSpace(RegisteredStudent.contactNo))
                    
                {
                    throw new Exception("All fields must be filled out.");
                }

                if (!Regex.IsMatch(RegisteredStudent.lastName, @"^[a-zA-Z\s]+$") ||
                    !Regex.IsMatch(RegisteredStudent.firstName, @"^[a-zA-Z\s]+$") ||
                    !Regex.IsMatch(RegisteredStudent.middleName, @"^[a-zA-Z\s]+$"))
                {
                    throw new Exception("Name fields must contain only letters.");
                }

                if (!Regex.IsMatch(RegisteredStudent.contactNo, @"^\d+$"))
                {
                    throw new Exception("Contact Number must contain only numbers.");
                }

                
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // student record form
                FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
                frmStudentRecord.AddStudentRecord(RegisteredStudent);  // pass student data to the student record form
                frmStudentRecord.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // RECORDS
        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            this.Hide();
            frmStudentRecord.Show();
        }
        private void studentNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactNum_TextChanged(object sender, EventArgs e)
        {
            if(contactNumTxt.Text.StartsWith("0"))
            {
                contactNumTxt.Text = contactNumTxt.Text.Substring(1);
            }
            contactNumTxt.SelectionStart = contactNumTxt.Text.Length;
        }

        private void prog_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
