using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn_02
{
     public class Board
    {
		public const int BOARD_SIZE = 3;    //kích thước bàn cờ là 3 x 3 ô cờ
		public Cell[,] board;               // bàn cờ 9 ô
		public Board()
		{
            

            board = new Cell[BOARD_SIZE, BOARD_SIZE];
			for (int i = 0; i < BOARD_SIZE; i++)
			{
				for (int j = 0; j < BOARD_SIZE; j++)
				{
					board[i, j] = new Cell();   //mặc định tạo bàn cờ với ô rỗng (EMPTY)
				}
			}
		}
		public void printBoard()
		{
			int fieldNumber = 1; //hiện thị ô số mấy trên bàn cờ!
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("*******");
			/*******
             *1*2*3*
             *******
             *4*X*X*
             *******
             *7*O*9*
             *******/
			for (int i = 0; i < BOARD_SIZE; i++)
			{
				Console.Write("*");
				for (int j = 0; j < BOARD_SIZE; j++)
				{
					if (board[i, j].isEmpty())
					{
						Console.Write(fieldNumber);
						Console.ForegroundColor = ConsoleColor.Blue;
					}
					else
					{
						char c = (char)board[i, j].FieldState;
						if (c == 'X')
							Console.ForegroundColor = ConsoleColor.Green;
						else
							Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(c);
						Console.ForegroundColor = ConsoleColor.Blue;
					}
					fieldNumber++; //tăng giá trị ở ô hiển thị
					if (j < BOARD_SIZE - 1) Console.Write("*");
				}
				Console.WriteLine("*");
			}
			Console.WriteLine("*******");
		}

		public bool putMark(char c, int fieldNumber)
		{
			int x = (fieldNumber - 1) / BOARD_SIZE;
			int y = (fieldNumber - 1) % BOARD_SIZE;
			if (board[x, y].isEmpty())
			{
				board[x, y].markField(c);   //ô rỗng thì mới điền được
				return true;
			}

			//ô khác rỗng (đang có X hoặc Y)
			Console.WriteLine("This place is taken. Select the field again!!");
			return false;
		}

		public void clearBoard()
		{
			Console.Clear();
		}
	}
}
