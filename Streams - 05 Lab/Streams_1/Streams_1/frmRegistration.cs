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

namespace Streams_1
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        // REGISTER
        private void register_btn_Click(object sender, EventArgs e)
        {
            // PATH
            string path = @"C:\Users\Red\Desktop\School\3rd year\1st sem\Event-Driven Programming";            
            string studentNo = studentNoTxt.Text;
            string lastName = lastNameTxt.Text;
            string firstName = firstNameTxt.Text;
            string middleName = middleNameTxt.Text;
            string program = prog_cb.Text;
            string gender = gender_cb.Text;
            string age = ageTxt.Text;
            string birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string contactNo = contactNumTxt.Text;

            // stream writer

            try
            {
               
                if (!Regex.IsMatch(lastName, @"^[a-zA-Z\s]+$"))
                {
                    throw new Exception("Last Name must contain only letters.");
                }

                
                if (!Regex.IsMatch(firstName, @"^[a-zA-Z\s]+$"))
                {
                    throw new Exception("First Name must contain only letters.");
                }

                
                if (!Regex.IsMatch(middleName, @"^[a-zA-Z\s]+$"))
                {
                    throw new Exception("Middle Name must contain only letters.");
                }

                
                if (!Regex.IsMatch(contactNo, @"^\d+$"))
                {
                    throw new Exception("Contact Number must contain only numbers.");
                }

                
                if (string.IsNullOrWhiteSpace(studentNo) ||
                    string.IsNullOrWhiteSpace(program) ||
                    string.IsNullOrWhiteSpace(gender) ||
                    string.IsNullOrWhiteSpace(age) ||
                    string.IsNullOrWhiteSpace(birthday))
                {
                    throw new Exception("All fields must be filled out.");
                }

                // textBox data into txt file
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, studentNo + ".txt")))
                {
                    outputFile.WriteLine("Student No.: " + studentNo);
                    outputFile.WriteLine("Full name: " + lastName + ", " + firstName + ", " + middleName);
                    outputFile.WriteLine("Program: " + program);
                    outputFile.WriteLine("Gender: " + gender);
                    outputFile.WriteLine("Age: " + age);
                    outputFile.WriteLine("Birthday: " + birthday);
                    outputFile.WriteLine("Contact No.: " + contactNo);

                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




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

        }

        private void prog_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
