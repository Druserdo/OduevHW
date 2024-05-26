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
                case 1:LResul.Text = "\"Успех - это способность идти от одной неудачи к другой, не потеряв энтузиазма.\" \n Уинстон Черчилль"; 
                    break;
                case 2:LResul.Text = "\"Будь изменением, которое ты хочешь видеть в мире.\" \nМахатма Ганди";
                    break;
                case 3:LResul.Text = "\"Лучший способ предсказать будущее - создать его.\" \nПитер Друкер";    break;
                case 4:LResul.Text= "\"Сложности - это возможности, скрытые в обманчивой обертке.\" \nАльберт Эйнштейн"; 
                    break;
                case 5:LResul.Text = "\"Не важно, сколько раз вы падаете - важно, сколько раз вы поднимаетесь.\" \nМэрилин Монро";
                    break;
            }
        }
    }
}
