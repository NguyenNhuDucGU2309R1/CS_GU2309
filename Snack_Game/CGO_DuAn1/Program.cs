using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CGO_DuAn1
{
    class TestSnake
    {
        #region parameter
        public Random rand = new Random();
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        int score, headX, headY, fruitX, fruitY, nTail, speed, typeFruit;
        int[] TailX = new int[100];
        int[] TailY = new int[100];
        const int height = 20;
        const int width = 60;
        const int panel = 10;
        bool gameOver, reset, isprinted, horizontal, vertical;
        string dir, pre_dir;
        int max = 0, highScore;
        string fullPath = "data.txt";
        #endregion

        int LoadHighestScore()
        {
            // Read a file
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
            return int.Parse(readText); 
        }

        void SaveHighScore(int score)
        {
            // Write file using StreamWriter
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine(score);
            }
        }

        //Hien thi man hinh bat dau
        void ShowBanner()
        {
            speed = 200;
            highScore = LoadHighestScore();
            Console.SetWindowSize(width, height + panel);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;

            Console.WriteLine("============================================");
            Console.WriteLine("=================SNAKE GAME=================");
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine("Pres any key to play");
            Console.WriteLine("Tips: - Use Arrow button to move the snake");
            Console.WriteLine("      - Press key P to pause game         ");
            Console.WriteLine("      - Press key R to reset game         ");
            Console.WriteLine("      - Press key Q to quit game          ");

            keypress = Console.ReadKey(true);
            if (keypress.Key == ConsoleKey.Q)
                Environment.Exit(0);

        }
        //Cai dat ban dau
        void Setup()
        {
            dir = "RIGHT"; pre_dir = "";
            score = nTail = 0;
            gameOver = reset = isprinted = false;
            headX = width / 2; headY = height / 2;
            //random diem an qua
            randomQua();
        }
        //Random diem an qua
         void randomQua()
        {
            fruitX = rand.Next(1, width - 1);
            fruitY = rand.Next(1, height - 1);

            typeFruit = rand.Next(1, 5);
        }
        //Cap nhat man hinh
        void Update()
        {
            while (!gameOver)
            {
                CheckInput();
                Logic();
                Render();
                if (reset)
                {
                    speed = 200;
                    break;
                }
                Thread.Sleep(speed);
            }

            if (gameOver) Lose();
        }
        //Dieu khien phim
        void CheckInput()
        {
            while (Console.KeyAvailable)
            {
                keypress = Console.ReadKey(true);
                pre_dir = dir;
                switch (keypress.Key)
                {
                    case ConsoleKey.Q: Environment.Exit(0); break;
                    case ConsoleKey.P: dir = "STOP"; break;
                    case ConsoleKey.LeftArrow: dir = "LEFT"; break;
                    case ConsoleKey.RightArrow: dir = "RIGHT"; break;
                    case ConsoleKey.UpArrow: dir = "UP"; break;
                    case ConsoleKey.DownArrow: dir = "DOWN"; break;
                }
            }
        }
        //Kiem tra dieu huong
        void Logic()
        {
            int preX = TailX[0], preY = TailY[0];
            int tempX, tempY;

            if (dir != "STOP")
            {
                TailX[0] = headX; TailY[0] = headY; //them 1ptu
                for (int i = 1; i < nTail; i++)
                {   //0 i1 i2 i3 => (pre=0)  => 0 0 i1 i2 i3
                    tempX = TailX[i];
                    tempY = TailY[i]; //temp=i1
                    TailX[i] = preX;
                    TailY[i] = preY;  //i1= pre
                    preX = tempX;
                    preY = tempY;     //pre=i1
                }
            }

            switch (dir)
            {
                case "RIGHT": headX++; break;
                case "LEFT": headX--; break;
                case "UP": headY--; break;
                case "DOWN": headY++; break;
                case "STOP":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Game paused");
                            Console.WriteLine();
                            Console.WriteLine("      - Press key P to pause game            ");
                            Console.WriteLine("      - Press key R to reset game            ");
                            Console.WriteLine("      - Press key Q to quit game             ");

                            keypress = Console.ReadKey(true);
                            if (keypress.Key == ConsoleKey.Q)
                                Environment.Exit(0);
                            if (keypress.Key == ConsoleKey.R)
                            {
                                reset = true; break;
                            }
                            if (keypress.Key == ConsoleKey.P)
                                break;
                        }
                        dir = pre_dir; break;
                    }
            }
            //kiem tra va cham bien
            if (headX <= 0 || headX >= width - 1 || headY <= 0 || headY >= height - 1) gameOver = true;
            else gameOver = false;
            //kiem tra an qua
            if (headX == fruitX && headY == fruitY)
            {
                score += 2 * typeFruit; nTail++;
                if (score > 20) speed -= 20;
                else if (score > 50) speed -= 50    ;
                
                // xử lý điểm lớn nhất
                if (score > highScore)
                {
                    highScore = score;

                    SaveHighScore(highScore);
                }
                randomQua();
            }

            if (((dir == "LEFT" && pre_dir != "UP") && (dir == "LEFT" && pre_dir != "DOWN")) || (
                (dir == "RIGHT" && pre_dir != "UP") && (dir == "RIGHT" && pre_dir != "DOWN")))
                horizontal = true;
            else horizontal = false;

            if (((dir == "UP" && pre_dir != "LEFT") && (dir == "UP" && pre_dir != "RIGHT")) || (
                (dir == "DOWN" && pre_dir != "LEFT") && (dir == "DOWN" && pre_dir != "RIGHT")))
                vertical = true;
            else vertical = false;

            for (int i = 1; i < nTail; i++)
            {
                if (TailX[i] == headX && TailY[i] == headY)
                {
                    if (horizontal || vertical)
                        gameOver = false;
                    else
                        gameOver = true;
                }
                if (TailX[i] == fruitX && TailY[i] == fruitY)
                    randomQua();
            }
        }
        //Hien thi doi tuong
        void Render()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                    {
                        //vien khung
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("=");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (j == 0 || j == width - 1)
                    {
                        //vien khung
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("=");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (j == fruitX && i == fruitY)//qua
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" * ");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (j == headX && i == headY)
                    {
                        //Dau con ran
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("+");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        isprinted = false;
                        for (int k = 0; k < nTail; k++)
                        {
                            if (TailX[k] == j && TailY[k] == i)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("*");     //Than con ran
                                Console.ForegroundColor = ConsoleColor.Green;
                                isprinted = true;
                            }
                        }
                        if (!isprinted) Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Your score: " + score + " High Score: " + highScore);
        }
        //Xu ly khi THUA
        void Lose()
        {
            Console.WriteLine("YOU DIED");
            Console.WriteLine("POINT MAX: {0}", max);
            Console.WriteLine("Press R to Reset game");
            Console.WriteLine("Press Q to Quit game");
            while (true)
            {
                keypress = Console.ReadKey(true);
                if (keypress.Key == ConsoleKey.Q) Environment.Exit(0);
                if (keypress.Key == ConsoleKey.R)
                {
                    reset = true; break;
                }
            }
        }

        public static void Main()
        {
            TestSnake snake = new TestSnake();
            snake.ShowBanner();
            while (true)
            {
                snake.Setup();
                snake.Update();
                Console.Clear();
            }
        }
    }
}

