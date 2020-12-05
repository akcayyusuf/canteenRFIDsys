namespace KANTİN
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.logintag = new System.Windows.Forms.Label();
            this.usertb = new System.Windows.Forms.TextBox();
            this.pwdtb = new System.Windows.Forms.TextBox();
            this.loginbut = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // logintag
            // 
            this.logintag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logintag.AutoSize = true;
            this.logintag.BackColor = System.Drawing.Color.Transparent;
            this.logintag.Font = new System.Drawing.Font("Cera Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logintag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.logintag.Location = new System.Drawing.Point(239, 38);
            this.logintag.Margin = new System.Windows.Forms.Padding(120);
            this.logintag.Name = "logintag";
            this.logintag.Size = new System.Drawing.Size(154, 41);
            this.logintag.TabIndex = 0;
            this.logintag.Text = "Giriş Yap";
            this.logintag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logintag.Click += new System.EventHandler(this.logintag_Click);
            // 
            // usertb
            // 
            this.usertb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.usertb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usertb.ForeColor = System.Drawing.Color.White;
            this.usertb.Location = new System.Drawing.Point(157, 385);
            this.usertb.Name = "usertb";
            this.usertb.Size = new System.Drawing.Size(369, 37);
            this.usertb.TabIndex = 1;
            this.usertb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pwdtb
            // 
            this.pwdtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.pwdtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwdtb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pwdtb.ForeColor = System.Drawing.Color.White;
            this.pwdtb.Location = new System.Drawing.Point(157, 492);
            this.pwdtb.Name = "pwdtb";
            this.pwdtb.Size = new System.Drawing.Size(369, 37);
            this.pwdtb.TabIndex = 2;
            this.pwdtb.UseSystemPasswordChar = true;
            this.pwdtb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // loginbut
            // 
            this.loginbut.BackColor = System.Drawing.Color.Transparent;
            this.loginbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbut.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.loginbut.FlatAppearance.BorderSize = 0;
            this.loginbut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.loginbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.loginbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbut.Font = new System.Drawing.Font("Cera Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginbut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.loginbut.Location = new System.Drawing.Point(80, 628);
            this.loginbut.Name = "loginbut";
            this.loginbut.Size = new System.Drawing.Size(469, 84);
            this.loginbut.TabIndex = 4;
            this.loginbut.Text = "Giriş";
            this.loginbut.UseVisualStyleBackColor = false;
            this.loginbut.Click += new System.EventHandler(this.login_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.minimize.BackgroundImage = global::KANTİN.Properties.Resources.allttt2;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(504, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(45, 45);
            this.minimize.TabIndex = 6;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.button3.BackgroundImage = global::KANTİN.Properties.Resources._78f9fcdf9e;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(573, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 65);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::KANTİN.Properties.Resources.loginend3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(630, 757);
            this.Controls.Add(this.logintag);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginbut);
            this.Controls.Add(this.pwdtb);
            this.Controls.Add(this.usertb);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logintag;
        private System.Windows.Forms.TextBox usertb;
        private System.Windows.Forms.TextBox pwdtb;
        private System.Windows.Forms.Button loginbut;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button button3;
        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel panel1;
    }
}

