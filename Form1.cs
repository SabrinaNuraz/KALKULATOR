﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Nilai 1 dan 2 harus di isi terlebih dahulu");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a * b;
                this.lblHasil.Text = c.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Nilai 1 dan 2 harus di isi terlebih dahulu");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a + b;
                this.lblHasil.Text = c.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lblHasil.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Nilai 1 dan 2 harus di isi terlebih dahulu");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a - b;
                this.lblHasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Nilai 1 dan 2 harus di isi terlebih dahulu");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a / b;
                this.lblHasil.Text = c.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHasil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
