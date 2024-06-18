
namespace Dream_Notes
{
    partial class EditNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.editMinimize = new System.Windows.Forms.Button();
            this.editClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editContentTextBox = new System.Windows.Forms.TextBox();
            this.editTitleTextBox = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Controls.Add(this.editMinimize);
            this.editPanel.Controls.Add(this.editClose);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(800, 23);
            this.editPanel.TabIndex = 9;
            this.editPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.editPanel_MouseDown);
            this.editPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editPanel_MouseMove);
            this.editPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.editPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dream Notes";
            // 
            // editMinimize
            // 
            this.editMinimize.BackColor = System.Drawing.Color.Transparent;
            this.editMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editMinimize.FlatAppearance.BorderSize = 0;
            this.editMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.editMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.editMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.editMinimize.Location = new System.Drawing.Point(749, 0);
            this.editMinimize.Name = "editMinimize";
            this.editMinimize.Size = new System.Drawing.Size(23, 23);
            this.editMinimize.TabIndex = 2;
            this.editMinimize.Text = "_";
            this.editMinimize.UseVisualStyleBackColor = false;
            // 
            // editClose
            // 
            this.editClose.BackColor = System.Drawing.Color.Transparent;
            this.editClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editClose.FlatAppearance.BorderSize = 0;
            this.editClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.editClose.Location = new System.Drawing.Point(778, 0);
            this.editClose.Name = "editClose";
            this.editClose.Size = new System.Drawing.Size(22, 24);
            this.editClose.TabIndex = 1;
            this.editClose.Text = "✕";
            this.editClose.UseVisualStyleBackColor = false;
            this.editClose.Click += new System.EventHandler(this.editClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.label3.Location = new System.Drawing.Point(363, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Content";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(377, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Title";
            // 
            // editContentTextBox
            // 
            this.editContentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.editContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editContentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editContentTextBox.ForeColor = System.Drawing.Color.White;
            this.editContentTextBox.Location = new System.Drawing.Point(201, 135);
            this.editContentTextBox.Multiline = true;
            this.editContentTextBox.Name = "editContentTextBox";
            this.editContentTextBox.Size = new System.Drawing.Size(390, 227);
            this.editContentTextBox.TabIndex = 11;
            // 
            // editTitleTextBox
            // 
            this.editTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.editTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.editTitleTextBox.Location = new System.Drawing.Point(310, 61);
            this.editTitleTextBox.Multiline = true;
            this.editTitleTextBox.Name = "editTitleTextBox";
            this.editTitleTextBox.Size = new System.Drawing.Size(172, 35);
            this.editTitleTextBox.TabIndex = 10;
            this.editTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(177)))), ((int)(((byte)(122)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editBtn.Location = new System.Drawing.Point(353, 377);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(76, 34);
            this.editBtn.TabIndex = 14;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editContentTextBox);
            this.Controls.Add(this.editTitleTextBox);
            this.Controls.Add(this.editPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditNoteForm";
            this.Load += new System.EventHandler(this.EditNoteForm_Load);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editMinimize;
        private System.Windows.Forms.Button editClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editContentTextBox;
        private System.Windows.Forms.TextBox editTitleTextBox;
        private System.Windows.Forms.Button editBtn;
    }
}