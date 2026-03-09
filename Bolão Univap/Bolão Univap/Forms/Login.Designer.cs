namespace Bolão_Univap
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
            button3 = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 122);
            button3.Name = "button3";
            button3.Size = new Size(193, 40);
            button3.TabIndex = 46;
            button3.Text = "Logar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 13);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 45;
            label6.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 86);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 68);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 48;
            label1.Text = "Senha";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 174);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label1;
    }
}