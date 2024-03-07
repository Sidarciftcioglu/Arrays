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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * string[] cities = { "Mardin", "İstanbul", "Ankara", "Diyarbakır", "Eskişehir" };
             foreach (var city in cities)
             {
                 listBox1.Items.Add(city);
             }
            */

            /*
             * int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    listBox1.Items.Add(number);
                }
            }
            */

            int[] numbers = { 12, 5, 67, 9, 72, 34, 10, 4, 7, 89, 6, 90 };
            foreach (var number in numbers)
            {
                if(number%2==0 && number > 10)
                {
                    listBox1.Items.Add(number);
                }
            }
        }
    }
}
