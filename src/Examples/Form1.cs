using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umaaz.User;

namespace Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput;
            if (InputBox.Show("Enter a value", "Enter here: ", "value", out userInput, true) == DialogResult.OK)
            {
                label1.Text = userInput;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] userInput;
            if (InputBox.Show("title", new string[] { "Enter a value 1", "Enter a value 2", "Enter a value 3" }, new string[] { "value", "value", "value"}, out userInput) == DialogResult.OK)
            {
                foreach(string inp in userInput)
                {
                    listBox1.Items.Add(inp);
                }                
            }
        }
    }
}
