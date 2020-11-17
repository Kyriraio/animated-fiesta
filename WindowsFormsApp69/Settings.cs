using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp69
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        private string SelectedMode(Panel panel)
        {
            foreach (RadioButton radio in panel.Controls)
            {

                if (radio.Checked == true)
                { return radio.Name; }

            }
            return "";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "EasyMath/config.txt");


            File.Delete(path);
            using (StreamWriter file = new StreamWriter(path, true, System.Text.Encoding.Default))
            {

                switch (SelectedMode(Time))
                {
                    case "radioButton1":
                        file.WriteLine("timemode=1");
                        Test.time = 1000;
                        break;
                    case "radioButton2":
                        file.WriteLine("timemode=2");
                        Test.time = 5;
                        break;
                    case "radioButton3":
                        file.WriteLine("timemode=3");
                        Test.time = 10;
                        break;
                    case "radioButton4":
                        file.WriteLine("timemode=4");
                        Test.time = 20;
                        break;
                    case "radioButton5":
                        file.WriteLine("timemode=5");
                        Test.time = 30;
                        break;
                    case "radioButton6":
                        file.WriteLine("timemode=6");
                        Test.time = 60;
                        break;

                }
                switch (SelectedMode(AnswerCheck))
                {
                    case "radioButtonYes":
                        {
                            file.WriteLine("answercheck=1");
                            Test.answercheck = true;
                            break;
                        }
                    case "radioButtonNo":
                        {
                            file.WriteLine("answercheck=0");
                            Test.answercheck = false;
                            break;
                        }
                }
                switch (SelectedMode(ExamplesNum))
                {
                    case "radioButtonENinf":
                        {
                            file.WriteLine("examplesnum=1");
                            Test.exampleNum = 100;
                            break;
                        }
                    case "radioButtonEN10":
                        {
                            file.WriteLine("examplesnum=2");
                            Test.exampleNum = 10;
                            break;
                        }
                    case "radioButtonEN20":
                        {
                            file.WriteLine("examplesnum=3");
                            Test.exampleNum = 20;
                            break;
                        }
                }
                
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;

            string path = Path.Combine(Application.StartupPath, "EasyMath/config.txt");
            using (FileStream fileToRead = new FileStream(path, FileMode.Open))
            using (StreamReader file = new StreamReader(fileToRead))
            {
                switch (file.ReadLine().Substring(9))
                {
                    case "1":
                        {
                            radioButton1.Checked = true;
                            break;
                        }
                    case "2":
                        {
                            radioButton2.Checked = true;
                            break;
                        }
                    case "3":
                        {
                            radioButton3.Checked = true;
                            break;
                        }
                    case "4":
                        {
                            radioButton4.Checked = true;
                            break;
                        }
                    case "5":
                        {
                            radioButton5.Checked = true;
                            break;
                        }
                    case "6":
                        {
                            radioButton6.Checked = true;
                            break;
                        }
                }

                if (file.ReadLine().Substring(12) == "1")
                {
                    radioButtonYes.Checked = true;
                }
                else
                { radioButtonNo.Checked = true; }
                switch (file.ReadLine().Substring(12))
                {
                    case "1":
                        {
                            radioButtonENinf.Checked = true;
                            break;
                        }
                    case "2":
                        {
                            radioButtonEN10.Checked = true;
                            break;
                        }
                    case "3":
                        {
                            radioButtonEN20.Checked = true;
                            break;
                        }
                    
                   
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
