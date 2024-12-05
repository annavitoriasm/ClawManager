namespace ClawManager
{
    partial class Alert
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
            button1 = new Button();
            panel1 = new Panel();
            lbPlace1 = new Label();
            panel2 = new Panel();
            lbPlace2 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(196, 165, 237);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(84, 189);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 0;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbPlace1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 37);
            panel1.TabIndex = 1;
            // 
            // lbPlace1
            // 
            lbPlace1.AutoSize = true;
            lbPlace1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbPlace1.ForeColor = SystemColors.ButtonHighlight;
            lbPlace1.Location = new Point(109, 7);
            lbPlace1.Name = "lbPlace1";
            lbPlace1.Size = new Size(73, 30);
            lbPlace1.TabIndex = 0;
            lbPlace1.Text = "Titulo";
            lbPlace1.TextAlign = ContentAlignment.MiddleCenter;
            lbPlace1.Click += lbPlace1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbPlace2);
            panel2.Location = new Point(12, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 65);
            panel2.TabIndex = 2;
            // 
            // lbPlace2
            // 
            lbPlace2.AutoSize = true;
            lbPlace2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPlace2.ForeColor = SystemColors.ButtonHighlight;
            lbPlace2.Location = new Point(3, 22);
            lbPlace2.Name = "lbPlace2";
            lbPlace2.Size = new Size(112, 25);
            lbPlace2.TabIndex = 1;
            lbPlace2.Text = "Placeholder";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(84, 221);
            button2.Name = "button2";
            button2.Size = new Size(140, 23);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Alert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 27, 50);
            ClientSize = new Size(313, 264);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(329, 303);
            MinimizeBox = false;
            MinimumSize = new Size(329, 303);
            Name = "Alert";
            ShowIcon = false;
            Text = "Atenção!";
            TopMost = true;
            Load += Alert_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Label lbPlace1;
        private Label lbPlace2;
    }
}