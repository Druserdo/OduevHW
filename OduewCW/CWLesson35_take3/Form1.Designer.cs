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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lbResult = new Label();
            label7 = new Label();
            label6 = new Label();
            cbxPressure = new ComboBox();
            cbxTemp = new ComboBox();
            cbxLong = new ComboBox();
            label5 = new Label();
            tbNumber = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 0;
            label1.Text = "Случайное число";
            // 
            // tbResult
            // 
            tbResult.Font = new Font("Tahoma", 12F);
            tbResult.Location = new Point(6, 45);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(260, 27);
            tbResult.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(6, 131);
            label2.Name = "label2";
            label2.Size = new Size(29, 19);
            label2.TabIndex = 2;
            label2.Text = "От";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(168, 131);
            label3.Name = "label3";
            label3.Size = new Size(29, 19);
            label3.TabIndex = 3;
            label3.Text = "До";
            // 
            // tbFrom
            // 
            tbFrom.Font = new Font("Tahoma", 12F);
            tbFrom.Location = new Point(6, 153);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(100, 27);
            tbFrom.TabIndex = 4;
            // 
            // tbUntil
            // 
            tbUntil.Font = new Font("Tahoma", 12F);
            tbUntil.Location = new Point(166, 153);
            tbUntil.Name = "tbUntil";
            tbUntil.Size = new Size(100, 27);
            tbUntil.TabIndex = 5;
            // 
            // btGenerate
            // 
            btGenerate.Font = new Font("Tahoma", 12F);
            btGenerate.Location = new Point(47, 233);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(150, 61);
            btGenerate.TabIndex = 6;
            btGenerate.Text = "Сгеренировать";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += btGenerate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbResult);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btGenerate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbUntil);
            groupBox1.Controls.Add(tbFrom);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 342);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задача 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbResult);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbxPressure);
            groupBox2.Controls.Add(cbxTemp);
            groupBox2.Controls.Add(cbxLong);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbNumber);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(314, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(527, 442);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "задача 2";
            // 
            // lbResult
            // 
            lbResult.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbResult.Location = new Point(38, 233);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(452, 109);
            lbResult.TabIndex = 9;
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.Location = new Point(369, 135);
            label7.Name = "label7";
            label7.Size = new Size(113, 19);
            label7.TabIndex = 8;
            label7.Text = "Из Паскалей в";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(201, 135);
            label6.Name = "label6";
            label6.Size = new Size(110, 19);
            label6.TabIndex = 7;
            label6.Text = "Из гпадусов в";
            // 
            // cbxPressure
            // 
            cbxPressure.Font = new Font("Tahoma", 12F);
            cbxPressure.FormattingEnabled = true;
            cbxPressure.Items.AddRange(new object[] { "Мм.Рт.Ст.", "Бары", "Атмосферы", "кгС" });
            cbxPressure.Location = new Point(353, 157);
            cbxPressure.Name = "cbxPressure";
            cbxPressure.Size = new Size(137, 27);
            cbxPressure.TabIndex = 6;
            cbxPressure.SelectedIndexChanged += cbxPressure_SelectedIndexChanged;
            // 
            // cbxTemp
            // 
            cbxTemp.Font = new Font("Tahoma", 12F);
            cbxTemp.FormattingEnabled = true;
            cbxTemp.Items.AddRange(new object[] { "Кельвины", "Фаренгейты" });
            cbxTemp.Location = new Point(201, 157);
            cbxTemp.Name = "cbxTemp";
            cbxTemp.Size = new Size(135, 27);
            cbxTemp.TabIndex = 5;
            cbxTemp.SelectedIndexChanged += cbxTemp_SelectedIndexChanged;
            // 
            // cbxLong
            // 
            cbxLong.Font = new Font("Tahoma", 12F);
            cbxLong.FormattingEnabled = true;
            cbxLong.Items.AddRange(new object[] { "Сантиметры", "Дециметры", "Метры ", "Километры" });
            cbxLong.Location = new Point(38, 157);
            cbxLong.Name = "cbxLong";
            cbxLong.Size = new Size(137, 27);
            cbxLong.TabIndex = 4;
            cbxLong.SelectedIndexChanged += cbxLong_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(38, 135);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 3;
            label5.Text = "Из мм в";
            // 
            // tbNumber
            // 
            tbNumber.Font = new Font("Tahoma", 12F);
            tbNumber.Location = new Point(38, 45);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(452, 27);
            tbNumber.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(36, 23);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 0;
            label4.Text = "Введите число";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 452);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Случайное число";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tbResult;
        private Label label2;
        private Label label3;
        private TextBox tbFrom;
        private TextBox tbUntil;
        private Button btGenerate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbxLong;
        private Label label5;
        private TextBox tbNumber;
        private Label label4;
        private Label lbResult;
        private Label label7;
        private Label label6;
        private ComboBox cbxPressure;
        private ComboBox cbxTemp;
    }
}
