﻿using System;
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

            //string[] people = { "Ömer", "Ahmet", "Faruk", "Mehmet", "Esma", "Ayşe", "Rüya" };
            //label1.Text = people[4];

            //int[] numbers = { 4, 7, 5, 6, 9, 8, 2, 3 };
            //label1.Text = numbers[5].ToString();

            // Create 5 arrays with decimal values.
            double[] decimalNumbers = { 5.12, 3.24, 7.81, 4.17, 9.16 };
            label1.Text = decimalNumbers[2].ToString();

            // Create 10 arrays using char.
            //char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            //label1.Text = letters[3].ToString();
        }
    }
}
