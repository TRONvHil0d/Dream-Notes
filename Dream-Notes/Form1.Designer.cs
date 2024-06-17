
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginMinimze = new System.Windows.Forms.Button();
            this.loginClose = new System.Windows.Forms.Button();
            this.addNoteBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.loginMinimze);
            this.loginPanel.Controls.Add(this.loginClose);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(707, 23);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseDown);
            this.loginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseMove);
            this.loginPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseUp);
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
            // loginMinimze
            // 
            this.loginMinimze.BackColor = System.Drawing.Color.Transparent;
            this.loginMinimze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginMinimze.FlatAppearance.BorderSize = 0;
            this.loginMinimze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginMinimze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.loginMinimze.Location = new System.Drawing.Point(656, 0);
            this.loginMinimze.Name = "loginMinimze";
            this.loginMinimze.Size = new System.Drawing.Size(23, 23);
            this.loginMinimze.TabIndex = 2;
            this.loginMinimze.Text = "_";
            this.loginMinimze.UseVisualStyleBackColor = false;
            this.loginMinimze.Click += new System.EventHandler(this.loginMinimze_Click);
            // 
            // loginClose
            // 
            this.loginClose.BackColor = System.Drawing.Color.Transparent;
            this.loginClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginClose.FlatAppearance.BorderSize = 0;
            this.loginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.loginClose.Location = new System.Drawing.Point(685, 0);
            this.loginClose.Name = "loginClose";
            this.loginClose.Size = new System.Drawing.Size(22, 24);
            this.loginClose.TabIndex = 1;
            this.loginClose.Text = "✕";
            this.loginClose.UseVisualStyleBackColor = false;
            this.loginClose.Click += new System.EventHandler(this.loginClose_Click);
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(177)))), ((int)(((byte)(122)))));
            this.addNoteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addNoteBtn.CausesValidation = false;
            this.addNoteBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addNoteBtn.FlatAppearance.BorderSize = 0;
            this.addNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNoteBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNoteBtn.Location = new System.Drawing.Point(28, 407);
            this.addNoteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 4);
            this.addNoteBtn.Size = new System.Drawing.Size(40, 40);
            this.addNoteBtn.TabIndex = 1;
            this.addNoteBtn.Text = "+";
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
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(343, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Notes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginClose;
        private System.Windows.Forms.Button loginMinimze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button addNoteBtn;
    }
}

