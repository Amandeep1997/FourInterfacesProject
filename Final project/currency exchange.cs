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
    public partial class currency_exchange : Form
    {
        public currency_exchange()
        {
            InitializeComponent();
        }

        string dir = @"C:\P25\Files\";
        private void currency_exchange_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);
        }

        private void convrt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int final_amount;
                int enter_amount;
                enter_amount = Convert.ToInt32(textBox1.Text);
           
                if ((CAN_FROM.Checked) && (CAN_TO.Checked))
                {
                    final_amount = Convert.ToInt32(enter_amount * 1);   
                    textBox2.Text = final_amount.ToString();
                }

                else if ((CAN_FROM.Checked) && (USD_TO.Checked))
                {
                    final_amount =Convert.ToInt32( enter_amount * 0.766724);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((CAN_FROM.Checked) && (EUR_TO.Checked))
                {
                    final_amount = Convert.ToInt32(enter_amount * 0.69);
                    textBox2.Text = final_amount.ToString();
                }
                else if ((CAN_FROM.Checked) && (GBP_TO.Checked))
                {
                    final_amount =Convert.ToInt32( enter_amount * 0.58);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((USD_FROM.Checked) && (USD_TO.Checked))
                {
                    final_amount = Convert.ToInt32(enter_amount * 1);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((USD_FROM.Checked) && (CAN_TO.Checked))
                {
                    final_amount =Convert.ToInt32( enter_amount * 1.30425);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((USD_FROM.Checked) && (EUR_TO.Checked))
                {
                    final_amount = Convert.ToInt32(enter_amount * 0.90);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((USD_FROM.Checked) && (GBP_TO.Checked))
                {
                    final_amount = Convert.ToInt32(enter_amount * 0.76);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((EUR_FROM.Checked) && (EUR_TO.Checked))
                {
                    final_amount =Convert.ToInt32(enter_amount * 1);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((EUR_FROM.Checked) && (CAN_TO.Checked))
                {
                    final_amount =Convert.ToInt32( enter_amount * 1.44);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((EUR_FROM.Checked) && (USD_TO.Checked))
                {
                    final_amount = Convert.ToInt32(enter_amount * 1.11);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((EUR_FROM.Checked) && (GBP_TO.Checked))
                {
                    final_amount =Convert.ToInt32( enter_amount * 0.84);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((GBP_FROM.Checked) && (GBP_TO.Checked))
                {
                    final_amount =Convert.ToInt32( enter_amount * 1);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((GBP_FROM.Checked) && (CAN_TO.Checked))
                {
                    final_amount = Convert.ToInt32(enter_amount * 1.72);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((GBP_FROM.Checked) && (USD_TO.Checked))
                {
                    final_amount = Convert.ToInt32(enter_amount * 1.31);
                    textBox2.Text = final_amount.ToString();
                }

                else if ((GBP_FROM.Checked) && (EUR_TO.Checked))
                {
                    final_amount = Convert.ToInt32( enter_amount * 1.19);
                    textBox2.Text = final_amount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                textBox2.Text =  " "; 
            }
            finally 
            { textBox2.Focus(); }
                // creating text file
                
            string path = dir + "Moneyconversion.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Enteramount is a required field.");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Finalamount is a required field.");
            }
            else
            {
                try
                {
                    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    DateTime currentdatetime = DateTime.Now;
                    textOut = new StreamWriter(fs);

                     if ((CAN_FROM.Checked) && (CAN_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "$CAN =" + textBox2.Text + " $CAN ," + currentdatetime); }
                   
                     else if ((CAN_FROM.Checked) && (USD_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "$CAN =" + textBox2.Text + "$USD ," + currentdatetime); }
                    
                     else if ((CAN_FROM.Checked) && (EUR_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "$CAN =" + textBox2.Text + "EUR ," + currentdatetime); }

                    else if ((CAN_FROM.Checked) && (GBP_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "$CAN =" + textBox2.Text + "GBP ," + currentdatetime); }

                    else if ((USD_FROM.Checked) && (USD_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "$USD =" + textBox2.Text + "$USD ," + currentdatetime); }

                    else if ((USD_FROM.Checked) && (CAN_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "$USD =" + textBox2.Text + "$CAN ," + currentdatetime); }

                    else if ((USD_FROM.Checked) && (EUR_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "$USD =" + textBox2.Text + "EUR ," + currentdatetime); }

                    else if ((USD_FROM.Checked) && (GBP_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "$USD =" + textBox2.Text + "GBP ," + currentdatetime); }
               
                    else if ((EUR_FROM.Checked) && (EUR_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "EUR =" + textBox2.Text + "EUR ," + currentdatetime); }

                    else if ((EUR_FROM.Checked) && (CAN_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "EUR =" + textBox2.Text + "$CAN ," + currentdatetime); }
              
                    else if ((EUR_FROM.Checked) && (USD_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "EUR =" + textBox2.Text + "$USD ," + currentdatetime); }
                
                    else if ((EUR_FROM.Checked) && (GBP_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "EUR =" + textBox2.Text + "GBP ," + currentdatetime); }
              
                    else if ((GBP_FROM.Checked) && (GBP_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "GBP =" + textBox2.Text + "GBP ," + currentdatetime); }
             
                    else if ((GBP_FROM.Checked) && (CAN_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "GBP =" + textBox2.Text + "$CAN ," + currentdatetime); }
              
                    else if ((GBP_FROM.Checked) && (USD_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "GBP =" + textBox2.Text + "$USD ," + currentdatetime); }
             
                    else if ((GBP_FROM.Checked) && (EUR_TO.Checked))
                     { textOut.WriteLine(textBox1.Text + "GBP =" + textBox2.Text + "EUR ," + currentdatetime); }
             
                }  
                catch (IOException ex)
                { MessageBox.Show(ex.Message, "IOException"); }

                finally
                {
                    // close the output stream for the text file
                    if (textOut != null) { textOut.Close(); }
                    if (fs != null) { fs.Close(); }
                }
              }
           }
        private void Readfile_btn_Click(object sender, EventArgs e)
        {
            string path = dir + "Moneyconversion.txt";
            DateTime currentdatetime = DateTime.Now;
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = textIn.ReadToEnd();
                MessageBox.Show(textToPrint, "Moneyconversion");
                textIn.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("file is not selected!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want \n to quit the Application?", "Exit?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            this.Close();
        }
    }
}
