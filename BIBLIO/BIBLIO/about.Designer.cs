namespace BIBLIO
{
    partial class about
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(531, 160);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 28);
            label1.TabIndex = 0;
            label1.Text = "Клієнт-сервера БД \"Бібліотека\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 206);
            label2.Name = "label2";
            label2.Size = new Size(609, 28);
            label2.TabIndex = 1;
            label2.Text = "розробив сттудент групи ІСТ-21\\2 Музика Богдан Васильович";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 248);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 2;
            label3.Text = "18.06.2003";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 294);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
            label4.TabIndex = 3;
            label4.Text = "Visual studio 2022";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(531, 360);
            label5.Name = "label5";
            label5.Size = new Size(411, 28);
            label5.TabIndex = 4;
            label5.Text = "C#. Windows Form App. Net Frameworck 4.8";
            // 
            // about
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 630);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "about";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}