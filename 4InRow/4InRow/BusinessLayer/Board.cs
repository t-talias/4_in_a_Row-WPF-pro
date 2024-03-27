using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4InRow.BusinessLayer

{
    
    //0- תא ריק 
    //1- תא שייך שחקן 1
    //2- שייך לשחקן מספר 2

    public class Board
    {
       
        public int[,] GameBoard { get; set; }

        public Board()
        {
            this.GameBoard = new int[6, 7]; //  6x7
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    this.GameBoard[i, j] = 0; // התא ריק בהתחלה
                }
            }
        }

        public bool CheckWin(int currentPlayer)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (this.GameBoard[i, j] == currentPlayer)
                    {
                        // בדיקת שורה
                        if (j <= 3 && this.GameBoard[i, j + 1] == currentPlayer && this.GameBoard[i, j + 2] == currentPlayer && this.GameBoard[i, j + 3] == currentPlayer)
                            return true;
                        // בדיקת עמודה
                        if (i <= 2 && this.GameBoard[i + 1, j] == currentPlayer && this.GameBoard[i + 2, j] == currentPlayer && this.GameBoard[i + 3, j] == currentPlayer)
                            return true;
                        // בדיקת אלכסון ממזרח למערב
                        if (i <= 2 && j <= 3 && this.GameBoard[i + 1, j + 1] == currentPlayer && this.GameBoard[i + 2, j + 2] == currentPlayer && this.GameBoard[i + 3, j + 3] == currentPlayer)
                            return true;
                        // בדיקת אלכסון ממערב למזרח
                        if (i <= 2 && j >= 3 && this.GameBoard[i + 1, j - 1] == currentPlayer && this.GameBoard[i + 2, j - 2] == currentPlayer && this.GameBoard[i + 3, j - 3] == currentPlayer)
                            return true;
                    }
                }
            }
            return false;
        }

        public bool CheckDraw()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (this.GameBoard[i, j] == 0)
                    {
                        return false; // יש תא ריק, אז המשחק לא הסתיים בתיקו
                    }
                }
            }
            return true; // אין תאים ריקים, אז המשחק הסתיים בתיקו
        }


        public int MakeMove(int column, int currentPlayer)
        {
          
            // נמצא את השורה הראשונה הריקה בעמודה
            for (int i = 5; i >= 0; i--)
            {
                if (this.GameBoard[i, column] == 0)
                {
                    this.GameBoard[i, column] = currentPlayer;
                    return i;
                }
            }
            return -1;
        }
    }

}
