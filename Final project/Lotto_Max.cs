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
namespace Final_project
{
    public partial class Lotto_Max : Form
    {
        public Lotto_Max()
        {
            InitializeComponent();
        }

        string dir = @"C:\P27\Files\";

        private void Lotto_Max_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string winning_no = "";
            try
            {
                int random_number = 0;
                Random random = new Random();
                int[] Lottery = new int[8];
                string newLine = Environment.NewLine;

                for (int i = 0; i < 8; i++)
                {
                    random_number = random.Next(1, 49);
                    Lottery[i] = random_number;
                    winning_no = winning_no + random_number + ", ";
                }
                winning_num.Text +=  winning_no+newLine  ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                winning_num.Text = " ";
            }
            finally
            { winning_num.Focus(); }
            //*******  wrting the file *******//
            string path = dir + "Lotto_max.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            if (winning_num.Text.Trim() == "")
            {
                MessageBox.Show("generated_amount is a required field.");
            }
            else
            {
                try
                {
                    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    DateTime currentdate = DateTime.Now;
                    textOut = new StreamWriter(fs);
                    textOut.WriteLine(" Max , " + currentdate + " " + winning_no);
                }
                catch (IOException ex)
                { 
                    MessageBox.Show(ex.Message, "IOException");
                }
                finally
                {
                    if (textOut != null) { textOut.Close(); }
                    if (fs != null) { fs.Close(); }
                }
            }
        }
      //********** Reading The File ***********//
        private void Readfile_Click_1(object sender, EventArgs e)
        {
            string path = dir + "Lotto_max.txt";
            DateTime currentdate = DateTime.Now;
            if (File.Exists(path))
            {
                FileStream fs;
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string row = textIn.ReadToEnd();
                MessageBox.Show(row, "Winning Numbers");
                textIn.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("file is not selected!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want \n to quit the Application?", "Exit?", MessageBoxButtons.YesNo);
            this.Close();
        }

       
    }
}
