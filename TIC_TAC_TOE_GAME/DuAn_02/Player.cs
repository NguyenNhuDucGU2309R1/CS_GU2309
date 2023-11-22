using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn_02
{
     class Player
    {
        char sign; //ký hiệu người X hoăc O

        public Player(char sign = 'X')
        {
            this.Sign = sign;
        }

        public char Sign { get => sign; set => sign = value; }
        //nhập ô vị trí của người chơi
        public int takeTurn()
        {
            int fieldNumber = int.Parse(Console.ReadLine());    //BT: check logic nhập xuất 1-> 9, nếu 10 là chịu thua
            return fieldNumber;
        }

        public bool checkSign(FIELD c1, FIELD c2, FIELD c3)
        {
            //3 ô cùng 1 ký tự X hoặc Y (chắc chắn khác rỗng)
            return ((c1 == c2) && (c1 == c3) && c1 != FIELD.FLD_EMPTY);
        }
        public bool checkRowsForWin(Board gameboard)
        {
            /***hàng ngang:
                table[0,j]
                table[1,j]
                table[2,j]
             * **/
            for (int i = 0; i < Board.BOARD_SIZE; i++)
            {
                if (checkSign(gameboard.board[0, i].FieldState, gameboard.board[1, i].FieldState, gameboard.board[2, i].FieldState))
                    return true;
            }
            return false;
        }
        public bool checkColsForWin(Board gameboard)
        {
            /***hàng dọc:
                table[i,0]
                table[i,1]
                table[i,2]
             * **/
            for (int i = 0; i < Board.BOARD_SIZE; i++)
            {
                if (checkSign(gameboard.board[i, 0].FieldState, gameboard.board[i, 1].FieldState, gameboard.board[i, 2].FieldState))
                    return true;
            }
            return false;
        }
        public bool checkDiagonalsForWin(Board gameboard)
        {
            /***hàng chéo:
            chéo chính: table[i,i]: table[0,0] table[1,1] table[2,2]
            chéo phụ:  table[i,3-i-1]:table[0,2] table[1,1] table[2,0]
             * **/
            bool flag = false;
            if (checkSign(gameboard.board[0, 0].FieldState, gameboard.board[1, 1].FieldState, gameboard.board[2, 2].FieldState))
                flag = true;
            if (checkSign(gameboard.board[2, 0].FieldState, gameboard.board[1, 1].FieldState, gameboard.board[0, 2].FieldState))
                flag = true;
            return flag;
        }
        public bool checkWin(Board gameboard)
        {
            return (checkColsForWin(gameboard) || checkRowsForWin(gameboard)
                || checkDiagonalsForWin(gameboard));
        }
    }
}
