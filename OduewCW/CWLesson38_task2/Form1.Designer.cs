namespace CWLesson38_task2
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
            listBoxTitle = new ListBox();
            listBoxAuthor = new ListBox();
            listBoxYear = new ListBox();
            textBoxTatle = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxYear = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAdd = new Button();
            buttonDell = new Button();
            statusStrip1 = new StatusStrip();
            CountBook = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxTitle
            // 
            listBoxTitle.FormattingEnabled = true;
            listBoxTitle.ItemHeight = 15;
            listBoxTitle.Location = new Point(12, 12);
            listBoxTitle.Name = "listBoxTitle";
            listBoxTitle.Size = new Size(174, 349);
            listBoxTitle.TabIndex = 0;
            // 
            // listBoxAuthor
            // 
            listBoxAuthor.FormattingEnabled = true;
            listBoxAuthor.ItemHeight = 15;
            listBoxAuthor.Location = new Point(206, 12);
            listBoxAuthor.Name = "listBoxAuthor";
            listBoxAuthor.Size = new Size(174, 349);
            listBoxAuthor.TabIndex = 1;
            // 
            // listBoxYear
            // 
            listBoxYear.FormattingEnabled = true;
            listBoxYear.ItemHeight = 15;
            listBoxYear.Location = new Point(400, 12);
            listBoxYear.Name = "listBoxYear";
            listBoxYear.Size = new Size(174, 349);
            listBoxYear.TabIndex = 2;
            // 
            // textBoxTatle
            // 
            textBoxTatle.Location = new Point(580, 33);
            textBoxTatle.Name = "textBoxTatle";
            textBoxTatle.Size = new Size(193, 23);
            textBoxTatle.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(580, 86);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(193, 23);
            textBoxAuthor.TabIndex = 4;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(580, 140);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(193, 23);
            textBoxYear.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(580, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(580, 68);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(580, 122);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(580, 255);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(148, 44);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Добавить книгу";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDell
            // 
            buttonDell.Location = new Point(580, 317);
            buttonDell.Name = "buttonDell";
            buttonDell.Size = new Size(148, 44);
            buttonDell.TabIndex = 10;
            buttonDell.Text = "Удалить книгу";
            buttonDell.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { CountBook });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // CountBook
            // 
            CountBook.Name = "CountBook";
            CountBook.Size = new Size(118, 17);
            CountBook.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(buttonDell);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxTatle);
            Controls.Add(listBoxYear);
            Controls.Add(listBoxAuthor);
            Controls.Add(listBoxTitle);
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTitle;
        private ListBox listBoxAuthor;
        private ListBox listBoxYear;
        private TextBox textBoxTatle;
        private TextBox textBoxAuthor;
        private TextBox textBoxYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAdd;
        private Button buttonDell;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel CountBook;
    }
}
