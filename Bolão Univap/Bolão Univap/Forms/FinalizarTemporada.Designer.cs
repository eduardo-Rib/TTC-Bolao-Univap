namespace Bolão_Univap
{
    partial class FinalizarTemporada
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
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(161, 19);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Exportar tabela para Excel";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 57);
            button1.Name = "button1";
            button1.Size = new Size(231, 40);
            button1.TabIndex = 20;
            button1.Text = "Encerrar temporada";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FinalizarTemporada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 116);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FinalizarTemporada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finalizar Temporada";
            Load += FinalizarTemporada_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button button1;
    }
}