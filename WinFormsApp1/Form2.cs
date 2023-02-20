using rocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RocketShip;

namespace RocketShip
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
  

        private void ExitB_Click(object sender, EventArgs e)
        {
            Menu gameWindow = new Menu();
            gameWindow.Show();
        }

     
    }
}
