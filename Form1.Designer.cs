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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(229, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(135, 260);
            button1.Name = "button1";
            button1.Size = new Size(154, 45);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
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
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "SpringsAir Admin App";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label Logo;
        private Button exitBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}