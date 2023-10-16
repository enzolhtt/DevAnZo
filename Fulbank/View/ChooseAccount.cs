using Fulbank.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank
{
    public partial class ChooseAccount : Form
    {
        public ChooseAccount()
        {
            InitializeComponent();
        }

        private void bt_courant_Click(object sender, EventArgs e)
        {
            CompteCourant compteCourant = new CompteCourant();
            compteCourant.Show();
            this.Hide();
        }
    }
}
