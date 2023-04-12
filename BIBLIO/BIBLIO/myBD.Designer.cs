namespace BIBLIO
{
    partial class myBD
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
            menuStrip1 = new MenuStrip();
            таблицяБДToolStripMenuItem = new ToolStripMenuItem();
            адмініструванняToolStripMenuItem = new ToolStripMenuItem();
            калькуляторToolStripMenuItem = new ToolStripMenuItem();
            проРограмуToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { таблицяБДToolStripMenuItem, адмініструванняToolStripMenuItem, калькуляторToolStripMenuItem, проРограмуToolStripMenuItem, вихідToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // таблицяБДToolStripMenuItem
            // 
            таблицяБДToolStripMenuItem.Name = "таблицяБДToolStripMenuItem";
            таблицяБДToolStripMenuItem.Size = new Size(105, 24);
            таблицяБДToolStripMenuItem.Text = "Таблиця БД";
            // 
            // адмініструванняToolStripMenuItem
            // 
            адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            адмініструванняToolStripMenuItem.Size = new Size(140, 24);
            адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // калькуляторToolStripMenuItem
            // 
            калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            калькуляторToolStripMenuItem.Size = new Size(110, 24);
            калькуляторToolStripMenuItem.Text = "Калькулятор";
            калькуляторToolStripMenuItem.Click += калькуляторToolStripMenuItem_Click;
            // 
            // проРограмуToolStripMenuItem
            // 
            проРограмуToolStripMenuItem.Name = "проРограмуToolStripMenuItem";
            проРограмуToolStripMenuItem.Size = new Size(119, 24);
            проРограмуToolStripMenuItem.Text = "Про рограму ";
            проРограмуToolStripMenuItem.Click += проРограмуToolStripMenuItem_Click;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(60, 24);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // myBD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "myBD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бібліотека";
            FormClosed += myBD_FormClosed;
            Load += myBD_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem таблицяБДToolStripMenuItem;
        private ToolStripMenuItem адмініструванняToolStripMenuItem;
        private ToolStripMenuItem калькуляторToolStripMenuItem;
        private ToolStripMenuItem проРограмуToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
    }
}