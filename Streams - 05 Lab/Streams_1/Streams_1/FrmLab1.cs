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
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        // create
        private void button1_Click(object sender, EventArgs e)
        {
            frmFileName frmFileName = new frmFileName();
            frmFileName.ShowDialog();

            string getInput = txtInput.Text + " .txt";
            string myPath = @"C:\Users\Red\Desktop\School\3rd year\1st sem\Event-Driven Programming";

            
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(myPath, frmFileName.SetFileName + ".txt")))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
