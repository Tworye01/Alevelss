using RocketShip;
using rocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace rocket
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void PlayB_Click(object sender, EventArgs e)
        {
            Form1 gameWindow = new Form1();
            gameWindow.Show();
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void HighS_Click(object sender, EventArgs e)
        {
            Form2 gameWindow = new Form2 ();
            gameWindow.Show();

        }

        private void controls_Click(object sender, EventArgs e)
        {
            settings gameWindow = new settings();
            gameWindow.Show();
        }
    }
    
}
