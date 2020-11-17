using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp69
{
    public partial class Test : Form
    {
        Random rand = new Random();
        public Test()
        {
            InitializeComponent();

        }
        /* int Generate(int func, int func_pos)
         {
         int num1=rand.Next()// 10^(n-1) to 10^n-1
                 // return num1 num2 function and answer that should be hiden until round doesnt ends
                 //it returns to textbox for example.
                 //further make a game .The end
             return 0;
         }*/
        public class position
        {
            private string pos;
            public void Set_pos(string posIn)
            {
                pos = posIn;
                return;
            }
            public string Get_pos()
            {
                return pos;
            }
        }
        position posA = new position();
        
        public static string forder = "";
        public static int[] norder = new int[100];
        private  void button1_Click(object sender, EventArgs e)
        {
            string pos = "";

            foreach (Panel panel in Digits.Controls)
            {
                if (panel.Visible == true && (Selected(panel)) != 0)
                {
                    pos += panel.Name.Substring(5);
                }
            }

            if (pos == "")
            {
                return;
            }
            posA.Set_pos(pos);


            for (int i = 0; i < exampleNum;i++)
            {
                forder += posA.Get_pos()[rand.Next(0, (posA.Get_pos()).Length)];
                foreach (Panel panel in Digits.Controls)
                {
                    if (panel.Name.Substring(5) == forder[i].ToString())
                    {
                        norder[i] = Selected(panel);
                    }
                }
                norder[i]= (int)Math.Pow(10, norder[i]);
               
            }
            
            Final final = new Final();
            this.Hide();
            final.ShowDialog();
            final.Close();
            this.Show();
            
            
            
           
        }
        
        /*
        public async void Genesis()
        {
            for (int i = 0; i < exampleNum - 1; i++)
            {
                label1.Text = time.ToString();
                for (int j = 0; j < time; j++)
                {
                    
                        await Task.Delay(1000);
                        if (!iscanceled)
                        {

                            label1.Text = (Int32.Parse(label1.Text) - 1).ToString();
                        }
                        
                    
                }
                GenerateExample(posA.Get_pos());

            }
        }
        public int GenerateExample(string pos)
        {
            int func = pos[rand.Next(0, pos.Length)] - '0';

            int digit = 0;
            foreach (Panel panel in Digits.Controls)
            {
                if (panel.Name.Substring(5) == func.ToString())
                {
                    digit = Selected(panel);
                }
            }
            digit = (int)Math.Pow(10, digit);


            int num1 = 0, num2 = 0;
            char funcview = ' ';
            switch (func)
            {
                case 1:
                    num2 = rand.Next(1, digit);
                    num1 = rand.Next(1, digit);
                    ans_buf = num1 + num2;
                    funcview = '+';
                    break;
                case 2:
                    num2 = rand.Next(1, digit);
                    num1 = rand.Next(num2, digit);
                    ans_buf = num1 - num2;
                    funcview = '-';
                    break;
                case 3:
                    num2 = rand.Next(1, digit);
                    num1 = rand.Next(1, digit);
                    ans_buf = num1 * num2;
                    funcview = '*';
                    break;
                case 4:
                    num2 = rand.Next(1, digit / 2);
                    ans_buf = rand.Next(2, ((digit / num2) + 1));
                    num1 = num2 * ans_buf;
                    funcview = '/';
                    break;
            }

            label2.Text = num1.ToString() + " " + funcview + " " + num2.ToString();



            return 0;
        }
        */
        private int Selected(Panel panel)
        {
            foreach (RadioButton radio in panel.Controls)
            {

                if (radio.Checked == true)
                { return Int32.Parse(radio.Text); }

            }
            return 0;
        }

        private void Plus_Click(object sender, EventArgs e)
        {

            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                

            }
            else
            { panel1.Visible = false; }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;

            }
            else
            { panel2.Visible = false; }
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel3.Visible = true;

            }
            else
            { panel3.Visible = false; }
        }
        private void Div_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;

            }
            else
            { panel4.Visible = false; }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            settings.Close();
        }


        public static int time = 0;
        public static bool answercheck = true;
        public static int exampleNum = 10;
        private void Test_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            panel5.BackColor = System.Drawing.Color.Transparent;
            Digits.BackColor = System.Drawing.Color.Transparent;

            string path = Path.Combine(Application.StartupPath, "EasyMath/config.txt");
            using (FileStream fileToRead = new FileStream(path, FileMode.Open))
            using (StreamReader file = new StreamReader(fileToRead))
            {
                switch (file.ReadLine().Substring(9))
                {
                    case "1":
                        {
                            time = 1000;
                            break;
                        }
                    case "2":
                        {
                            time = 5;
                            break;
                        }
                    case "3":
                        {
                            time = 10;
                            break;
                        }
                    case "4":
                        {
                            time = 20;
                            break;
                        }
                    case "5":
                        {
                            time = 30;
                            break;
                        }
                    case "6":
                        {
                            time = 60;
                            break;
                        }
                }
                if (file.ReadLine().Substring(12) == "1")
                {
                    answercheck = true;
                }
                else { answercheck = false; }

                switch (file.ReadLine().Substring(12))
                {
                    case "1":
                        {
                            exampleNum = 100;
                            break;
                        }
                    case "2":
                        {
                            exampleNum = 10;
                            break;
                        }
                    case "3":
                        {
                            exampleNum = 20;
                            break;
                        }

                }

            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
