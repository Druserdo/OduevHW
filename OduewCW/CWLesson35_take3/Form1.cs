namespace CWLesson35_take3
{
    public partial class Form1 : Form
    {
        private Converter converter;
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

        private void cbxLong_SelectedIndexChanged(object sender, EventArgs e)
        {
            converter = new Converter(double.Parse(tbNumber.Text));
            switch (cbxLong.SelectedIndex)
            {
                case 0: lbResult.Text = converter.toSm().ToString("F5") + " Sm"; break;
                case 1: lbResult.Text = converter.toDm().ToString("F5") + " Dm"; break;
                case 2: lbResult.Text = converter.toMetr().ToString("F5") + " Metr"; break;
                case 3: lbResult.Text = converter.toKm().ToString("F5") + " Km"; break;
            }
        }

        private void cbxTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            converter = new Converter(double.Parse(tbNumber.Text));
            switch (cbxLong.SelectedIndex)
            {
                case 0: lbResult.Text = converter.toKelvin().ToString("F5") + " Kl"; break;
                case 1: lbResult.Text = converter.toFarengait().ToString("F5") + " Fg"; break;
            }
        }

        private void cbxPressure_SelectedIndexChanged(object sender, EventArgs e)
        {
            converter = new Converter(double.Parse(tbNumber.Text));

            switch (cbxLong.SelectedIndex)
            {
                case 0: lbResult.Text = converter.toMmRtSt().ToString("F5") + " mm.rt.st"; break;
                case 1: lbResult.Text = converter.toBar().ToString("F5") + " Bar"; break;
                case 2: lbResult.Text = converter.toAtm().ToString("F5") + " Atm"; break;
                case 3: lbResult.Text = converter.toKs().ToString("F5") + " Ks"; break;
            }
        }
    }
}
