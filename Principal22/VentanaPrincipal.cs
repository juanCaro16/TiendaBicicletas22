namespace Principal22
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaLogin ventanaLogin = new VentanaLogin();
            ventanaLogin.Show();
            


        }
    }
}
