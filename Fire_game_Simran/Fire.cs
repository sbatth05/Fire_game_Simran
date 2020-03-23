using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_game_Simran
{
    public class Fire
    {
        Random instance = new Random();
        int trig = 0,counter=0;
        int trigShoot = 0,CounterShoot=0;

        public int shootFire(int z,Button btnshoot,Button btnShootAway,Button ext) {
            System.Media.SoundPlayer playSound = new System.Media.SoundPlayer(Fire_game_Simran.Properties.Resources.fire);
            playSound.Play();

            //generate the no 
            if (z == 1)
            {
                //gen the no 
                trig = instance.Next(1, 8);
            }
            else if (z == trig)
            {
                //when the counter match with the trigger after that generate  the sound of fire 
                counter++;
                MessageBox.Show("You are die ");
                btnshoot.Enabled = false;
                btnShootAway.Enabled = false;
                ext.Enabled = true;

            }
            else if (z == 4)
            {
                MessageBox.Show(" You are Survived ");
                btnshoot.Enabled = false;
                btnShootAway.Enabled = false;
                ext.Enabled = true;
            }
            else {
                MessageBox.Show("try again ");
            }
            //return the counter 
            return counter;
        }


        public int shootAwayFire(int z)
        {
            //when the counter match with the trigger after that generate  the sound of fire 
            System.Media.SoundPlayer playSound = new System.Media.SoundPlayer(Fire_game_Simran.Properties.Resources.fire);
            playSound.Play();

            //generate the no 
            if (z == 1)
            {
                //gen the no 
                trigShoot = instance.Next(1, 6);
            }
            else if (z == trigShoot)
            {
                CounterShoot++;
                MessageBox.Show("You are going to die ");
            }
            else if (z == 2)
            {
                MessageBox.Show("You are survive ");
            }
            
            //return the counter 
            return CounterShoot;
        }


    }
}
