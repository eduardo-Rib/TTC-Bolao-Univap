namespace BolaoUnivap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            participantesToolStripMenuItem = new ToolStripMenuItem();
            rodadasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            participantesToolStripMenuItem1 = new ToolStripMenuItem();
            rodadasToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            finalizarTemporadaToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label1 = new Label();
            listView1 = new ListView();
            contextMenuStrip3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { participantesToolStripMenuItem, rodadasToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(163, 52);
            // 
            // participantesToolStripMenuItem
            // 
            participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            participantesToolStripMenuItem.Size = new Size(162, 24);
            participantesToolStripMenuItem.Text = "Participantes";
            // 
            // rodadasToolStripMenuItem
            // 
            rodadasToolStripMenuItem.Name = "rodadasToolStripMenuItem";
            rodadasToolStripMenuItem.Size = new Size(162, 24);
            rodadasToolStripMenuItem.Text = "Rodadas";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { participantesToolStripMenuItem1, rodadasToolStripMenuItem1, toolStripMenuItem1, toolStripMenuItem2, configuraçõesToolStripMenuItem, finalizarTemporadaToolStripMenuItem, loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(996, 38);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // participantesToolStripMenuItem1
            // 
            participantesToolStripMenuItem1.Name = "participantesToolStripMenuItem1";
            participantesToolStripMenuItem1.Size = new Size(137, 32);
            participantesToolStripMenuItem1.Text = "Participantes";
            participantesToolStripMenuItem1.Click += participantesToolStripMenuItem1_Click;
            // 
            // rodadasToolStripMenuItem1
            // 
            rodadasToolStripMenuItem1.Name = "rodadasToolStripMenuItem1";
            rodadasToolStripMenuItem1.Size = new Size(101, 32);
            rodadasToolStripMenuItem1.Text = "Rodadas";
            rodadasToolStripMenuItem1.Click += rodadasToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(93, 32);
            toolStripMenuItem1.Text = "Palpites";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(120, 32);
            toolStripMenuItem2.Text = "Resultados";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(170, 32);
            configuraçõesToolStripMenuItem.Text = "Administradores";
            configuraçõesToolStripMenuItem.Click += configuraçõesToolStripMenuItem_Click;
            // 
            // finalizarTemporadaToolStripMenuItem
            // 
            finalizarTemporadaToolStripMenuItem.Name = "finalizarTemporadaToolStripMenuItem";
            finalizarTemporadaToolStripMenuItem.Size = new Size(200, 32);
            finalizarTemporadaToolStripMenuItem.Text = "Finalizar temporada";
            finalizarTemporadaToolStripMenuItem.Click += finalizarTemporadaToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(97, 32);
            loginToolStripMenuItem.Text = "Log-out";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(499, 695);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(485, 64);
            button1.TabIndex = 5;
            button1.Text = "Exportar para Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 695);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(481, 64);
            button2.TabIndex = 6;
            button2.Text = "Incluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 671);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 46;
            label6.Text = "Usuário:";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 671);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 47;
            label1.Text = "0";
            // 
            // listView1
            // 
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.ImeMode = ImeMode.Disable;
            listView1.LabelWrap = false;
            listView1.Location = new Point(12, 84);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(972, 583);
            listView1.TabIndex = 49;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 772);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bolão Univap";
            Load += Form1_Load;
            contextMenuStrip3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem participantesToolStripMenuItem;
        private ToolStripMenuItem rodadasToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem participantesToolStripMenuItem1;
        private ToolStripMenuItem rodadasToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem finalizarTemporadaToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private Label label6;
        private Label label1;
        private ListView listView1;
    }
}