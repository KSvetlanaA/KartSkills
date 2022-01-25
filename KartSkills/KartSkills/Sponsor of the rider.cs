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
    public partial class Sponsor_of_the_rider : Form
    {
        public Sponsor_of_the_rider()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new KartSkills()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Podtverz_Sponsora()).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pay = Convert.ToInt32(payTextBox.Text) + 10;
            payTextBox.Text = pay.ToString();
            numLabel.Text = "$ " + payTextBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pay = Convert.ToInt32(payTextBox.Text) - 10;
            payTextBox.Text = pay.ToString();
            numLabel.Text = "$ " + payTextBox.Text;
        }
    }
}
