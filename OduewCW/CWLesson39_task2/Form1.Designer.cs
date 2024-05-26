namespace CWLesson39_task2
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
            textBox1 = new TextBox();
            treeView1 = new TreeView();
            buttonChoice = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(431, 23);
            textBox1.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 41);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(776, 350);
            treeView1.TabIndex = 1;
            // 
            // buttonChoice
            // 
            buttonChoice.Location = new Point(12, 402);
            buttonChoice.Name = "buttonChoice";
            buttonChoice.Size = new Size(122, 36);
            buttonChoice.TabIndex = 2;
            buttonChoice.Text = "Выбрать каталог";
            buttonChoice.UseVisualStyleBackColor = true;
            buttonChoice.Click += buttonChoice_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonChoice);
            Controls.Add(treeView1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Дерево";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TreeView treeView1;
        private Button buttonChoice;
        private OpenFileDialog openFileDialog1;
    }
}
