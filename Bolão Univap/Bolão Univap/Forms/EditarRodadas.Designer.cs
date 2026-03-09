namespace Bolão_Univap
{
    partial class EditarRodadas
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
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label9 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 17);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 25;
            label2.Text = "Jogos";
            // 
            // button1
            // 
            button1.Location = new Point(123, 237);
            button1.Name = "button1";
            button1.Size = new Size(82, 40);
            button1.TabIndex = 29;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(232, 70);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 33;
            label8.Text = "Time 2";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 23);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            comboBox1.KeyUp += comboBox1_KeyUp;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 91);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 28;
            label7.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 70);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 32;
            label6.Text = "Time 1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 23);
            textBox2.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 17);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 26;
            label3.Text = "Rodadas";
            label3.Click += label3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(232, 35);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 23);
            comboBox2.TabIndex = 24;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(227, 237);
            button2.Name = "button2";
            button2.Size = new Size(82, 40);
            button2.TabIndex = 34;
            button2.Text = "Excluir jogo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(211, 188);
            label9.Name = "label9";
            label9.Size = new Size(10, 15);
            label9.TabIndex = 42;
            label9.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 167);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 41;
            label1.Text = "Minutos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 167);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 40;
            label4.Text = "Horas";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(227, 185);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(49, 23);
            textBox5.TabIndex = 39;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(49, 23);
            textBox4.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 188);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 37;
            label5.Text = "Horário:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 118);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 36;
            label10.Text = "Data do jogo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 136);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(408, 23);
            dateTimePicker1.TabIndex = 35;
            // 
            // button3
            // 
            button3.Location = new Point(13, 237);
            button3.Name = "button3";
            button3.Size = new Size(82, 40);
            button3.TabIndex = 43;
            button3.Text = "Adicionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(338, 237);
            button4.Name = "button4";
            button4.Size = new Size(82, 40);
            button4.TabIndex = 44;
            button4.Text = "Excluir rodada";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // EditarRodadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 289);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EditarRodadas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customizar Rodadas";
            Load += EditarRodadas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label8;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox2;
        private Button button2;
        private Label label9;
        private Label label1;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label5;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button4;
    }
}