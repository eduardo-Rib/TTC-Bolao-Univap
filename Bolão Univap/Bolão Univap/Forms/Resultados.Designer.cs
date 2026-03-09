namespace Bolão_Univap
{
    partial class Resultados
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
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 17);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 8;
            label2.Text = "Jogos";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyDown += comboBox1_KeyDown;
            comboBox1.KeyPress += comboBox1_KeyPress;
            comboBox1.KeyUp += comboBox1_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 17);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 9;
            label3.Text = "Rodadas";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(216, 35);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 23);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.KeyDown += comboBox2_KeyDown;
            comboBox2.KeyPress += comboBox2_KeyPress;
            comboBox2.KeyUp += comboBox2_KeyUp;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 114);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(240, 96);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 31;
            label8.Text = "Time 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 164);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 24;
            label4.Text = "Placar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 117);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 25;
            label7.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 96);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 30;
            label6.Text = "Time 1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 114);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 117);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 29;
            label5.Text = "Jogo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(240, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 23);
            textBox4.TabIndex = 26;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 27;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(159, 237);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 32;
            button1.Text = "Adicionar Resultado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Resultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 289);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Resultados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultados";
            Load += Resultados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button1;
    }
}