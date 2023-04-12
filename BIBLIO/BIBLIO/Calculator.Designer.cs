namespace BIBLIO
{
    partial class Calculator
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
            btnOK = new Button();
            btnExit = new Button();
            txtCh1 = new TextBox();
            txtRez = new TextBox();
            txtCh2 = new TextBox();
            cmbxAct = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 134);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Число 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 134);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Виберіть дію";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 134);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Число 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(604, 170);
            label4.Name = "label4";
            label4.Size = new Size(30, 31);
            label4.TabIndex = 3;
            label4.Text = "=";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(709, 134);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Результат";
            label5.Click += label5_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(189, 279);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 5;
            btnOK.Text = "Обчислити ";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(445, 279);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Вихід";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCh1
            // 
            txtCh1.Location = new Point(106, 174);
            txtCh1.Name = "txtCh1";
            txtCh1.Size = new Size(125, 27);
            txtCh1.TabIndex = 8;
            // 
            // txtRez
            // 
            txtRez.Location = new Point(663, 173);
            txtRez.Name = "txtRez";
            txtRez.Size = new Size(125, 27);
            txtRez.TabIndex = 9;
            // 
            // txtCh2
            // 
            txtCh2.Location = new Point(445, 174);
            txtCh2.Name = "txtCh2";
            txtCh2.Size = new Size(125, 27);
            txtCh2.TabIndex = 10;
            // 
            // cmbxAct
            // 
            cmbxAct.FormattingEnabled = true;
            cmbxAct.Location = new Point(264, 173);
            cmbxAct.Name = "cmbxAct";
            cmbxAct.Size = new Size(151, 28);
            cmbxAct.TabIndex = 11;
            cmbxAct.SelectedIndexChanged += cmbxAct_SelectedIndexChanged;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 450);
            Controls.Add(cmbxAct);
            Controls.Add(txtCh2);
            Controls.Add(txtRez);
            Controls.Add(txtCh1);
            Controls.Add(btnExit);
            Controls.Add(btnOK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnOK;
        private Button btnExit;
        private TextBox txtCh1;
        private TextBox txtRez;
        private TextBox txtCh2;
        private ComboBox cmbxAct;
    }
}