using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dream_Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool move;
        int MoveX, MoveY;

        private void loginPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - MoveX, MousePosition.Y - MoveY);
            }
        }

        private void loginPanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void loginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginMinimze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            MoveX = e.X;
            MoveY = e.Y;
        }
    }
}
