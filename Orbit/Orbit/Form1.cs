namespace Orbit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeAPI form2 = new InitializeAPI();
            form2.Show();
        }
    }
}