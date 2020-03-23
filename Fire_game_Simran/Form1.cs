using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_game_Simran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            //while clicking on the button the game will be start
            Form2 instance_obj = new Form2();
            //display the next page 
            instance_obj.Show();
            this.Visible = false;
        }
    }
}
