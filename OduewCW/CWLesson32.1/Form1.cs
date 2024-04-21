namespace CWLesson32._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chbMark_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMark.Checked)
            {
                chbMark.Text = "Километры > милли";
                lbMark.Text = "Километры";
            }
            else
            {
                chbMark.Text = "милли > Километры";
                lbMark.Text = "милли";
            }
        }

        private void btMark_Click(object sender, EventArgs e)
        {
            const double MILLS = 1.62;
            double mark;
            double.TryParse(tbMark.Text, out mark);
            if (chbMark.Checked)
            {
                lbResult.Text = $"{mark}км ={mark / MILLS:F3} милль";
            }
            else
            {
                lbResult.Text = $"{mark}миль ={mark * MILLS:F3} км";
            }
        }

        private void tbMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (tbMark.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btMark.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void tbMark_TextChanged(object sender, EventArgs e)
        {

            btMark_Click(sender, e);
        }
    }
}
