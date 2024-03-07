using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 32, 21, 45, 78, 90, 44, 52, 63, 79, 20 };
            int amount = 0;
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 4 == 0)
                {
                    listBox1.Items.Add(number);
                    amount++;
                    sum=sum + number;   
                }
            }
            listBox2.Items.Add(amount+ " " +"numbers");
            label1.Text = sum.ToString();
        }
    }
}
