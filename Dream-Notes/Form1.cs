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
    public partial class Form1 : Form
    {
        private List<Note> notes = new List<Note>();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
             int nleft,
             int nTop,
             int nRight,
             int nBottom,
             int nWidthEllipse,
             int nHeightEllipse


            );
        
        
        public Form1()
        {
            InitializeComponent();
            LoadNotes();
            DisplayNotes();
        }

        private void LoadNotes()
        {
            notes = NoteStorage.LoadNotes();
        }

        private void SaveNotes()
        {
            NoteStorage.SaveNotes(notes);
        }

        private void DisplayNotes()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var note in notes)
            {
                Panel notePanel = CreateNotePanel(note);
                flowLayoutPanel1.Controls.Add(notePanel);
            }
        }
        private Panel CreateNotePanel(Note note)
        {
            Panel notePanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Width = 530,
                Height = 150,
                Margin = new Padding(10)
            };

            Label titleLabel = new Label
            {
                Text = note.Title,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.GhostWhite,
                Dock = DockStyle.Top,
                Height = 25
            };

            Label contentLabel = new Label
            {
                Text = note.Content,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Regular),
                ForeColor = Color.White,
                MaximumSize = new Size(480, 0),
                TextAlign = ContentAlignment.TopLeft
            };

            Label dateLabel = new Label
            {
                Text = note.CreatedAt.ToString("dd MMM yyyy"),
                Font = new Font("Arial", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                Dock = DockStyle.Bottom,
                Height = 20
            };
            Button deleteButton = new Button
            {
                Text = "Sil",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Right,
                Width = 50,
                Height=50,
                ForeColor = Color.Gray,
                FlatStyle = FlatStyle.Flat,
                
            };
            deleteButton.Click += (sender, e) =>
            {
                notes.Remove(note);
                SaveNotes();
                DisplayNotes();
            };

            notePanel.Controls.Add(contentLabel);
            notePanel.Controls.Add(titleLabel);
            notePanel.Controls.Add(dateLabel);
            notePanel.Controls.Add(deleteButton);

            return notePanel;
        }
        private string LimitTextLength(string text, int maxLength)
        {
            if (text.Length <= maxLength)
                return text;
            else
                return text.Substring(0, maxLength) + "...";
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

        private void addNoteBtn_Click(object sender, EventArgs e)
        {
            addNoteBtn.TextAlign = ContentAlignment.MiddleCenter; 
           
            using (AddNoteForm addNoteForm = new AddNoteForm())
            {
                if (addNoteForm.ShowDialog() == DialogResult.OK)
                {
                    notes.Add(addNoteForm.NewNote);
                    SaveNotes();
                    DisplayNotes();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addNoteBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addNoteBtn.Width, addNoteBtn.Height, 10,10));

        }

        private void loginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            MoveX = e.X;
            MoveY = e.Y;
        }

    }
}
