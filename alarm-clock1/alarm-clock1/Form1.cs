﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm_clock1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Timer timer1 = new Timer();
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer("D:\\Dram.wav");
        bool b = false;


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = maskedTextBox1.Text;
            timer2.Start();
            maskedTextBox1.Visible = false;
            button1.Text = "Остановить";
            b = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp.Stop();
            button2.Enabled = false;
            maskedTextBox1.Visible = true;
            button1.Text = "Завести";
            b = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == label2.Text + ":00")
            {
                button2.Enabled = true;
                sp.Play();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                label2.Text = "00:00";
                timer2.Stop();
                maskedTextBox1.Visible = true;
                button1.Text = "Завести";
                b = false;
            }
        }
    }
}

