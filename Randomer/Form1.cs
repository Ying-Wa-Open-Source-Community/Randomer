using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Randomer
{

    public partial class MainForm : Form
    {

        public static bool numberOrNot = true;
        public static int ranSmall = 0;
        public static int ranBig = 0;
        public static bool ifInfinity = false;
        public static int timesCanBePick = 0;
        public static int textSize = 0;
        public static Color fontColor, backColor;
        public static bool ifFullScreen = false;
        public static string[] items;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontColor = Color.FromName("White");
            backColor = Color.FromName("White");
            pictureBox1.BackColor = Color.FromName("White");
            pictureBox2.BackColor = Color.FromName("White");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void File_Opening(object sender, CancelEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!radioButton2.Checked)
            {
                editItems.Enabled = false;
                numberOrNot = true;
                ranSmall = Convert.ToInt32(numericUpDown1.Value);
                ranBig = Convert.ToInt32(numericUpDown2.Value);
            }
            else
            {
                editItems.Enabled = true;
                numberOrNot = false;
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!radioButton1.Checked)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numberOrNot = false;
            }
            else
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                numberOrNot = true;
                ranSmall = Convert.ToInt32(numericUpDown1.Value);
                ranBig = Convert.ToInt32(numericUpDown2.Value);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown3.Enabled = false;
                ifInfinity = true;
            }
            else
            {
                numericUpDown3.Enabled = true;
                ifInfinity = false;
                timesCanBePick = Convert.ToInt32(numericUpDown3.Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
                fontColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = colorDialog1.Color;
                backColor = colorDialog1.Color;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                ifFullScreen = true;
            }
            else
            {
                ifFullScreen = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textSize = Convert.ToInt32(numericUpDown4.Value * 8 * 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textSize = Convert.ToInt32(numericUpDown4.Value * 8 * 2);

        }

        private void editItems_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            
            var result = f2.ShowDialog();
            if (result == DialogResult.OK)
            {
                items = Form2.text;
                f2.Close();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            textSize = Convert.ToInt32(numericUpDown4.Value * 8 * 2);

        }
    }
}
