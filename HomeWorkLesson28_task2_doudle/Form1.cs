using System.Windows.Forms;

namespace HomeWorkLesson28_task2_doudle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void bGenerator_Click(object sender, EventArgs e)
        {
            PasswordGenerator passwordGenerator = new PasswordGenerator();
            string newPassword = passwordGenerator.HeawyPass().ToString();
            lbLogin.Items.Add(tbUserName.Text);
            lbPassword.Items.Add(newPassword);
            tbUserName.Clear();

        }

        private void bDell_Click(object sender, EventArgs e)
        {
            try
            {
                lbPassword.Items.RemoveAt(lbLogin.SelectedIndex);
                lbLogin.Items.RemoveAt(lbLogin.SelectedIndex);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Выберете запись!");
            }
           
        }
    }
}
