namespace SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            
            while (CadastroUsuarios.UsuarioLogado == null)
            {
                Visible = false;
                f.ShowDialog();
                
                if(FormLogin.Cancelar)
                {
                    Application.Exit();
                    return;

                }

            }
            label_BoasVindas.Text = " Bem Vido (a) " +  CadastroUsuarios.UsuarioLogado.Nome ;
            Visible = true;

        }
    }
}