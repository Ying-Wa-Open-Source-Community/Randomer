using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Randomer
{
    public partial class Form2 : Form
    {
        public static string[] text;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text.Split("\r\n");
            label3.Text = text.Length.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text.Split("\r\n");
            this.DialogResult = DialogResult.OK;
        }
    }
}
