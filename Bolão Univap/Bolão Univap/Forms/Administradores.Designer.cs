namespace Bolão_Univap
{
    partial class Administradores
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            checkBox1 = new CheckBox();
            tabPage2 = new TabPage();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            tabPage3 = new TabPage();
            textBox5 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 106);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(408, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(408, 23);
            textBox2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 88);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 15;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 19);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 14;
            label3.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(166, 222);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 13;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Location = new Point(12, 12);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(428, 296);
            tabControl2.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(420, 268);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Este administrador";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(331, 84);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 19);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Visualizar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(420, 268);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Adicionar administrador";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 23);
            textBox1.TabIndex = 22;
            // 
            // button2
            // 
            button2.Location = new Point(166, 220);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 19;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 56);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 20;
            label1.Text = "Email";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(420, 268);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Remover administrador";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(9, 106);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(408, 23);
            textBox5.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 88);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 24;
            label6.Text = "Email";
            // 
            // button3
            // 
            button3.Location = new Point(165, 222);
            button3.Name = "button3";
            button3.Size = new Size(94, 40);
            button3.TabIndex = 20;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(408, 23);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 15);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 28;
            label5.Text = "Administrador";
            // 
            // Administradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 316);
            Controls.Add(tabControl2);
            Name = "Administradores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administradores";
            Load += Administradores_Load;
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Button button1;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private TabPage tabPage3;
        private Button button3;
        private ComboBox comboBox1;
        private Label label5;
        private CheckBox checkBox1;
        private TextBox textBox5;
        private Label label6;
    }
}