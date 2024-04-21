namespace CWLesson31
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
            tbFirst = new TextBox();
            tbSecond = new TextBox();
            btEdd = new Button();
            btSub = new Button();
            btMult = new Button();
            btDiv = new Button();
            lbResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 114);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 0;
            label1.Text = "Введите X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 114);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 1;
            label2.Text = "Введите Y";
            // 
            // tbFirst
            // 
            tbFirst.Location = new Point(67, 182);
            tbFirst.Margin = new Padding(5, 6, 5, 6);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(100, 35);
            tbFirst.TabIndex = 2;
            // 
            // tbSecond
            // 
            tbSecond.Location = new Point(269, 182);
            tbSecond.Margin = new Padding(5, 6, 5, 6);
            tbSecond.Name = "tbSecond";
            tbSecond.Size = new Size(100, 35);
            tbSecond.TabIndex = 3;
            // 
            // btEdd
            // 
            btEdd.Location = new Point(41, 304);
            btEdd.Margin = new Padding(5, 6, 5, 6);
            btEdd.Name = "btEdd";
            btEdd.Size = new Size(129, 46);
            btEdd.TabIndex = 4;
            btEdd.Text = "+";
            btEdd.UseVisualStyleBackColor = true;
            btEdd.Click += btEdd_Click_1;
            // 
            // btSub
            // 
            btSub.Location = new Point(41, 362);
            btSub.Margin = new Padding(5, 6, 5, 6);
            btSub.Name = "btSub";
            btSub.Size = new Size(129, 46);
            btSub.TabIndex = 5;
            btSub.Text = "-";
            btSub.UseVisualStyleBackColor = true;
            btSub.Click += btSub_Click;
            // 
            // btMult
            // 
            btMult.Location = new Point(41, 420);
            btMult.Margin = new Padding(5, 6, 5, 6);
            btMult.Name = "btMult";
            btMult.Size = new Size(129, 46);
            btMult.TabIndex = 6;
            btMult.Text = "*";
            btMult.UseVisualStyleBackColor = true;
            btMult.Click += btMult_Click;
            // 
            // btDiv
            // 
            btDiv.Location = new Point(41, 478);
            btDiv.Margin = new Padding(5, 6, 5, 6);
            btDiv.Name = "btDiv";
            btDiv.Size = new Size(129, 46);
            btDiv.TabIndex = 7;
            btDiv.Text = "/";
            btDiv.UseVisualStyleBackColor = true;
            btDiv.Click += btDiv_Click;
            // 
            // lbResult
            // 
            lbResult.BackColor = SystemColors.Control;
            lbResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbResult.ForeColor = SystemColors.MenuHighlight;
            lbResult.Location = new Point(41, 552);
            lbResult.Margin = new Padding(5, 0, 5, 0);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(480, 238);
            lbResult.TabIndex = 8;
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 792);
            Controls.Add(lbResult);
            Controls.Add(btDiv);
            Controls.Add(btMult);
            Controls.Add(btSub);
            Controls.Add(btEdd);
            Controls.Add(tbSecond);
            Controls.Add(tbFirst);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Program1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbFirst;
        private TextBox tbSecond;
        private Button btEdd;
        private Button btSub;
        private Button btMult;
        private Button btDiv;
        private Label lbResult;
    }
}
