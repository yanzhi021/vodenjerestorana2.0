namespace vodenjerestorana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGost_Click(object sender, EventArgs e)
        {
            Form Gost = new Gost();
            Gost.Show();
        }

        private void btnUpravitelj_Click(object sender, EventArgs e)
        {
            Form Upravitelj = new Upravitelj();
            Upravitelj.Show();
        }
    }
}