namespace Bolão_Univap
{
    partial class Participantes
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            button2 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(382, 291);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(374, 263);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Adicionar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 238);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 23);
            textBox3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 50);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Time:";
            // 
            // button1
            // 
            button1.Location = new Point(150, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(374, 263);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Excluir";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(151, 234);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 112);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 4;
            label2.Text = "Participante selecionado";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 130);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 9);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Participante:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 23);
            comboBox1.TabIndex = 0;
            // 
            // Participantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(406, 315);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Participantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Participantes";
            FormClosed += Participantes_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Button button2;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
    }
}