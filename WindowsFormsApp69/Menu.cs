using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp69
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Test test1 = new Test();
            this.Hide();
            test1.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            string path = Path.Combine(Application.StartupPath, "EasyMath");
      
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                
            }
            
            path = Path.Combine(Application.StartupPath,"Pictures") ;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

            }


            path = Path.Combine(Application.StartupPath, "EasyMath/config.txt");
            if (!File.Exists(path))
            {

               
            
                using (StreamWriter file = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    file.WriteLine("timemode=1");
                    file.WriteLine("answercheck=1");
                    file.WriteLine("examplesnum=1");
                }

            }
           


        }

        private void label2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            settings.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Help help1 = new Help();
            help1.ShowDialog();
            help1.Close();
        }
    }
    
}
