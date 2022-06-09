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
        //este codigo oerimete mostrar el caracter de la contraseña ingresado por el usuario 

        private void btnVerPassword_Click(object sender, EventArgs e)
        {
          if (txtContraseña.PasswordChar == (char)0)  
                txtContraseña.PasswordChar = '*' ;
          else
                txtContraseña.PasswordChar = (char)0;

     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
            this.Hide();

        }
    }
    
}