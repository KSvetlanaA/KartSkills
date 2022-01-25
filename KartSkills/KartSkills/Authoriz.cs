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
    public partial class Authoriz : Form
    {
        public Authoriz()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            gonButton.Visible = true;
            koordButton.Visible = true;
            adminButton.Visible = true;
            //(new Authoriz()).Show();
            //this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {

        }

        private void koordButton_Click(object sender, EventArgs e)
        {

        }

        private void Authoriz_Load(object sender, EventArgs e)
        {

        }

        private void gonButton_Click_1(object sender, EventArgs e)
        {
            (new MenuGon()).Show();
            this.Hide();
        }

        private void koordButton_Click_1(object sender, EventArgs e)
        {
            (new MenuKoord()).Show();
            this.Hide();
        }

        private void adminButton_Click_1(object sender, EventArgs e)
        {
            (new MenuAdmin()).Show();
            this.Hide();
        }
    }
}
