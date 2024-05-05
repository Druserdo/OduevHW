namespace CWLesson36
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
            lbxTask = new ListBox();
            lbxTaskDade = new ListBox();
            lbxTaskPrioritty = new ListBox();
            label4 = new Label();
            label5 = new Label();
            tbTask = new TextBox();
            label6 = new Label();
            btAdd = new Button();
            btDell = new Button();
            btEdit = new Button();
            lbxPriority = new ListBox();
            dtpTaskDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 0;
            label1.Text = "Задача";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 1;
            label2.Text = "Дата и время";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 2;
            label3.Text = "Приоритет";
            // 
            // lbxTask
            // 
            lbxTask.FormattingEnabled = true;
            lbxTask.ItemHeight = 23;
            lbxTask.Location = new Point(27, 42);
            lbxTask.Margin = new Padding(4, 5, 4, 5);
            lbxTask.Name = "lbxTask";
            lbxTask.Size = new Size(256, 303);
            lbxTask.TabIndex = 3;
            lbxTask.SelectedIndexChanged += lbxTask_SelectedIndexChanged;
            // 
            // lbxTaskDade
            // 
            lbxTaskDade.FormattingEnabled = true;
            lbxTaskDade.ItemHeight = 23;
            lbxTaskDade.Location = new Point(291, 42);
            lbxTaskDade.Margin = new Padding(4, 5, 4, 5);
            lbxTaskDade.Name = "lbxTaskDade";
            lbxTaskDade.Size = new Size(215, 303);
            lbxTaskDade.TabIndex = 4;
            // 
            // lbxTaskPrioritty
            // 
            lbxTaskPrioritty.FormattingEnabled = true;
            lbxTaskPrioritty.ItemHeight = 23;
            lbxTaskPrioritty.Location = new Point(514, 42);
            lbxTaskPrioritty.Margin = new Padding(4, 5, 4, 5);
            lbxTaskPrioritty.Name = "lbxTaskPrioritty";
            lbxTaskPrioritty.Size = new Size(230, 303);
            lbxTaskPrioritty.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(752, 14);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 23);
            label4.TabIndex = 6;
            label4.Text = "Укажите приоритет";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 351);
            label5.Name = "label5";
            label5.Size = new Size(203, 23);
            label5.TabIndex = 7;
            label5.Text = "Укажите текст задачи";
            // 
            // tbTask
            // 
            tbTask.Location = new Point(26, 395);
            tbTask.Name = "tbTask";
            tbTask.Size = new Size(717, 30);
            tbTask.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(748, 118);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(205, 23);
            label6.TabIndex = 9;
            label6.Text = "Укажите дату и время";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(748, 180);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(206, 77);
            btAdd.TabIndex = 10;
            btAdd.Text = "Добавить";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btDell
            // 
            btDell.Location = new Point(749, 263);
            btDell.Name = "btDell";
            btDell.Size = new Size(204, 82);
            btDell.TabIndex = 11;
            btDell.Text = "Удалить";
            btDell.UseVisualStyleBackColor = true;
            btDell.Click += btDell_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(749, 351);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(204, 74);
            btEdit.TabIndex = 12;
            btEdit.Text = "Перезаписать";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // lbxPriority
            // 
            lbxPriority.FormattingEnabled = true;
            lbxPriority.ItemHeight = 23;
            lbxPriority.Items.AddRange(new object[] { "Низкий", "Средний ", "Высокий" });
            lbxPriority.Location = new Point(750, 42);
            lbxPriority.Name = "lbxPriority";
            lbxPriority.Size = new Size(203, 73);
            lbxPriority.TabIndex = 13;
            // 
            // dtpTaskDate
            // 
            dtpTaskDate.Location = new Point(749, 144);
            dtpTaskDate.Name = "dtpTaskDate";
            dtpTaskDate.Size = new Size(205, 30);
            dtpTaskDate.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 445);
            Controls.Add(dtpTaskDate);
            Controls.Add(lbxPriority);
            Controls.Add(btEdit);
            Controls.Add(btDell);
            Controls.Add(btAdd);
            Controls.Add(label6);
            Controls.Add(tbTask);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbxTaskPrioritty);
            Controls.Add(lbxTaskDade);
            Controls.Add(lbxTask);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Урок 36";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lbxTask;
        private ListBox lbxTaskDade;
        private ListBox lbxTaskPrioritty;
        private Label label4;
        private Label label5;
        private TextBox tbTask;
        private Label label6;
        private Button btAdd;
        private Button btDell;
        private Button btEdit;
        private ListBox lbxPriority;
        private DateTimePicker dtpTaskDate;
    }
}
