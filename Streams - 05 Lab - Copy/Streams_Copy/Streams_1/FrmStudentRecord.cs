using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streams_1
{
    public partial class FrmStudentRecord : Form
    {
        private List<StudentInfoClass> studentRecords = new List<StudentInfoClass>();
        private string recoPath = @"C:\Users\Red\Desktop\School\3rd year\1st sem\Event-Driven Programming\Stream Records";
        public FrmStudentRecord()
        {
            InitializeComponent();
        }


        // REGISTER
        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            this.Hide();
            frmRegistration.Show();
        }

        // FIND
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\Red\Desktop\School\3rd year\1st sem\Event-Driven Programming\Stream Records";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        listView1.Items.Add(_getText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // UPLOAD
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (var student in studentRecords)
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(recoPath, student.studentNo + ".txt")))
                    {
                        outputFile.WriteLine("Student No.: " + student.studentNo);
                        outputFile.WriteLine("Full name: " + student.lastName + ", " + student.firstName + ", " + student.middleName + ".");
                        outputFile.WriteLine("Program: " + student.program);
                        outputFile.WriteLine("Gender: " + student.gender);
                        outputFile.WriteLine("Age: " + student.age);
                        outputFile.WriteLine("Birthday: " + student.birthday);
                        outputFile.WriteLine("Contact No.: " + student.contactNo);
                    }
                }

                MessageBox.Show("Successfully Uploaded!", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listView1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
        // add student record and update list view
        public void AddStudentRecord(StudentInfoClass studentInfo)
        {
            studentRecords.Add(studentInfo);
            listView1.Items.Add(new ListViewItem(studentInfo.studentNo));
        }


        // display records from listview
        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {
            LoadTxtFiles();
        }

        // refresh txt files

        public void LoadTxtFiles()
        {
            string recoPath = @"C:\Users\Red\Desktop\School\3rd year\1st sem\Event-Driven Programming\Stream Records";

            try
            {
                string[] txtFiles = Directory.GetFiles(recoPath, "*.txt");

                listView1.Items.Clear();

                foreach (string file in txtFiles)
                {
                    string fileName = Path.GetFileName(file);
                    listView1.Items.Add(new ListViewItem(fileName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
