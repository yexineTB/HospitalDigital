namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
            this.Hide();

        }
    }
}