namespace Lesson32._3
{
    public partial class Form1 : Form
    {
        private double Price;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbxMaterial.SelectedIndex)
            {
                case 0:
                    {
                        Calculite("all.jpeg", 180, sender, e);
                    }
                    break;
                case 1:
                    {
                        Calculite("plas.jpg", 180, sender, e);
                    }
                    break;
                case 2:
                    {

                        Calculite("wood.jpg", 180, sender, e);
                    }
                    break;
                case 3:
                    {
                        Calculite("bambuk.jpg", 180, sender, e);
                    }
                    break;
            }
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            lbResult.Text=(double.Parse(tbWidth.Text)*double.Parse(tbHeight.Text)*Price).ToString("c");
        }
        void Calculite(string path, double price, object sender, EventArgs e)
        {
            pbxMaterial.Image = Image.FromFile(path);
            Price = price;
            btResult_Click(sender, e);
        }
    }
}
