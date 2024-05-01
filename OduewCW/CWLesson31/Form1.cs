namespace CWLesson31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbFirst_Click(object sender, EventArgs e)
        {

        }

        private void btEdd_Click(object sender, EventArgs e)
        {

        }

        private void btSub_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                double s = x - y;
                lbResult.Text = $"{x}-{y}={s}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                double s = x * y;
                lbResult.Text = $"{x}*{y}={s}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                if (y == 0) throw new DivideByZeroException();
                double s = x / y;
                lbResult.Text = $"{x}/{y}={s}";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Делить на ноль нельзя!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btEdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                double s = x + y;
                lbResult.Text = $"{x}+{y}={s}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbFirst.Clear();
            tbSecond.Clear();
        }
    }
}
