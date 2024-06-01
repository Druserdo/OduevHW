using System.IO;

namespace HomeWorkLesson28_task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] massElements = File.ReadAllLines($@"{tbxPuth.Text}");
            
        }

        private void bAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
