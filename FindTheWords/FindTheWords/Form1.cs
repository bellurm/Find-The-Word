using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTheWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().Contains(textBox1.Text))
                {
                    listBox1.SetSelected(i, true);
                    if (textBox1.Text == "")
                    {
                        listBox1.SetSelected(i, false);
                    }
                    else
                    {
                        listBox1.SetSelected(i, false);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.SelectionStart = textBox2.Text.Length;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString().Contains(textBox2.Text))
                {
                    listBox2.SetSelected(i, true);
                    if (textBox2.Text == "")
                    {
                        listBox2.SetSelected(i, false);
                    }
                    else
                    {
                        listBox2.SetSelected(i, false);
                    }
                }
            }
        }
    }
}
