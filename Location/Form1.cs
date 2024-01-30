using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            lbl_move.Location = new Point(lbl_move.Location.X + 25, lbl_move.Location.Y);
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            lbl_move.Location = new Point(lbl_move.Location.X, lbl_move.Location.Y + 25);
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            lbl_move.Location = new Point(lbl_move.Location.X - 25, lbl_move.Location.Y);    
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            lbl_move.Location = new Point(lbl_move.Location.X, lbl_move.Location.Y - 25);

        }
    }
}



