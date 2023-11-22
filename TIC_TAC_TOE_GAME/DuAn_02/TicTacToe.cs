using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn_02
{

    class TicTacToe
    {


        public TicTacToe()
        {

        }
        public void Menu()
        {
            
           // do
           /// {
          Home:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hay Chon Che Do Choi");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n1.Nguoi Voi May");
                Console.Write("\n2.Nguoi Voi Nguoi");
                Console.WriteLine("\n3.Thoat");
            Console.BackgroundColor = ConsoleColor.Red;
               int  choice = int.Parse(Console.ReadLine());
            
            switch (choice)
                {
                    case 1: play(); goto Home;
                    case 2: play2(); goto Home;
                    case 3: goto Thoat;

                    //default: Console.WriteLine("ko hop le , moi nhap lai "); break;
                }
            //} while (choice != 3);
            Thoat:
            
            Console.ReadLine();
           
        }
        public void play2()
        { 
            int moveCounter = 0;    //xác định người chơi chẵn= player1 / lẻ= player2
           Board gameBoard = new Board();
            Player playerX = new Player('X');
            Player playerO = new Player('O');
            Player currentPlayer = playerX; //xác định lượt chơi đầu tiên
           bool play = true;           //thiết menu số 1-9 chơi
            while (play)
           {
                gameBoard.printBoard();     //in bàn cờ
               Console.WriteLine("Player {0} enter the field in which you want to put the number:", currentPlayer.Sign);    //chờ ng dùng nhập dữ liệu
            getTurn:
                try
                {
                    //xác định lượt và số number
                   int turn = currentPlayer.takeTurn();    //nhập dữ liệu
                    if (!gameBoard.putMark(currentPlayer.Sign, turn))
                   {
                        xulySai();
                       goto getTurn;
                   }
                   else
                    {
                        gameBoard.clearBoard();
                       moveCounter++;  //tối đa lên tới 9
                                       //kiểm tra đã thắng chưa
                       if (currentPlayer.checkWin(gameBoard))
                        {
                           Console.WriteLine("Player {0} won!", currentPlayer.Sign);
                            gameBoard.printBoard();
                            play = false;
                        }
                        //kiểm tra có hòa chưa
                       else if (moveCounter == 9)
                       {
                            Console.WriteLine("Draw!");
                            gameBoard.printBoard();
                            play = false;
                       }
                       //ko thắng , ko hòa -> đi tiếp
                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                   }
                    
               }
               catch (Exception  ex)
                {
                   xulySai();
                   goto getTurn;
               }
            }
        }
        public void play()
        {
            int moveCounter = 0;    //xác định người chơi chẵn= player1 / lẻ= player2
            Board gameBoard = new Board();
            Player playerX = new Player('X');
            Robot playerO = new Robot('O'); //## //Player playerO = new Player('O');
            Player currentPlayer = playerX; //xác định lượt chơi đầu tiên
            bool play = true;           //thiết menu số 1-9 chơi
            while (play)
            {
                gameBoard.printBoard();     //in bàn cờ
                Console.WriteLine("Player {0} enter the field in which you want to put the number:", currentPlayer.Sign);    //chờ ng dùng nhập dữ liệu
            getTurn:
                try
                {
                    //xác định lượt và số number
                    //int turn = currentPlayer.takeTurn();    //nhập dữ liệu
                    int turn = (moveCounter % 2 == 0) ? playerX.takeTurn() : playerO.takeTurn(); //##
                    char c = (moveCounter % 2 == 0) ? playerX.Sign : playerO.Sign;               //##
                                                                                                 //if (!gameBoard.putMark(currentPlayer.Sign, turn))
                    if (!gameBoard.putMark(c, turn)) //##
                    {
                        xulySai();
                        goto getTurn;
                    }
                    else
                    {
                        playerO.removeChoose(turn); //##
                        gameBoard.clearBoard();
                        moveCounter++;  //tối đa lên tới 9
                                        //kiểm tra đã thắng chưa
                        if (currentPlayer.checkWin(gameBoard))
                        {
                            Console.WriteLine("Player {0} won!", currentPlayer.Sign);
                            gameBoard.printBoard();
                            play = false;
                        }
                        //kiểm tra có hòa chưa
                        else if (moveCounter == 9)
                        {
                            Console.WriteLine("Draw!");
                            gameBoard.printBoard();
                            play = false;
                        }
                        //ko thắng , ko hòa -> đi tiếp
                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                    }
                }

                catch (Exception ex)    //Bẫy lỗi tổng quát: RUN lên mới biết
                {
                    Console.WriteLine(ex.Message);
                   xulySai();      //ném lỗi throw exception <custom exception>
                  goto getTurn;
                }
            }
        }

        private void xulySai()  //throw new exception
        {
            Console.WriteLine("Invalid input. Please enter number between 1- 9!");
        }

        
    }
}
