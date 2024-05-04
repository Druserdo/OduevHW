namespace CWLesson35_take3
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
            label1 = new Label();
            tbResult = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbFrom = new TextBox();
            tbUntil = new TextBox();
            btGenerate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 0;
            label1.Text = "Случайное число";
            // 
            // tbResult
            // 
            tbResult.Font = new Font("Tahoma", 12F);
            tbResult.Location = new Point(12, 66);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(260, 27);
            tbResult.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(29, 19);
            label2.TabIndex = 2;
            label2.Text = "От";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(172, 152);
            label3.Name = "label3";
            label3.Size = new Size(29, 19);
            label3.TabIndex = 3;
            label3.Text = "До";
            // 
            // tbFrom
            // 
            tbFrom.Font = new Font("Tahoma", 12F);
            tbFrom.Location = new Point(12, 174);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(100, 27);
            tbFrom.TabIndex = 4;
            // 
            // tbUntil
            // 
            tbUntil.Font = new Font("Tahoma", 12F);
            tbUntil.Location = new Point(172, 174);
            tbUntil.Name = "tbUntil";
            tbUntil.Size = new Size(100, 27);
            tbUntil.TabIndex = 5;
            // 
            // btGenerate
            // 
            btGenerate.Font = new Font("Tahoma", 12F);
            btGenerate.Location = new Point(53, 254);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(150, 61);
            btGenerate.TabIndex = 6;
            btGenerate.Text = "Сгеренировать";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += btGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 366);
            Controls.Add(btGenerate);
            Controls.Add(tbUntil);
            Controls.Add(tbFrom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbResult);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Случайное число";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbResult;
        private Label label2;
        private Label label3;
        private TextBox tbFrom;
        private TextBox tbUntil;
        private Button btGenerate;
    }
}
