
namespace Dream_Notes
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginMinimze = new System.Windows.Forms.Button();
            this.loginClose = new System.Windows.Forms.Button();
            this.addNoteBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.SeaShell;
            this.loginPanel.Controls.Add(this.loginPic);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.loginMinimze);
            this.loginPanel.Controls.Add(this.loginClose);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(707, 32);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseDown);
            this.loginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseMove);
            this.loginPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseUp);
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
            this.label1.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
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
            this.loginMinimze.Location = new System.Drawing.Point(647, 0);
            this.loginMinimze.Name = "loginMinimze";
            this.loginMinimze.Size = new System.Drawing.Size(32, 31);
            this.loginMinimze.TabIndex = 2;
            this.loginMinimze.UseVisualStyleBackColor = false;
            this.loginMinimze.Click += new System.EventHandler(this.loginMinimze_Click);
            // 
            // loginClose
            // 
            this.loginClose.BackColor = System.Drawing.Color.Transparent;
            this.loginClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginClose.BackgroundImage")));
            this.loginClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginClose.FlatAppearance.BorderSize = 0;
            this.loginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginClose.Location = new System.Drawing.Point(675, -1);
            this.loginClose.Name = "loginClose";
            this.loginClose.Size = new System.Drawing.Size(32, 32);
            this.loginClose.TabIndex = 1;
            this.loginClose.UseVisualStyleBackColor = false;
            this.loginClose.Click += new System.EventHandler(this.loginClose_Click);
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.BackColor = System.Drawing.Color.Linen;
            this.addNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNoteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNoteBtn.Location = new System.Drawing.Point(3, 219);
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Size = new System.Drawing.Size(82, 73);
            this.addNoteBtn.TabIndex = 1;
            this.addNoteBtn.Text = "Add Note";
            this.addNoteBtn.UseVisualStyleBackColor = false;
            this.addNoteBtn.Click += new System.EventHandler(this.addNoteBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(101, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(578, 407);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Notes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(707, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.addNoteBtn);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginClose;
        private System.Windows.Forms.Button loginMinimze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox loginPic;
        private System.Windows.Forms.Button addNoteBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
    }
}

