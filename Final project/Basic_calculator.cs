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
    public partial class Basic_calculator : Form
    {
        // Starting of class Calc
        bool Final_cal = false; 
        class Calc
        {
            
            decimal currentvalue = 0;
            decimal operand1 = 0;
            decimal operand2 = 0;
            char op = '+';
            decimal displayvalue = 0;
            //applying properties
            public decimal Currentvalue
            {
                get { return currentvalue; }
                set { currentvalue = value; }
            }
            public decimal Operand1
            {
                get { return operand1; }
                set { operand1 = value; }
            }
            public decimal Operand2
            {
                get { return operand2; }
                set { operand2 = value; }
            }
            public decimal Displayvalue
            {
                get { return displayvalue; }
                set { displayvalue = value; }
           }
            public char Op
            {
                get { return op; }
                set { op = value; }
            }

            // applying Mathematical operations
            public void Add()
            {
                operand1 = operand1 + operand2;
                op = '+';
            }
            public void Sub()
            {
                operand1 = operand1 - operand2;
                op = '-';

            }
            public void Mult()
            {
                operand1 = operand1 * operand2;
                op = '*';
            }
            public void Div()
            {
                operand1 = operand1 / operand2;
                op = '/';
            }
            public void Equals()
            {
                switch (op)
                {
                    case '+':
                        Add();
                        break;
                    case '-':
                        Sub();
                        break;
                    case '*':
                        Mult();
                        break;
                    case '/':
                        Div();
                        break;    
                }
            }
        }// end of the class Calc
        Calc cal = new Calc();
        public Basic_calculator()
        {
            InitializeComponent();
        }

        private decimal CurrentValue;
       // private decimal DisplayValue;
        private void btn1_Click(object sender, EventArgs e)
        {
            if (Final_cal)
             txtBox.Text = "1";
            else
            txtBox.Text = txtBox.Text + "1";
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Final_cal)
                txtBox.Text = "2";
            else
            txtBox.Text = txtBox.Text + "2";
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Final_cal)
                txtBox.Text = "3";
            else
            txtBox.Text = txtBox.Text + "3";
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Final_cal)
                txtBox.Text = "4";
            else
            txtBox.Text = txtBox.Text + "4";
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Final_cal)
                txtBox.Text = "5";
            else
            txtBox.Text = txtBox.Text + "5";
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Final_cal)
                txtBox.Text = "6";
            else
            txtBox.Text = txtBox.Text + "6";
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Final_cal)
                txtBox.Text = "7";
            else
            txtBox.Text = txtBox.Text + "7";
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Final_cal)
                txtBox.Text = "8";
            else
            txtBox.Text = txtBox.Text + "8";
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Final_cal)
                txtBox.Text = "9";
            else
            txtBox.Text = txtBox.Text + "9";
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Final_cal)
                txtBox.Text = "0";
            else
            txtBox.Text = txtBox.Text + "0";
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Contains("."))
            {
                txtBox.Text = txtBox.Text;
            }
            else
            {
                txtBox.Text = txtBox.Text + ".";
            }
            Final_cal = false;
            CurrentValue = Convert.ToDecimal(txtBox.Text);
        }
        // creating private void for airthmatical operations
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cal.Operand1 = CurrentValue;
            cal.Op = '+';
            txtBox.Text = " ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            cal.Operand1 = CurrentValue;
            cal.Op = '-';
            txtBox.Text = " ";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            cal.Operand1 = CurrentValue;
            cal.Op = '*';
            txtBox.Text = " ";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            cal.Operand1 = CurrentValue;
            CurrentValue = Math.Round(CurrentValue, 2);
            cal.Op = '/';
           txtBox.Text = " ";
        }
        // creating directory
        string dir = @"C:\c#\Files\";
        private void Basic_calculator_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            Final_cal = true;
            decimal op1;
            cal.Operand2 = CurrentValue;
            op1 = cal.Operand1;
            cal.Equals();
            txtBox.Text = cal.Operand1.ToString();

            //*******  wrting the file *******//
            string path = dir + "Calculator.txt";
            FileStream fs = null;
            StreamWriter textOut = null;
            if (txtBox.Text.Trim() == "")
            {
                MessageBox.Show("calculated value is a required field.");
            }
            else
            {
                try
                {
                    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    textOut = new StreamWriter(fs);
                    textOut.WriteLine(op1 + cal.Op.ToString() + CurrentValue + " = " + cal.Operand1);   
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = " ";
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want \n to quit the Application?", "Exit?", MessageBoxButtons.YesNo);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = dir + "Calculator.txt";
            DateTime currentdate = DateTime.Now;
            if (File.Exists(path))
            {
                FileStream fs;
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string PrintToText = textIn.ReadToEnd();
                MessageBox.Show(PrintToText, "Calculations");
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
