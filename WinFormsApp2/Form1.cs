using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnConvert_Click_1(object sender, EventArgs e)
        {
            // 1. Input Validation
            if (double.TryParse(txtInput.Text, out double inputTemp))
            {
                double result = 0;
                string unit = "";

                // 2. Logic Branching
                if (rbCtoF.Checked)
                {
                    result = (inputTemp * 9.0 / 5.0) + 32;
                    unit = "°F";
                }
                else if (rbFtoC.Checked)
                {
                    result = (inputTemp - 32) * 5.0 / 9.0;
                    unit = "°C";
                }
                else
                {
                    MessageBox.Show("Please select a conversion type.");
                    return;
                }

                // 3. Display Result
                lblResult.Text = $"Result: {result:0.00} {unit}";
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value.");
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblNum1_Click(object sender, EventArgs e)
        {

        }
    }
}
