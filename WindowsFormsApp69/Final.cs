using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Remoting.Metadata;

namespace WindowsFormsApp69
{
    public partial class Final : Form
    { int ans_buf = 0;
        int numofres = 0;
        bool isAnswer = false;
        bool isend = false;
        Random rand = new Random();
        int results = 0;
        public Final()
        {
            InitializeComponent();
        }
        private async void PreLoad()
        {
            button4.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            label8.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;

            for (int i = 5; i >0; i--)
            {   
                await Task.Delay(1000);
                label3.Text = (i-1).ToString();
            }
            label3.Visible = false;
            if (Test.exampleNum==100) { button4.Visible = true; }
            if (Test.time != 1000)
            {
                label4.Visible = true;
                label1.Visible = true;
            }

            label8.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;
           
        }
        private void AfterLoad()
        {
            label8.Visible = false;
            button4.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
            if (Test.answercheck == true)
            { textBox2.Text += " \r\nИтого:" + results + " из ";
                if (Test.exampleNum == 100) { textBox2.Text += numofres; }
                else
                {
                    textBox2.Text += Test.exampleNum;
                }
               textBox2.Text +=" правильных ответов"; 
            }
        
            button3.Visible = true;
            button1.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
            isend = false;

        }
        private async void Final_Load(object sender, EventArgs e)
        {
            PreLoad();
           await Task.Delay(5000);
            Genesis();
        }

        public async void Genesis()
        {
            results = 0;
            for (int i = 0; i < Test.exampleNum ; i++)
            {
                label1.Text = Test.time.ToString();
                GenerateExample(Test.forder[i].ToString(), Test.norder[i]);
                isAnswer = false;
                
                for (int j = 0; j < Test.time; j++)
                {
                    if(isAnswer)
                    {
                        break;
                    }
                    if(isend)
                    {
                        break;
                    }
                    await Task.Delay(1000);
                    

                        label1.Text = (Int32.Parse(label1.Text) - 1).ToString() ;
                }
                if (isend)
                {
                    numofres = i;
                    break;
                }
                textBox2.Text += textBox1.Text;
                if (Test.answercheck == true)
                {
                    if ((textBox1.Text != "") && (Int32.Parse(textBox1.Text) == ans_buf))
                    {
                        textBox2.Text += "\r\n(Правильно)";
                        results++;
                    }
                    else
                    {
                        textBox2.Text += "\r\n(Неправильно)";
                    }
                }
                    textBox2.Text += "\r\n";
                    textBox1.Text = "";
                    
                

            }
            AfterLoad();
        }
        public int GenerateExample(string pos, int digit)
        {
            /*int func = pos[rand.Next(0, pos.Length)] - '0';

            int digit = 0;
            foreach (Panel panel in Test.Digits.Controls)
            {
                if (panel.Name.Substring(5) == func.ToString())
                {
                    digit = Selected(panel);
                }
            }
            digit = (int)Math.Pow(10, digit);
            */

            int num1 = 0, num2 = 0;
            char funcview = ' ';
            switch (pos)
            {
                case "1":
                    num2 = rand.Next(1, digit);
                    num1 = rand.Next(1, digit);
                    ans_buf = num1 + num2;
                    funcview = '+';
                    break;
                case "2":
                    num2 = rand.Next(1, digit);
                    num1 = rand.Next(num2, digit);
                    ans_buf = num1 - num2;
                    funcview = '-';
                    break;
                case "3":
                    num2 = rand.Next(1, digit);
                    num1 = rand.Next(1, digit);
                    ans_buf = num1 * num2;
                    funcview = '*';
                    break;
                case "4":
                    num2 = rand.Next(1, digit / 2);
                    ans_buf = rand.Next(2, ((digit / num2) + 1));
                    num1 = num2 * ans_buf;
                    funcview = ':';
                    break;
            }

            label2.Text = num1.ToString() + " " + funcview + " " + num2.ToString();

            if (isend == false)
            {
                textBox2.Text += num1.ToString() + " " + funcview + " " + num2.ToString() + " = " + ans_buf.ToString();
                if (Test.answercheck == true) { textBox2.Text += " Ваш ответ:"; }
            }

            return 0;
      }

        private void button2_Click(object sender, EventArgs e)
        {

            isAnswer = true;
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)|| (e.KeyChar==(char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Final_Load(sender, e);
            label3.Visible = true;
            label3.Text = "5";
        }

        private void Final_FormClosed(object sender, FormClosedEventArgs e)
        {
            Test.forder = "";
            for(int i=0;i<Test.exampleNum;i++)
            {
                Test.norder[i] = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isend = true;
        }
    }
}
