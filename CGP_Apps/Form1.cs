using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGP_Apps
{
    public partial class CGP_UI : Form
    {
       
        public CGP_UI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Result();
        }

        private void enterMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Result();
            }
          
        }
        public void Result()
        {
            try
            {
                if (enterMarkTextBox.Text == String.Empty)
                {
                    resultLabel.Text = String.Empty;
                    enterMarkTextBox.BackColor = Color.Red;
                    MessageBox.Show("Enter mark");
                    enterMarkTextBox.BackColor = Color.White;
                }
                else
                {
                    enterMarkTextBox.BackColor = Color.White;
                    double mark = double.Parse(enterMarkTextBox.Text);

                    if (mark>=0 && mark < 40)
                    {
                        resultLabel.ForeColor = Color.Red;
                        resultLabel.Text = "F";


                    }
                    else if (mark == 40)
                    {
                        resultLabel.ForeColor = Color.Green;
                        resultLabel.Text = "D";
                    }
                    else if (mark > 40 && mark <= 50)
                    {
                        resultLabel.ForeColor = Color.Green;
                        resultLabel.Text = "B";
                    }
                    else if (mark > 50 && mark <= 60)
                    {
                        resultLabel.ForeColor = Color.Green;
                        resultLabel.Text = "B+";
                    }
                    else if (mark > 60 && mark <= 70)
                    {
                        resultLabel.ForeColor = Color.Green;
                        resultLabel.Text = "A-";
                    }
                    else if (mark > 70 && mark <= 80)
                    {
                        resultLabel.ForeColor = Color.Green;
                        resultLabel.Text = "A";
                    }
                    else if (mark > 80 && mark <= 100)
                    {
                        resultLabel.ForeColor = Color.Green;
                        resultLabel.Text = "A+";
                    }
                    else if (mark > 100|| mark<0)
                    {
                        enterMarkTextBox.BackColor = Color.Red;
                        resultLabel.ForeColor = Color.Red;
                        resultLabel.Text = "Invalid Data!!!!!";
                        MessageBox.Show("Enter marks between 0 to 100");
                        enterMarkTextBox.BackColor = Color.White;
                        enterMarkTextBox.Text = String.Empty;
                        resultLabel.Text = String.Empty;
                    }

                }
            }
            catch (Exception error)
            {
                enterMarkTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter valid Data");
                enterMarkTextBox.Text = String.Empty;
                enterMarkTextBox.BackColor = Color.White;
            }

        }

        private void CGP_UI_Load(object sender, EventArgs e)
        {

        }

     

       
    }
}
