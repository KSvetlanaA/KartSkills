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
    public partial class KartSkills : Form
    {
        public KartSkills()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            (new Sponsor_of_the_rider()).Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            (new ProverkaGon()).Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            (new Podrob_Inf()).Show();
            this.Hide();
        }
    }
}
