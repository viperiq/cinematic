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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string text = TextBox1.Text + "@" + TextBox2.Text;
            File.WriteAllText("txt.txt", text);
            MessageBox.Show("try now your new USERNAME and PASSWARD");
        }
    }
}
