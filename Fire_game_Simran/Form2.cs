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
    public partial class Form2 : Form
    {
        //load the class in the memory to load the images 
        LoadPicture picture = new LoadPicture();
        
        Fire gunFire = new Fire();

        public int z = 0,zz=0;
        public Form2()
        {

            InitializeComponent();
            //disable all the button 
            Spin_btn.Enabled = false;
            shoot_btn.Enabled = false;
            shootaway_btn.Enabled = false;
            exit_btn.Enabled = false;
        }

        private void Sload_btn_Click(object sender, EventArgs e)
        {
            //disable  the button 
            Sload_btn.Enabled = false;
            //start the game 
            picture.StartGame(pbPictureBox);
            //enable the button 
            Spin_btn.Enabled = true;

        }

        private void Spin_btn_Click(object sender, EventArgs e)
        {
            //disable the button 
            Spin_btn.Enabled = false;

            //spin the game 
            picture.SpinGame(pbPictureBox);

            //enable the button to fire 
            shoot_btn.Enabled = true;
            shootaway_btn.Enabled = true;

        }

        private void shoot_btn_Click(object sender, EventArgs e)
        {
            z++;
            //spin the game 
            picture.ShootGame(pbPictureBox);
            //calling the method of the fire 

            int retrn = gunFire.shootFire(z,shoot_btn,shootaway_btn,exit_btn);


        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            //reset the game 
            z = 0;
            zz = 0;

            Application.Exit();

            exit_btn.Enabled = false;
            Sload_btn.Enabled = true;
        }

        private void shootaway_btn_Click(object sender, EventArgs e)
        {
            zz++;
            //spin the game 
            picture.ShootAwayGame(pbPictureBox);
            //calling the method of the fire 
            int retrn = gunFire.shootAwayFire(zz);
            if (zz == 2)
            {
                //MessageBox.Show("bullets are finished ");
                shootaway_btn.Enabled = false;
                shoot_btn.Enabled = false;
                exit_btn.Enabled = true;
            }
        }
    }
}
