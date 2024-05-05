namespace CWLesson36
{
    public partial class Form1 : Form
    {
        private List<MyTask> myTasks;
        public Form1()
        {
            InitializeComponent();
            myTasks = new List<MyTask>();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddTask(tbTask.Text, dtpTaskDate.Value, lbxPriority.SelectedItem.ToString()!);
        }
        private void btDell_Click(object sender, EventArgs e)
        {
            int index = lbxTask.SelectedIndex;
            myTasks.RemoveAt(index);
            lbxTask.Items.RemoveAt(index);
            lbxTaskDade.Items.RemoveAt(index);
            lbxTaskPrioritty.Items.RemoveAt(index);
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
          int index=lbxTask.SelectedIndex;
            MyTask currentTask = myTasks[index];
            currentTask.setTaskName(tbTask.Text);
            currentTask.setPriority(lbxPriority.Text);
            currentTask.setDateTime(dtpTaskDate.Value);
            lbxTask.Items[index] = currentTask.getTaskName;
            lbxTaskDade.Items[index] = currentTask.getTaskDateTime;
            lbxTaskPrioritty.Items[index]=currentTask.getPriority();
        }
        private void lbxTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxTask.SelectedIndex;
            MyTask currentTask= myTasks[index];
            tbTask.Text=currentTask.getTaskName();
            lbxPriority.Text=currentTask.getPriority();
            dtpTaskDate.Value=currentTask.getTaskDateTime();
        }


        private void ClearForm()
        {
            tbTask.Text = "";
            dtpTaskDate.Value = DateTime.Now;
            lbxPriority.SelectedIndex = -1;
        }
        private void AddTask(string task, DateTime dt, string p)
        {
            MyTask myTask = new MyTask(task, dt, p);
            myTasks.Add(myTask);
            lbxTask.Items.Add(tbTask.Text);
            lbxTaskDade.Items.Add(dtpTaskDate.Value);
            lbxTaskPrioritty.Items.Add(lbxPriority.SelectedItem.ToString()!);
            ClearForm();
        }
    }

}
