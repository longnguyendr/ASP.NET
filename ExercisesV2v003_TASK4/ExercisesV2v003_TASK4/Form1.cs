using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisesV2v003_TASK4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Enabled = false;
        }

        List<string> listname = new List<string>{
                "Darlena", "Gary", "Lizeth", "Eldridge", "Ethan", "Bethany",
                "Saul","Tesha","Caprice","Carleen","Stormy","Rodger",
                "Willie","Irina", "Reynalda","Arvilla","Sherri","Kris"
            };
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = string.Join(", ", listname.ToArray());
            //richTextBox1.Text = string.Join(Environment.NewLine, listname.ToArray());
            //richTextBox1.Lines = listname.ToArray();
            int result = Convert.ToInt32(listname.Count());
            textBox1.Text = result.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var AlphabetOrder = from s in listname
                                orderby s
                                select s.ToString();

            richTextBox1.Text = string.Join(", ", AlphabetOrder);
            int result = Convert.ToInt32(AlphabetOrder.Count());
            textBox1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var letters = from s in listname
                          where s.Length < 5
                          orderby s
                          select s.ToString();

            richTextBox1.Text = string.Join(", ", letters);
            int result = Convert.ToInt32(letters.Count());
            textBox1.Text = result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
