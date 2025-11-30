using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALULATOR
{
    public partial class Form1 : Form
    {
        private string currentcalculation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnButton1(object sender, EventArgs e)
        {
            currentcalculation += (sender as Button).Text;
            txtOuput.Text = currentcalculation;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOuput.Text = "0";
            currentcalculation = "0";
        }

        private void txtOuput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (currentcalculation.Length > 0) ;
            {
                currentcalculation = currentcalculation.Remove(currentcalculation.Length - 1, 1);

            }
            txtOuput.Text = currentcalculation;
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentcalculation.ToString();
            try
            {
                txtOuput.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentcalculation = txtOuput.Text;
                currentcalculation = "";
            } 
            catch(Exception ex)
            {
                txtOuput.Text = "ERROE";
                currentcalculation = "";
            }
            
        }

        private void Calulator(object sender, EventArgs e)
        {

        }

        private void Calculator(object sender, EventArgs e)
        {

        }
    }
}
