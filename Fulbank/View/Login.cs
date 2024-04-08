using Fulbank.Model.Repository;
using Fulbank.ViewModel;
using Fb_VM = Fulbank.ViewModel;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Fulbank.Model;
using Fulbank.View;
using System.Text;

namespace Fulbank
{
    public partial class Login : Form
    {
        private Fb_VM.ConnexionViewModel connexionViewModel;
        private Fb_VM.ClientViewModel clientViewModel;
        public Dictionary<int, string> DicoNumCompte;
        private Model.Compte compte;
        public static int idClient;
        public Login()
        {
            int idClientActuel = idClient;
            InitializeComponent();
            connexionViewModel = new ConnexionViewModel();
            clientViewModel = new ClientViewModel();
            DicoNumCompte = clientViewModel.getNumCompteByIdClient(idClientActuel);
        }

        private void bt_connecter_Click(object sender, EventArgs e)
        {
            static string ToSHA256(string s)
            {
                using var sha256 = SHA256.Create();
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

                var sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }

            idClient = int.Parse(tbx_user.Text);
            Dictionary<int, string> DicoNumCompte = clientViewModel.getNumCompteByIdClient(idClient);
            if (DicoNumCompte is null)
            {
                MessageBox.Show("Vous n'avez aucun compte lié à votre compte client");
            }
            string MdpCompte = tbx_password.Text;
            if (connexionViewModel.TestConnexion(idClient) == ToSHA256(MdpCompte))
            {
                //MessageBox.Show("Dico " + DicoNumCompte);
                ChooseAccount chooseAccount = new ChooseAccount(DicoNumCompte, idClient);
                chooseAccount.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Le mot de passe ne correspond pas au numéro du compte");
            }
        }

        private void tbx_user_Click(object sender, EventArgs e)
        {
            tbx_user.Text = "";
        }

        private void tbx_password_Click(object sender, EventArgs e)
        {
            tbx_password.Text = "";
        }

        private void tbx_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            static string ToSHA256(string s)
            {
                using var sha256 = SHA256.Create();
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

                var sb = new StringBuilder();
                for (int i = 0; i  < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }

            idClient = int.Parse(tbx_user.Text);
            Dictionary<int, string> DicoNumCompte = clientViewModel.getNumCompteByIdClient(idClient);
            if (e.KeyChar == (char)Keys.Enter)
            {
                idClient = int.Parse(tbx_user.Text);
                string MdpCompte = tbx_password.Text;
                if (connexionViewModel.TestConnexion(idClient) == ToSHA256(MdpCompte))
                {
                    ChooseAccount chooseAccount = new ChooseAccount(DicoNumCompte, idClient);
                    chooseAccount.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Le mot de passe ne correspond pas au numéro du compte");
                }
            }
        }
    }
}