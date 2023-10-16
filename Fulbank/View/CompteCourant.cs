using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank.View
{
    public partial class CompteCourant : Form
    {
        public CompteCourant()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChooseAccount retour = new ChooseAccount();
            retour.Show();
            this.Hide();
        }

        private void CompteCourant_Load(object sender, EventArgs e)
        {
            
        }
    }
}
