using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

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

        public ArrayList arr = MainForm.totalItems;

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Space:
                    Pick();
                    break;
                case Keys.F1:
                    Fullscreen();
                    break;
                case Keys.Escape:
                    ExitFS();
                    break;
            }
        }
        private void Pick()
        {
            if(!MainForm.ifInfinite)
            {
                if(arr.Count != 0)
                {
                    Random ran = new Random();
                    int index = (ran.Next(1,arr.Count))-1;
                    string target = arr[index].ToString();
                    arr.RemoveAt(index);
                    label1.Text = target;
                }
                else
                {
                    label1.Text = "End!";
                }
            }
            else
            {
                Random ran = new Random();
                int index = (ran.Next(1, arr.Count)) - 1;
                string target = arr[index].ToString();
                label1.Text = target;
            }
        }
        private void Fullscreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void ExitFS()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            arr.Clear();
        }
    }
}
