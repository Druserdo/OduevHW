namespace HomeWorkLesson28_task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(1, 6);
                switch(rnd)
            {
                case 1:LResul.Text = "\"����� - ��� ����������� ���� �� ����� ������� � ������, �� ������� ����������.\" \n ������� ��������"; 
                    break;
                case 2:LResul.Text = "\"���� ����������, ������� �� ������ ������ � ����.\" \n������� �����";
                    break;
                case 3:LResul.Text = "\"������ ������ ����������� ������� - ������� ���.\" \n����� ������";    break;
                case 4:LResul.Text= "\"��������� - ��� �����������, ������� � ���������� �������.\" \n������� ��������"; 
                    break;
                case 5:LResul.Text = "\"�� �����, ������� ��� �� ������� - �����, ������� ��� �� ������������.\" \n������� �����";
                    break;
            }
        }
    }
}
