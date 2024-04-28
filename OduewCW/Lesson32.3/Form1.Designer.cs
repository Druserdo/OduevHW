namespace Lesson32._3
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
            tbWidth = new TextBox();
            tbHeight = new TextBox();
            lbxMaterial = new ListBox();
            pbxMaterial = new PictureBox();
            btResult = new Button();
            lbResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxMaterial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 83);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Ширина";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 116);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Высота";
            // 
            // tbWidth
            // 
            tbWidth.Location = new Point(156, 75);
            tbWidth.Name = "tbWidth";
            tbWidth.Size = new Size(120, 23);
            tbWidth.TabIndex = 2;
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(156, 108);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(120, 23);
            tbHeight.TabIndex = 3;
            // 
            // lbxMaterial
            // 
            lbxMaterial.FormattingEnabled = true;
            lbxMaterial.ItemHeight = 15;
            lbxMaterial.Items.AddRange(new object[] { "Алюминий", "Пластик", "Дерево", "Бамбук" });
            lbxMaterial.Location = new Point(50, 171);
            lbxMaterial.Name = "lbxMaterial";
            lbxMaterial.Size = new Size(226, 214);
            lbxMaterial.TabIndex = 4;
            lbxMaterial.SelectedIndexChanged += lbxMaterial_SelectedIndexChanged;
            // 
            // pbxMaterial
            // 
            pbxMaterial.Location = new Point(400, 75);
            pbxMaterial.Name = "pbxMaterial";
            pbxMaterial.Size = new Size(343, 310);
            pbxMaterial.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxMaterial.TabIndex = 5;
            pbxMaterial.TabStop = false;
            // 
            // btResult
            // 
            btResult.Location = new Point(50, 451);
            btResult.Name = "btResult";
            btResult.Size = new Size(204, 55);
            btResult.TabIndex = 6;
            btResult.Text = "Подсчитать";
            btResult.UseVisualStyleBackColor = true;
            btResult.Click += btResult_Click;
            // 
            // lbResult
            // 
            lbResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbResult.Location = new Point(400, 451);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(343, 69);
            lbResult.TabIndex = 7;
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 548);
            Controls.Add(lbResult);
            Controls.Add(btResult);
            Controls.Add(pbxMaterial);
            Controls.Add(lbxMaterial);
            Controls.Add(tbHeight);
            Controls.Add(tbWidth);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Конструктор";
            ((System.ComponentModel.ISupportInitialize)pbxMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbWidth;
        private TextBox tbHeight;
        private ListBox lbxMaterial;
        private PictureBox pbxMaterial;
        private Button btResult;
        private Label lbResult;
    }
}
