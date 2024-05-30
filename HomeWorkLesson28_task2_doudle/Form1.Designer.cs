namespace HomeWorkLesson28_task2_doudle
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
            label2 = new Label();
            label3 = new Label();
            tbUserName = new TextBox();
            lbLogin = new ListBox();
            lbPassword = new ListBox();
            bGenerator = new Button();
            bDell = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 0;
            label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(236, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(362, 9);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbUserName.Location = new Point(12, 33);
            tbUserName.Multiline = true;
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(218, 56);
            tbUserName.TabIndex = 3;
            // 
            // lbLogin
            // 
            lbLogin.Font = new Font("Segoe UI", 12F);
            lbLogin.FormattingEnabled = true;
            lbLogin.ItemHeight = 21;
            lbLogin.Location = new Point(236, 33);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(120, 193);
            lbLogin.TabIndex = 4;
            // 
            // lbPassword
            // 
            lbPassword.Font = new Font("Segoe UI", 12F);
            lbPassword.FormattingEnabled = true;
            lbPassword.ItemHeight = 21;
            lbPassword.Location = new Point(362, 33);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(120, 193);
            lbPassword.TabIndex = 5;
            // 
            // bGenerator
            // 
            bGenerator.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bGenerator.Location = new Point(12, 95);
            bGenerator.Name = "bGenerator";
            bGenerator.Size = new Size(218, 69);
            bGenerator.TabIndex = 6;
            bGenerator.Text = "Сгенерировать пароль";
            bGenerator.UseVisualStyleBackColor = true;
            bGenerator.Click += bGenerator_Click;
            // 
            // bDell
            // 
            bDell.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bDell.Location = new Point(12, 170);
            bDell.Name = "bDell";
            bDell.Size = new Size(218, 56);
            bDell.TabIndex = 7;
            bDell.Text = "Удалить запись";
            bDell.UseVisualStyleBackColor = true;
            bDell.Click += bDell_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 261);
            Controls.Add(bDell);
            Controls.Add(bGenerator);
            Controls.Add(lbPassword);
            Controls.Add(lbLogin);
            Controls.Add(tbUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUserName;
        private ListBox lbLogin;
        private ListBox lbPassword;
        private Button bGenerator;
        private Button bDell;
    }
}
