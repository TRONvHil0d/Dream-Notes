
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
            this.loginClose = new System.Windows.Forms.Button();
            this.loginMinimze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPic = new System.Windows.Forms.PictureBox();
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
            this.loginPanel.Size = new System.Drawing.Size(618, 32);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseDown);
            this.loginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseMove);
            this.loginPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseUp);
            // 
            // loginClose
            // 
            this.loginClose.BackColor = System.Drawing.Color.Transparent;
            this.loginClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginClose.BackgroundImage")));
            this.loginClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginClose.FlatAppearance.BorderSize = 0;
            this.loginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginClose.Location = new System.Drawing.Point(587, 0);
            this.loginClose.Name = "loginClose";
            this.loginClose.Size = new System.Drawing.Size(32, 32);
            this.loginClose.TabIndex = 1;
            this.loginClose.UseVisualStyleBackColor = false;
            this.loginClose.Click += new System.EventHandler(this.loginClose_Click);
            // 
            // loginMinimze
            // 
            this.loginMinimze.BackColor = System.Drawing.Color.Transparent;
            this.loginMinimze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginMinimze.BackgroundImage")));
            this.loginMinimze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginMinimze.FlatAppearance.BorderSize = 0;
            this.loginMinimze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginMinimze.Location = new System.Drawing.Point(549, 0);
            this.loginMinimze.Name = "loginMinimze";
            this.loginMinimze.Size = new System.Drawing.Size(32, 32);
            this.loginMinimze.TabIndex = 2;
            this.loginMinimze.UseVisualStyleBackColor = false;
            this.loginMinimze.Click += new System.EventHandler(this.loginMinimze_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(618, 390);
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

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginClose;
        private System.Windows.Forms.Button loginMinimze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox loginPic;
    }
}

