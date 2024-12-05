namespace ClawManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            txtPass = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            radioButton1 = new RadioButton();
            button2 = new Button();
            button1 = new Button();
            txtLogin = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 41, 71);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(17, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 682);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(49, 432);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 2);
            panel2.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(44, 370);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(62, 41, 71);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = SystemColors.Window;
            txtPass.Location = new Point(104, 387);
            txtPass.Margin = new Padding(4, 5, 4, 5);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(261, 30);
            txtPass.TabIndex = 12;
            txtPass.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(46, 337);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 2);
            panel3.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 280);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.ControlLightLight;
            radioButton1.Location = new Point(49, 458);
            radioButton1.Margin = new Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(138, 29);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Lembrar-me";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(144, 595);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(129, 50);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(196, 165, 237);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(49, 530);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(323, 50);
            button1.TabIndex = 5;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(62, 41, 71);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = SystemColors.Window;
            txtLogin.Location = new Point(104, 293);
            txtLogin.Margin = new Padding(4, 5, 4, 5);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(261, 30);
            txtLogin.TabIndex = 4;
            txtLogin.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 32);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 27, 50);
            ClientSize = new Size(441, 693);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(463, 749);
            MinimizeBox = false;
            MinimumSize = new Size(463, 749);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClawManager - Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtLogin;
        private RadioButton radioButton1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtPass;
        private Panel panel3;
        private Panel panel2;
    }
}