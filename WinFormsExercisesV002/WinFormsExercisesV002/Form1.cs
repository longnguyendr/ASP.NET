using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsExercisesV002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       // Add button
        private void button1_Click(object sender, EventArgs e)
        {
            Input();
            showResult(firstnum + secondnum);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        // subtract button
        private void button2_Click(object sender, EventArgs e)
        {
            Input();
            showResult(firstnum - secondnum);
        }
        // multiplication button 
        private void button3_Click(object sender, EventArgs e)
        {
            Input();
            showResult(firstnum * secondnum);
        }
        //division button
        private void button4_Click(object sender, EventArgs e)
        {
            Input();
            showResult(firstnum / secondnum);
        }
        double firstnum;
        double secondnum;

        public void Input()
        {
            firstnum = Convert.ToDouble(textBox1.Text);
            secondnum = Convert.ToDouble(textBox2.Text);
        } 
        private void showResult(double results)
        {
            textBox3.Text = results.ToString();
        }
    }
}
