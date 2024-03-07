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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Ahmet", "Ayşe", "Zeynep" };
            //label1.Text = kisiler[3];

            //int[] sayilar = { 3, 5, 7, 9, 11 };
            //label1.Text = sayilar[3].ToString();

            //double[] sayilar = { 3.5, 7.8, 9.7, 2.5 };
            //label1.Text = sayilar[1].ToString();

            char[] karacter = { 'a', 'b', 'c', 'd', 'e', 'f' };
            label1.Text = karacter[2].ToString();
        }
    }
}
