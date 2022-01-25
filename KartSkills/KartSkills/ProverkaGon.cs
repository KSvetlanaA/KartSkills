using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class ProverkaGon : Form
    {
        public ProverkaGon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            (new Authoriz()).Show();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            (new Authoriz()).Show();
            this.Hide();
        }

        private void noButton_Click(object sender, EventArgs e)
        {

        }
    }
}
