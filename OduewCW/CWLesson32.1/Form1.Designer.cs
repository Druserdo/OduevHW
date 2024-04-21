namespace CWLesson32._1
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
            lbMark = new Label();
            tbMark = new TextBox();
            chbMark = new CheckBox();
            btMark = new Button();
            lbResult = new Label();
            SuspendLayout();
            // 
            // lbMark
            // 
            lbMark.AutoSize = true;
            lbMark.Location = new Point(12, 49);
            lbMark.Name = "lbMark";
            lbMark.Size = new Size(57, 19);
            lbMark.TabIndex = 0;
            lbMark.Text = "Милли";
            // 
            // tbMark
            // 
            tbMark.Location = new Point(119, 41);
            tbMark.Name = "tbMark";
            tbMark.Size = new Size(189, 27);
            tbMark.TabIndex = 1;
            tbMark.TextChanged += tbMark_TextChanged;
            tbMark.KeyPress += tbMark_KeyPress;
            // 
            // chbMark
            // 
            chbMark.AutoSize = true;
            chbMark.Location = new Point(119, 74);
            chbMark.Name = "chbMark";
            chbMark.RightToLeft = RightToLeft.No;
            chbMark.Size = new Size(179, 23);
            chbMark.TabIndex = 2;
            chbMark.Text = "милли > Километры";
            chbMark.UseVisualStyleBackColor = true;
            chbMark.CheckedChanged += chbMark_CheckedChanged;
            // 
            // btMark
            // 
            btMark.Location = new Point(119, 126);
            btMark.Name = "btMark";
            btMark.Size = new Size(93, 37);
            btMark.TabIndex = 3;
            btMark.Text = "Перевести";
            btMark.UseVisualStyleBackColor = true;
            btMark.Click += btMark_Click;
            // 
            // lbResult
            // 
            lbResult.BorderStyle = BorderStyle.FixedSingle;
            lbResult.Dock = DockStyle.Bottom;
            lbResult.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbResult.Location = new Point(0, 249);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(378, 62);
            lbResult.TabIndex = 4;
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 311);
            Controls.Add(lbResult);
            Controls.Add(btMark);
            Controls.Add(chbMark);
            Controls.Add(tbMark);
            Controls.Add(lbMark);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Милли-Километры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMark;
        private TextBox tbMark;
        private CheckBox chbMark;
        private Button btMark;
        private Label lbResult;
    }
}
