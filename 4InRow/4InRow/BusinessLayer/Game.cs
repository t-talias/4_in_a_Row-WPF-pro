using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4InRow.BusinessLayer
{
    public class Game
    {
        public Player CurrentPlayer { get; set; }
        public Board GameBoard { get; set; }

        public bool win;
        public bool draw;

        public Game()
        {
            this.GameBoard = new Board();
            this.CurrentPlayer = new Player();
            this.win = false;
            this.draw = false;
        }

        public void StartNewGame()
        {
            this.GameBoard = new Board();
            this.CurrentPlayer = new Player();
        }

        public int PlayerMove(int column)
        {
           int row = this.GameBoard.MakeMove(column, this.CurrentPlayer.CurrentPlayer);
            if (this.GameBoard.CheckWin(this.CurrentPlayer.CurrentPlayer))
            {
                this.win = true;
            }
            else if (this.GameBoard.CheckDraw())
            {
                this.draw = true;
            }
            else if(row != -1)
            {
                this.CurrentPlayer.SwitchPlayer();
            }
            return row;
            //            if (!this.GameBoard.CheckWin(this.CurrentPlayer.CurrentPlayer) && !this.GameBoard.CheckDraw())
        }
    }

}
