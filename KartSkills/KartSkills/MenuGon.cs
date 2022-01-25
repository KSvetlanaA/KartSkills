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
    public partial class MenuGon : Form
    {
        public MenuGon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new KartSkills()).Show();
        }

        private void kontaktaButton_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            konuLabel.Visible = true;
            phoneLabel.Visible = true;
            numLabel.Visible = true;
            emailLabel.Visible = true;
            pochLabel.Visible = true;
            exitLabel.Visible = true;
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            konuLabel.Visible = false;
            phoneLabel.Visible = false;
            numLabel.Visible = false;
            emailLabel.Visible = false;
            pochLabel.Visible = false;
            exitLabel.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resultButton_Click(object sender, EventArgs e)
        {

        }

        private void registButton_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void redButton_Click(object sender, EventArgs e)
        {

        }

        private void sponsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
