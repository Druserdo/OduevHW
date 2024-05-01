namespace HomeWorkLesson26_take1
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
            cbx1 = new CheckBox();
            cbx2 = new CheckBox();
            cbx3 = new CheckBox();
            btTags = new Button();
            SuspendLayout();
            // 
            // cbx1
            // 
            cbx1.AutoSize = true;
            cbx1.Font = new Font("Tahoma", 15.75F);
            cbx1.Location = new Point(12, 62);
            cbx1.Name = "cbx1";
            cbx1.Size = new Size(126, 29);
            cbx1.TabIndex = 0;
            cbx1.Text = "Галочка 1";
            cbx1.UseVisualStyleBackColor = true;
        
            // 
            // cbx2
            // 
            cbx2.AutoSize = true;
            cbx2.Font = new Font("Tahoma", 15.75F);
            cbx2.Location = new Point(12, 111);
            cbx2.Name = "cbx2";
            cbx2.Size = new Size(126, 29);
            cbx2.TabIndex = 1;
            cbx2.Text = "Галочка 2";
            cbx2.UseVisualStyleBackColor = true;
       
            // 
            // cbx3
            // 
            cbx3.AutoSize = true;
            cbx3.Font = new Font("Tahoma", 15.75F);
            cbx3.Location = new Point(12, 168);
            cbx3.Name = "cbx3";
            cbx3.Size = new Size(126, 29);
            cbx3.TabIndex = 2;
            cbx3.Text = "Галочка 3";
            cbx3.UseVisualStyleBackColor = true;
        
            // 
            // btTags
            // 
            btTags.Font = new Font("Tahoma", 15.75F);
            btTags.Location = new Point(12, 231);
            btTags.Name = "btTags";
            btTags.Size = new Size(126, 65);
            btTags.TabIndex = 3;
            btTags.Text = "Проверить флажок";
            btTags.UseVisualStyleBackColor = true;
            btTags.Click += btTags_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 308);
            Controls.Add(btTags);
            Controls.Add(cbx3);
            Controls.Add(cbx2);
            Controls.Add(cbx1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbx1;
        private CheckBox cbx2;
        private CheckBox cbx3;
        private Button btTags;
    }
}
