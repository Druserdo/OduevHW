namespace HomeWorkLesson28_task4
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
            lbxElements = new ListBox();
            label1 = new Label();
            label2 = new Label();
            tbxPuth = new TextBox();
            bAdd = new Button();
            SuspendLayout();
            // 
            // lbxElements
            // 
            lbxElements.FormattingEnabled = true;
            lbxElements.ItemHeight = 15;
            lbxElements.Location = new Point(12, 33);
            lbxElements.Name = "lbxElements";
            lbxElements.Size = new Size(462, 289);
            lbxElements.TabIndex = 0;
            lbxElements.SelectedIndexChanged += lbxElements_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "Список элементов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 349);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 2;
            label2.Text = "Укажите путь к файлу";
            // 
            // tbxPuth
            // 
            tbxPuth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbxPuth.Location = new Point(12, 373);
            tbxPuth.Name = "tbxPuth";
            tbxPuth.Size = new Size(462, 29);
            tbxPuth.TabIndex = 3;
            // 
            // bAdd
            // 
            bAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bAdd.Location = new Point(500, 373);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(112, 29);
            bAdd.TabIndex = 4;
            bAdd.Text = "Записать";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 418);
            Controls.Add(bAdd);
            Controls.Add(tbxPuth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbxElements);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxElements;
        private Label label1;
        private Label label2;
        private TextBox tbxPuth;
        private Button bAdd;
    }
}
