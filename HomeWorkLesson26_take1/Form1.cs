namespace HomeWorkLesson26_take1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTags_Click(object sender, EventArgs e)
        {
            if (cbx1.Checked == true&& cbx2.Checked==false&& cbx2.Checked==false) MessageBox.Show("Флажок 1 выбран");

            else
            {
                if (cbx2.Checked == true && cbx1.Checked == false && cbx3.Checked == false) MessageBox.Show("Флажок 2 выбран");
                else 
                { 
                    if ( cbx3.Checked == true && cbx2.Checked == false &&cbx1.Checked == false) MessageBox.Show("Флажок 3 выбран");
                }
            }
        }

      
    }
}
