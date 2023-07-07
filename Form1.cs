using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinematic_final_version
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string filePath = "txt.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("the file doesn't exists", "error");
                return;
            }

            string txt = File.ReadAllText(filePath);
            string[] str = txt.Split('@');

                string UN = str[0]; //username

                string PW = str[1]; //password


            if (guna2TextBox1.Text == UN && guna2TextBox2.Text == PW)
            { 
                    Form maincs = new main();
                    this.Hide();
                    maincs.ShowDialog();
                    this.Close(); 
            }
            else
                MessageBox.Show("the email or the password is not corect try again", "ERROR");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form register = new register();
            register.ShowDialog();
        }
    }

}//"the email or the password is not corect try again", "ERROR"
