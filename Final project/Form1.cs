using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Dashboard_amandeep : Form
    {
        public Dashboard_amandeep()
        {
            InitializeComponent();
        }
        // picture box for Money Exchange
        private void btn_Money_Click(object sender, EventArgs e)
        {
            currency_exchange M1 = new currency_exchange();
            M1.ShowDialog();
        }
        // picture box for Temperature Conversion
        private void btn_Temperature_Click(object sender, EventArgs e)
        {
            Temperature_Conversion T1 = new Temperature_Conversion();
            T1.ShowDialog();
        }
        // picture box for Lotto Max
        private void btn_Lotto_Click_1(object sender, EventArgs e)
        {
            Lotto_Max L1 = new Lotto_Max();
            L1.ShowDialog();
        }
        // picture box for Basic Calculator
        private void btn_Calc_Click(object sender, EventArgs e)
        {
            Basic_calculator B1 = new Basic_calculator();
            B1.ShowDialog();
        }
        //Exit The Application
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want \n to quit the Application?", "Exit?", MessageBoxButtons.YesNo);
            this.Close();
        }

    }
}
