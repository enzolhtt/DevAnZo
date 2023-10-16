using Fulbank.Model.Repository;
using Fulbank.ViewModel;
using Fb_VM = Fulbank.ViewModel;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Fulbank.Model;

namespace Fulbank
{
    public partial class Login : Form
    {
        private Fb_VM.ConnexionViewModel connexionViewModel;
        private Model.Compte compte;
        public Login()
        {
            InitializeComponent();
            connexionViewModel = new ConnexionViewModel();
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            int NumCompte = int.Parse(tbx_user.Text);
            string MdpCompte = tbx_password.Text;
            if(connexionViewModel.TestConnexion(NumCompte, MdpCompte))
            {
                MessageBox.Show("Connexion r�ussie");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=172.16.119.21; uid=brochard;pwd=admin;database=FulBank";
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "select * from Client;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
    }
}