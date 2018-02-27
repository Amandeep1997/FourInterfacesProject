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
    public partial class Temperature_Conversion : Form
    {
        public Temperature_Conversion()
        {
            InitializeComponent();
        }

        string dir = @"C:\AK47\Files\";
        private void Temperature_Conversion_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }  

        private void Convrt_btn_Click(object sender, EventArgs e)
        {
            // conversions from CToF
            try
            {
                double given_Temp; double calculated_Temp;
                given_Temp = double.Parse(txt_from.Text);

                if (CToF_btn.Checked)
                {
                    calculated_Temp = (given_Temp * 9 / 5) + 32;
                    txt_To.Text = calculated_Temp.ToString();
                    Math.Round(calculated_Temp, 2);

                    // displaying messages
                    double txtBox2 = Convert.ToDouble(txt_To.Text);
                    string Message = "";
                    if (txtBox2 == 212)
                    {
                        Message = " Water boils ";
                    }
                    else if (txtBox2 == 104) 
                    {
                        Message = " Hot Bath ";
                    }
                    else if (txtBox2 == 98.6) 
                    {
                        Message = " Body temperature ";
                    }
                    else if (txtBox2 == 86) 
                    {
                        Message = " Beach weather ";
                    }
                    else if (txtBox2 == 70) 
                    {
                        Message = " Room temperature ";
                    }
                    else if (txtBox2 == 50) 
                    {
                        Message = " Cool Day ";
                    }
                    else if (txtBox2 == 32)
                    {
                        Message = " Freezing point of water ";
                    }
                    else if (txtBox2 == 0) 
                    {
                        Message = " Very Cold Day ";
                    }
                    else if (txtBox2 == -40)
                    {
                        Message = " Extremely Cold Day  ";
                    }
                    
                    txtMessagebox.Text = Message;
                }


            // conversions from FToC
                else if (FToC_btn.Checked)
                {
                    calculated_Temp = (given_Temp - 32) * 5 / 9;
                    calculated_Temp = Math.Round(calculated_Temp, 2);
                    txt_To.Text = calculated_Temp.ToString();
                    
                    
                    // displaying message
                    double txtBox2 = Convert.ToDouble(txt_To.Text);
                    string Message = "";
                   
                    if (txtBox2 == 100)
                    {
                        Message = " Water boils ";
                    }
                    else if (txtBox2 == 40)
                    {
                        Message = " Hot Bath ";
                    }
                    else if (txtBox2 == 37) 
                    {
                        Message = " Body temperature ";
                    }
                    else if (txtBox2 == 30) 
                    {
                        Message = " Beach weather ";
                    }
                    else if (txtBox2 == 21) 
                    {
                        Message = " Room temperature ";
                    }
                    else if (txtBox2 == 10)
                    {
                        Message = " Cool Day ";
                    }
                    else if (txtBox2 == 0) 
                    {
                        Message = " Freezing point of water ";
                    }
                    else if (txtBox2 == -18) 
                    {
                        Message = " Very Cold Day ";
                    }
                    else if (txtBox2 == -40)
                    {
                        Message = " Extremely Cold Day  ";
                    }
                    txtMessagebox.Text = Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                txt_from.Text =  " "; 
            }
            finally 
            { txt_from.Focus(); }
          
            // creating text file
            string path = dir + "temperature.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            if (txt_from.Text.Trim() == "")
            {
                MessageBox.Show("temperature is a required field.");
            }
            else
            {
                try
                {
                    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    DateTime currentdate = DateTime.Now;
                    textOut = new StreamWriter(fs);
                    if (CToF_btn.Checked)
                    {
                        textOut.Write(txt_from.Text + " C ");
                        textOut.WriteLine( " = " + txt_To.Text + " F "+ currentdate);
                    }
                    else 
                    {
                        textOut.Write(txt_from.Text + " F ");
                        textOut.WriteLine(" = " + txt_To.Text + " C " + currentdate);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "IOException");
                }
                finally
                {
                    // close the output stream for the text file
                    if (textOut != null)
                    {
                        textOut.Close();
                    }
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }

            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtMessagebox.Text = "";
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want \n to quit the Application?", "Exit?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            this.Close();
        }

        private void CToF_btn_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "C";
            label4.Text = "F";
            txt_To.Text = " ";
            txt_from.Text = " ";
        }

        private void FToC_btn_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "F";
            label4.Text = "C";
            txt_To.Text = " ";
            txt_from.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string path = dir + "temperature.txt";
            DateTime currentdate = DateTime.Now;
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string text_to_print = textIn.ReadToEnd();
                MessageBox.Show(text_to_print, "Conversion");

                textIn.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("file is not selected!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

     }
}

     
    

