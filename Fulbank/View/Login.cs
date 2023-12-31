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
        public static int NumCompte;
        public Login()
        {
            InitializeComponent();
            connexionViewModel = new ConnexionViewModel();
        }

        private void bt_connecter_Click(object sender, EventArgs e)
        {
             NumCompte = int.Parse(tbx_user.Text);
             string MdpCompte = tbx_password.Text;
            if (connexionViewModel.TestConnexion(NumCompte, MdpCompte))
            {
                ChooseAccount chooseAccount = new ChooseAccount(NumCompte);
                chooseAccount.Show();
                this.Hide();
            }
        }
    }
}