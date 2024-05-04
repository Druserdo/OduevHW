namespace CWLesson35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = GenerateColor();
            this.BackColor = GenerateColor();
            
        }
        private Color GenerateColor()
        {
            Random rnd = new Random();
            return Color.FromArgb(rnd.Next(0, 255), rnd.Next(0,255), rnd.Next(0,255));
        }
    }
}
