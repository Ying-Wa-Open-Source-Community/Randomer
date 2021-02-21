using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Randomer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Font = new Font(FontFamily.GenericSansSerif,MainForm.textSize);
            label1.ForeColor = MainForm.fontColor;
            this.BackColor = MainForm.backColor;
        }
    }
}
