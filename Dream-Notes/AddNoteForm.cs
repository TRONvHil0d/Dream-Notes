using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Notes
{
    public partial class AddNoteForm : Form
    {
        public Note NewNote { get; private set; }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
            int nleft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse


           );
        public AddNoteForm()
        {
            InitializeComponent();
            titleTextBox.MaxLength = 25;
            contentTextBox.MaxLength = 365;
            contentTextBox.TextChanged += contentTextBox_TextChanged;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            NewNote = new Note
            {
                Title = titleTextBox.Text,
                Content = contentTextBox.Text,
                CreatedAt = DateTime.Now
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void contentTextBox_TextChanged(object sender, EventArgs e)
        {

            label4.Text = $"Character: {contentTextBox.Text.Length} / 365";
        }


        bool move;
        int MoveX, MoveY;

        private void addMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void addPanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            MoveX = e.X;
            MoveY = e.Y;
        }

        private void addPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - MoveX, MousePosition.Y - MoveY);
            }
        }

        private void addPanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void AddNoteForm_Load(object sender, EventArgs e)
        {
            addBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 10, 10));
            label4.Text = "Character: 0 / 365";
        }


        private void addClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
