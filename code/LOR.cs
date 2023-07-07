using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinematic_final_version
{
    public partial class LOR : Form
    {
        public LOR()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string media = "C:\\Users\\Lenovo\\Desktop\\images\\LOR.mp4";
            axWindowsMediaPlayer1.URL = media;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form maincs = new main();
            this.Hide();
            maincs.ShowDialog();
            this.Close();
        }
    }
}
