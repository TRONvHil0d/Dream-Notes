
namespace Dream_Notes
{
    partial class AddNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNoteForm));
            this.addPanel = new System.Windows.Forms.Panel();
            this.loginPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginMinimze = new System.Windows.Forms.Button();
            this.loginClose = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).BeginInit();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.SeaShell;
            this.addPanel.Controls.Add(this.loginPic);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.loginMinimze);
            this.addPanel.Controls.Add(this.loginClose);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(800, 32);
            this.addPanel.TabIndex = 1;
            this.addPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addPanel_MouseDown);
            this.addPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addPanel_MouseMove);
            this.addPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addPanel_MouseUp);
            // 
            // loginPic
            // 
            this.loginPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginPic.Image = ((System.Drawing.Image)(resources.GetObject("loginPic.Image")));
            this.loginPic.Location = new System.Drawing.Point(3, 0);
            this.loginPic.Name = "loginPic";
            this.loginPic.Size = new System.Drawing.Size(32, 32);
            this.loginPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loginPic.TabIndex = 1;
            this.loginPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dream Notes";
            // 
            // loginMinimze
            // 
            this.loginMinimze.BackColor = System.Drawing.Color.Transparent;
            this.loginMinimze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginMinimze.BackgroundImage")));
            this.loginMinimze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginMinimze.FlatAppearance.BorderSize = 0;
            this.loginMinimze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginMinimze.Location = new System.Drawing.Point(739, 0);
            this.loginMinimze.Name = "loginMinimze";
            this.loginMinimze.Size = new System.Drawing.Size(32, 32);
            this.loginMinimze.TabIndex = 2;
            this.loginMinimze.UseVisualStyleBackColor = false;
            // 
            // loginClose
            // 
            this.loginClose.BackColor = System.Drawing.Color.Transparent;
            this.loginClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginClose.BackgroundImage")));
            this.loginClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginClose.FlatAppearance.BorderSize = 0;
            this.loginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginClose.Location = new System.Drawing.Point(768, 0);
            this.loginClose.Name = "loginClose";
            this.loginClose.Size = new System.Drawing.Size(32, 32);
            this.loginClose.TabIndex = 1;
            this.loginClose.UseVisualStyleBackColor = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleTextBox.Location = new System.Drawing.Point(322, 60);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(172, 35);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contentTextBox.Location = new System.Drawing.Point(213, 134);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(390, 227);
            this.contentTextBox.TabIndex = 3;
            this.contentTextBox.TextChanged += new System.EventHandler(this.contentTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(389, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(375, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Content";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Linen;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBtn.Location = new System.Drawing.Point(344, 379);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(128, 37);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Confirm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(521, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Harf Sayısı: /365";
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNoteForm";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.PictureBox loginPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginMinimze;
        private System.Windows.Forms.Button loginClose;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label4;
    }
}