namespace Lesson31_take2
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
            lbName = new Label();
            tbName = new TextBox();
            lbPass = new Label();
            tbPas = new TextBox();
            llLink = new LinkLabel();
            btOk = new Button();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(62, 210);
            lbName.Margin = new Padding(5, 0, 5, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(106, 30);
            lbName.TabIndex = 0;
            lbName.Text = "Username";
            // 
            // tbName
            // 
            tbName.Location = new Point(62, 246);
            tbName.Margin = new Padding(5, 6, 5, 6);
            tbName.Name = "tbName";
            tbName.Size = new Size(443, 35);
            tbName.TabIndex = 1;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.ForeColor = Color.Black;
            lbPass.Location = new Point(62, 320);
            lbPass.Margin = new Padding(5, 0, 5, 0);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(99, 30);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // tbPas
            // 
            tbPas.Location = new Point(62, 356);
            tbPas.Margin = new Padding(5, 6, 5, 6);
            tbPas.Name = "tbPas";
            tbPas.Size = new Size(443, 35);
            tbPas.TabIndex = 3;
            // 
            // llLink
            // 
            llLink.AutoSize = true;
            llLink.Location = new Point(608, 1022);
            llLink.Margin = new Padding(5, 0, 5, 0);
            llLink.Name = "llLink";
            llLink.Size = new Size(66, 30);
            llLink.TabIndex = 4;
            llLink.TabStop = true;
            llLink.Text = "SSilka";
            // 
            // btOk
            // 
            btOk.ForeColor = Color.Black;
            btOk.Location = new Point(62, 444);
            btOk.Margin = new Padding(5, 6, 5, 6);
            btOk.Name = "btOk";
            btOk.Size = new Size(163, 46);
            btOk.TabIndex = 5;
            btOk.Text = "OK";
            btOk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(737, 1061);
            Controls.Add(btOk);
            Controls.Add(llLink);
            Controls.Add(tbPas);
            Controls.Add(lbPass);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Control;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Authorisation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private TextBox tbName;
        private Label lbPass;
        private TextBox tbPas;
        private LinkLabel llLink;
        private Button btOk;
    }
}
