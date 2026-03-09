namespace Bolão_Univap
{
    partial class Palpites
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label7 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(151, 40);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(290, 40);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 2;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 22);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Participantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 22);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Jogos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 22);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Rodadas";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 113);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 145);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Placar";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(225, 116);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 14;
            label7.Text = "X";
            // 
            // button1
            // 
            button1.Location = new Point(159, 237);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 15;
            button1.Text = "Adicionar palpite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(245, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 23);
            textBox4.TabIndex = 17;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(55, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 18;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 113);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 121);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 20;
            label5.Text = "Jogo";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 95);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 21;
            label6.Text = "Time 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(245, 95);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 22;
            label8.Text = "Time 2";
            // 
            // Palpites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 289);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(textBox3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Palpites";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Palipites";
            Load += Palipites_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label7;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private Label label8;
    }
}