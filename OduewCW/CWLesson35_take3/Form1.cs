namespace CWLesson35_take3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Generation generation = new Generation(int.Parse(tbFrom.Text), int.Parse(tbUntil.Text));
                tbResult.Text = generation.getNumber().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
