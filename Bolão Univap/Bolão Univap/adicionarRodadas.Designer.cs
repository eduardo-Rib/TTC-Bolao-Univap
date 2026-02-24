namespace Bolão_Univap
{
    partial class adicionarRodadas
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
            button2 = new Button();
            button3 = new Button();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            tabPage2 = new TabPage();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(164, 221);
            button2.Name = "button2";
            button2.Size = new Size(97, 35);
            button2.TabIndex = 1;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(144, 18);
            button3.Name = "button3";
            button3.Size = new Size(187, 23);
            button3.TabIndex = 6;
            button3.Text = "Remover jogo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Location = new Point(1, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(428, 296);
            tabControl2.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(420, 268);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Rodadas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 47);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(408, 168);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 9;
            label1.Text = "Jogo:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(52, 18);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(86, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(420, 268);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Adicionar jogo";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(210, 166);
            label9.Name = "label9";
            label9.Size = new Size(10, 15);
            label9.TabIndex = 19;
            label9.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(224, 145);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 18;
            label8.Text = "Minutos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 145);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 17;
            label7.Text = "Horas";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(226, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(49, 23);
            textBox5.TabIndex = 15;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 163);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(49, 23);
            textBox4.TabIndex = 14;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 166);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 13;
            label6.Text = "Horário:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(233, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 23);
            textBox3.TabIndex = 12;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(7, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 11;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 86);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 8;
            label5.Text = "Data do jogo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(7, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(408, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 12);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Time 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 12);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Time 1";
            // 
            // button1
            // 
            button1.Location = new Point(164, 210);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 3;
            button1.Text = "Adicionar jogo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 33);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 2;
            label2.Text = "X";
            // 
            // adicionarRodadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 302);
            Controls.Add(tabControl2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "adicionarRodadas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Rodada";
            Load += adicionarRodadas_Load;
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button3;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}