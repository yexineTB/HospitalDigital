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
        //este codigo oerimete mostrar el caracter de la contrase�a ingresado por el usuario 

        private void btnVerPassword_Click(object sender, EventArgs e)
        {
          if (txtContrase�a.PasswordChar == (char)0)  
                txtContrase�a.PasswordChar = '*' ;
          else
                txtContrase�a.PasswordChar = (char)0;

     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
            this.Hide();

        }
    }
    
}