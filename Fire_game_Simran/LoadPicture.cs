using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_game_Simran
{
    //this class is used to load the picture of the gun 
    public class LoadPicture
    {
        //start the game 
        public void StartGame(PictureBox photo) {
            photo.Image = Fire_game_Simran.Properties.Resources.gun_load;
        }

        //spin the gun
        public void SpinGame(PictureBox photo)
        {
            photo.Image = Fire_game_Simran.Properties.Resources.gun_spin;
        }

        //shoot the gun
        public void ShootGame(PictureBox photo)
        {
            photo.Image = Fire_game_Simran.Properties.Resources.gun_shhoot;
        }
        //shootAway the game 
        public void ShootAwayGame(PictureBox photo)
        {
            photo.Image = Fire_game_Simran.Properties.Resources.gun_shhot_away;
        }

    }
}
