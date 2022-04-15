using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPsystNik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Мужской");
            comboBox1.Items.Add("Женский");

            comboBox2.Items.Add("0");
            comboBox2.Items.Add("0,5");
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("1,5");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add(">2,5");

            comboBox3.Items.Add("0");
            comboBox3.Items.Add("100");
            comboBox3.Items.Add("200");
            comboBox3.Items.Add("300");
            comboBox3.Items.Add("400");
            comboBox3.Items.Add(">500");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;

            if (comboBox1.SelectedIndex == 0)
                sum += 2;

            int rost = Convert.ToInt32(textBox2.Text);
            int ves = Convert.ToInt32(textBox3.Text);
            int IdealVes = rost - 100;
            int diff = ves - IdealVes;
            if (diff >= 10)
                label7.Text = "Превышение веса: " + diff + " кг";
            if (diff >= 10 && diff < 20)
                sum += 1;
            if (diff >= 20 && diff < 30)
                sum += 2;
            if (diff >= 30 && diff < 40)
                sum += 3;
            if (diff >= 40 && diff < 50)
                sum += 4;
            if (diff >= 50 && diff < 60)
                sum += 5;
            if (diff >= 60 && diff < 70)
                sum += 6;
            if (diff >= 70 && diff < 80)
                sum += 7;
            if (diff >= 80 && diff < 90)
                sum += 8;
            if (diff >= 90 && diff < 100)
                sum += 9;
            if (diff >= 100)
                sum += 10;

            if (comboBox3.SelectedIndex == 1)
                sum += 1;
            if (comboBox3.SelectedIndex == 2)
                sum += 2;
            if (comboBox3.SelectedIndex == 3)
                sum += 3;
            if (comboBox3.SelectedIndex == 4)
                sum += 4;
            if (comboBox3.SelectedIndex == 5)
                sum += 5;

            if (comboBox2.SelectedIndex == 1)
                sum += 1;
            if (comboBox2.SelectedIndex == 2)
                sum += 2;
            if (comboBox2.SelectedIndex == 3)
                sum += 3;
            if (comboBox2.SelectedIndex == 4)
                sum += 4;
            if (comboBox2.SelectedIndex == 5)
                sum += 5;


            if (checkBox1.Checked == true)
                sum += 2;
            if (checkBox2.Checked == true)
                sum += 4;
            if (checkBox3.Checked == true)
                sum += 3;
            if (checkBox4.Checked == true)
                sum += 2;
            if (checkBox5.Checked == true)
                sum += 1;
            if (checkBox6.Checked == true)
                sum += 4;
            if (checkBox7.Checked == true)
                sum += 4;
            if (checkBox8.Checked == true)
                sum += 3;
            if (checkBox9.Checked == true)
                sum += 1;
            if (checkBox10.Checked == true)
                sum += 2;
            if (checkBox11.Checked == true)
                sum += 1;

            double k = (double)sum / 49.0 * 100;
            if (k <= 33)
            label12.Text = "Низкая вероятность: " + Math.Round(k, 0) + "%";
            if (k > 33 && k <= 66)
                label12.Text = "Средняя вероятность: " + Math.Round(k, 0) + "%";
            if (k > 66 && k <= 100)
                label12.Text = "Высокая вероятность: " + Math.Round(k, 0) + "%";
        }
    }
}
