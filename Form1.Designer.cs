namespace AdminApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            username_txt = new TextBox();
            password_txt = new TextBox();
            login_Btn = new Button();
            Logo = new Label();
            exitBtn = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(144, 127);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(147, 176);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // username_txt
            // 
            username_txt.BackColor = Color.White;
            username_txt.Location = new Point(229, 127);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(178, 23);
            username_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(229, 173);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(178, 23);
            password_txt.TabIndex = 3;
            // 
            // login_Btn
            // 
            login_Btn.BackColor = Color.Transparent;
            login_Btn.Location = new Point(135, 260);
            login_Btn.Name = "login_Btn";
            login_Btn.Size = new Size(154, 45);
            login_Btn.TabIndex = 4;
            login_Btn.Text = "Login";
            login_Btn.UseVisualStyleBackColor = false;
            login_Btn.Click += login_Btn_Click;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.ForeColor = SystemColors.ActiveCaptionText;
            Logo.Location = new Point(12, 24);
            Logo.Name = "Logo";
            Logo.Size = new Size(625, 100);
            Logo.TabIndex = 5;
            Logo.Text = "Welcome to SpringsAir Admin App.\r\nPlease Login to begin";
            Logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            exitBtn.BackgroundImageLayout = ImageLayout.Center;
            exitBtn.Location = new Point(346, 260);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(175, 45);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit\r\n";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(649, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(649, 346);
            Controls.Add(exitBtn);
            Controls.Add(Logo);
            Controls.Add(login_Btn);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "SpringsAir Admin App";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username_txt;
        private TextBox password_txt;
        private Button login_Btn;
        private Label Logo;
        private Button exitBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}