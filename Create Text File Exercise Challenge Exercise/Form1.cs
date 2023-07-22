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
using System.Diagnostics;

namespace Create_Text_File_Exercise_Challenge_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/mm/dd";







            TextWriter txt = new StreamWriter("D:\\NAME.txt");
            txt.WriteLine("Student No. :" + textBox1.Text);
            txt.WriteLine("Full Name: " + textBox2.Text +", "+ textBox4.Text +", "+textBox5.Text);
            txt.WriteLine("Program: " + comboBox1.Text);
            txt.WriteLine("Gender: " + comboBox2.Text);
            txt.WriteLine("Age: " + textBox3.Text);

          
            txt.WriteLine("Birthday: " + dateTimePicker1.Text);
          
            txt.WriteLine("Contact: " + textBox6.Text);

            txt.Close();


            Process.Start("200073037.txt");
        }
    }
}
