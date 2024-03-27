using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4InRow.BusinessLayer
{
    //This department shows a player, his name and what he represents
    //1- Yellow
    //2- red
    public class Player
    {
        public int CurrentPlayer { get; set; }

        public Player()
        {
            this.CurrentPlayer = 1; // השחקן הראשון מתחיל
        }

        public void SwitchPlayer()
        {
            if (this.CurrentPlayer == 1)
            {
                this.CurrentPlayer = 2;
            }
            else
            {
                this.CurrentPlayer = 1;
            }
        }
    }

}
