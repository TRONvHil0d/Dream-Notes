
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addMinimize = new System.Windows.Forms.Button();
            this.addClose = new System.Windows.Forms.Button();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleTextBox.ForeColor = System.Drawing.Color.White;
            this.titleTextBox.Location = new System.Drawing.Point(314, 60);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(172, 35);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contentTextBox
            // 
            this.contentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.contentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contentTextBox.ForeColor = System.Drawing.Color.White;
            this.contentTextBox.Location = new System.Drawing.Point(205, 134);
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
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(381, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.label3.Location = new System.Drawing.Point(367, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Content";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(177)))), ((int)(((byte)(122)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBtn.Location = new System.Drawing.Point(362, 378);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(76, 34);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.label4.Location = new System.Drawing.Point(504, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Character: / 365";
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.addMinimize);
            this.addPanel.Controls.Add(this.addClose);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(800, 23);
            this.addPanel.TabIndex = 8;
            this.addPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addPanel_MouseDown);
            this.addPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addPanel_MouseMove);
            this.addPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addPanel_MouseUp);
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
            // addMinimize
            // 
            this.addMinimize.BackColor = System.Drawing.Color.Transparent;
            this.addMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addMinimize.FlatAppearance.BorderSize = 0;
            this.addMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.addMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.addMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.addMinimize.Location = new System.Drawing.Point(749, 0);
            this.addMinimize.Name = "addMinimize";
            this.addMinimize.Size = new System.Drawing.Size(23, 23);
            this.addMinimize.TabIndex = 2;
            this.addMinimize.Text = "_";
            this.addMinimize.UseVisualStyleBackColor = false;
            this.addMinimize.Click += new System.EventHandler(this.addMinimize_Click);
            // 
            // addClose
            // 
            this.addClose.BackColor = System.Drawing.Color.Transparent;
            this.addClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addClose.FlatAppearance.BorderSize = 0;
            this.addClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.addClose.Location = new System.Drawing.Point(778, 0);
            this.addClose.Name = "addClose";
            this.addClose.Size = new System.Drawing.Size(22, 24);
            this.addClose.TabIndex = 1;
            this.addClose.Text = "✕";
            this.addClose.UseVisualStyleBackColor = false;
            this.addClose.Click += new System.EventHandler(this.addClose_Click);
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.titleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNoteForm";
            this.Load += new System.EventHandler(this.AddNoteForm_Load);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMinimize;
        private System.Windows.Forms.Button addClose;
    }
}