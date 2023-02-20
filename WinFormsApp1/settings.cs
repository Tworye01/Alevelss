using rocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RocketShip
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void Exit_Click(object sender, EventArgs e)
        {
            Menu gameWindow = new Menu();
            gameWindow.Show();
        }
    }

}
