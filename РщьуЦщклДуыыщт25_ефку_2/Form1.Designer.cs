namespace РщьуЦщклДуыыщт25_ефку_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.LightGreen;
            label1.Location = new Point(261, 144);
            label1.Name = "label1";
            label1.Size = new Size(338, 38);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(261, 262);
            button1.Name = "button1";
            button1.Size = new Size(338, 47);
            button1.TabIndex = 2;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(261, 337);
            button2.Name = "button2";
            button2.Size = new Size(338, 47);
            button2.TabIndex = 3;
            button2.Text = "Авторизация";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 649);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}
