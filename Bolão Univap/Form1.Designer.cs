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
            menuStrip1.Items.AddRange(new ToolStripItem[] { participantesToolStripMenuItem1, rodadasToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(950, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // participantesToolStripMenuItem1
            // 
            participantesToolStripMenuItem1.Name = "participantesToolStripMenuItem1";
            participantesToolStripMenuItem1.Size = new Size(87, 20);
            participantesToolStripMenuItem1.Text = "Participantes";
            participantesToolStripMenuItem1.Click += participantesToolStripMenuItem1_Click;
            // 
            // rodadasToolStripMenuItem1
            // 
            rodadasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { adicionarRodadasToolStripMenuItem, customizarRodadasToolStripMenuItem });
            rodadasToolStripMenuItem1.Name = "rodadasToolStripMenuItem1";
            rodadasToolStripMenuItem1.Size = new Size(64, 20);
            rodadasToolStripMenuItem1.Text = "Rodadas";
            // 
            // adicionarRodadasToolStripMenuItem
            // 
            adicionarRodadasToolStripMenuItem.Name = "adicionarRodadasToolStripMenuItem";
            adicionarRodadasToolStripMenuItem.Size = new Size(182, 22);
            adicionarRodadasToolStripMenuItem.Text = "Adicionar Rodadas";
            adicionarRodadasToolStripMenuItem.Click += adicionarRodadasToolStripMenuItem_Click_1;
            // 
            // customizarRodadasToolStripMenuItem
            // 
            customizarRodadasToolStripMenuItem.Name = "customizarRodadasToolStripMenuItem";
            customizarRodadasToolStripMenuItem.Size = new Size(182, 22);
            customizarRodadasToolStripMenuItem.Text = "Customizar Rodadas";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 87);
            listView1.Name = "listView1";
            listView1.Size = new Size(595, 430);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 566);
            Controls.Add(listView1);
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
        private ListView listView1;
    }
}