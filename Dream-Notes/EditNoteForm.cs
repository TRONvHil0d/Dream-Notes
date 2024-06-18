using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dream_Notes
{
    public partial class EditNoteForm : Form
    {
        private Note note;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
            int nleft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse


           );
        public EditNoteForm(Note note)
        {
            InitializeComponent();
            editTitleTextBox.MaxLength = 25;
            editContentTextBox.MaxLength = 365;
            this.note = note;
            editTitleTextBox.Text = note.Title;
            editContentTextBox.Text = note.Content;
        }

        private void editClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool move;
        int MoveX, MoveY;

        private void editPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - MoveX, MousePosition.Y - MoveY);
            }
        }

        private void editPanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
            note.Title = editTitleTextBox.Text;
            note.Content = editContentTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditNoteForm_Load(object sender, EventArgs e)
        {
            editBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, editBtn.Width, editBtn.Height, 10, 10));
        }

        private void editPanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            MoveX = e.X;
            MoveY = e.Y;
        }
    }
}
