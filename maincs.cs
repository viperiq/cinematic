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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form LOR = new LOR();
            this.Hide();
            LOR.ShowDialog();
            this.Close();
        }

        
    }
}
