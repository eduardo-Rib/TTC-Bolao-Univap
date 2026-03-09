namespace Bolão_Univap
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
            adicionarRodadasToolStripMenuItem = new ToolStripMenuItem();
            customizarRodadasToolStripMenuItem = new ToolStripMenuItem();
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
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { participantesToolStripMenuItem, rodadasToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(143, 48);
            // 
            // participantesToolStripMenuItem
            // 
            participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            participantesToolStripMenuItem.Size = new Size(142, 22);
            participantesToolStripMenuItem.Text = "Participantes";
            // 
            // rodadasToolStripMenuItem
            // 
            rodadasToolStripMenuItem.Name = "rodadasToolStripMenuItem";
            rodadasToolStripMenuItem.Size = new Size(142, 22);
            rodadasToolStripMenuItem.Text = "Rodadas";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { participantesToolStripMenuItem1, rodadasToolStripMenuItem1, toolStripMenuItem1, toolStripMenuItem2, configuraçõesToolStripMenuItem, finalizarTemporadaToolStripMenuItem, loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(814, 29);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // participantesToolStripMenuItem1
            // 
            participantesToolStripMenuItem1.Name = "participantesToolStripMenuItem1";
            participantesToolStripMenuItem1.Size = new Size(110, 25);
            participantesToolStripMenuItem1.Text = "Participantes";
            participantesToolStripMenuItem1.Click += participantesToolStripMenuItem1_Click;
            // 
            // rodadasToolStripMenuItem1
            // 
            rodadasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { adicionarRodadasToolStripMenuItem, customizarRodadasToolStripMenuItem });
            rodadasToolStripMenuItem1.Name = "rodadasToolStripMenuItem1";
            rodadasToolStripMenuItem1.Size = new Size(82, 25);
            rodadasToolStripMenuItem1.Text = "Rodadas";
            rodadasToolStripMenuItem1.Click += rodadasToolStripMenuItem1_Click;
            // 
            // adicionarRodadasToolStripMenuItem
            // 
            adicionarRodadasToolStripMenuItem.Name = "adicionarRodadasToolStripMenuItem";
            adicionarRodadasToolStripMenuItem.Size = new Size(223, 26);
            adicionarRodadasToolStripMenuItem.Text = "Adicionar Rodadas";
            adicionarRodadasToolStripMenuItem.Click += adicionarRodadasToolStripMenuItem_Click_1;
            // 
            // customizarRodadasToolStripMenuItem
            // 
            customizarRodadasToolStripMenuItem.Name = "customizarRodadasToolStripMenuItem";
            customizarRodadasToolStripMenuItem.Size = new Size(223, 26);
            customizarRodadasToolStripMenuItem.Text = "Customizar Rodadas";
            customizarRodadasToolStripMenuItem.Click += customizarRodadasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(75, 25);
            toolStripMenuItem1.Text = "Palpites";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(98, 25);
            toolStripMenuItem2.Text = "Resultados";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(137, 25);
            configuraçõesToolStripMenuItem.Text = "Administradores";
            configuraçõesToolStripMenuItem.Click += configuraçõesToolStripMenuItem_Click;
            // 
            // finalizarTemporadaToolStripMenuItem
            // 
            finalizarTemporadaToolStripMenuItem.Name = "finalizarTemporadaToolStripMenuItem";
            finalizarTemporadaToolStripMenuItem.Size = new Size(160, 25);
            finalizarTemporadaToolStripMenuItem.Text = "Finalizar temporada";
            finalizarTemporadaToolStripMenuItem.Click += finalizarTemporadaToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(77, 25);
            loginToolStripMenuItem.Text = "Log-out";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(627, 485);
            button1.Name = "button1";
            button1.Size = new Size(175, 48);
            button1.TabIndex = 5;
            button1.Text = "Exportar para Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(627, 431);
            button2.Name = "button2";
            button2.Size = new Size(175, 48);
            button2.TabIndex = 6;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 542);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 46;
            label6.Text = "Usuário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 542);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 47;
            label1.Text = "0";
            // 
            // listView1
            // 
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.ImeMode = ImeMode.Disable;
            listView1.LabelWrap = false;
            listView1.Location = new Point(12, 87);
            listView1.Name = "listView1";
            listView1.Size = new Size(610, 446);
            listView1.TabIndex = 49;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 566);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private ToolStripMenuItem adicionarRodadasToolStripMenuItem;
        private ToolStripMenuItem customizarRodadasToolStripMenuItem;
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