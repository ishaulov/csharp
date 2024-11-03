namespace myfirstapp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          WriteTable(6, "testtt");

          /*
          int inputNumber = int.Parse(Console.ReadLine());
          string? inputString = Console.ReadLine();

          WriteTable(inputNumber, inputString);
          */
        }

        private static void WriteTable(int n, string s)
        {
            if (n is < 1 or > 6)
            {
                Console.WriteLine("Enter the correct number:");
                return;
            }

            if (s.Equals(""))
            {
                Console.WriteLine("Enter the text:");
                return;
            }

            int wight = s.Length + 2 * (n - 1);
            int height = 2 * n - 1;

            if (wight > 40)
            {
                return;
            }

            CrossLine(wight);
            
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                Console.Write('+');
                if(i == n)
                {
                    for (int j = 1; j <= n - 1; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write(s);
                    for (int j = 1; j <= n - 1; j++)
                    {
                        Console.Write(' ');
                    }
                }
                else
                {
                    for (int j = 1; j <= wight; j++)
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write('+');
                Console.Write('\n');
            }
            CrossLine(wight);
            ChessDeck(wight, height);
            CrossLine(wight);
            BigCross(wight);
            CrossLine(wight);
        }
        
        private static void CrossLine(int wight)
        {
            for (int i = 1; i <= wight + 2; i++)
            {
                Console.Write('+');
            }
            Console.WriteLine();
            
        }

        public static void ChessDeck(int wight, int height)
        {
            string crosses = "";
            int i = 0;
            bool isCross = false;
            for (int j = 0; j < height; j++)
            {
                Console.Write("+");
                for (int k = 1; k <= wight; k++)
                {
                    if (j % 2 == 0)
                    {
                        if (isCross)
                        {
                            Console.Write('+');
                            isCross = false;
                        }
                        else
                        {
                            Console.Write(' ');
                            isCross = true;
                        }
                    }
                    else
                    {
                        if (!isCross)
                        {
                            Console.Write('+');
                            isCross = true;
                        }
                        else
                        {
                            Console.Write(' ');
                            isCross = false;
                        }
                    }
                    i++;
                }
                
                Console.Write("+");
                Console.WriteLine();
            }

        }

        public static void BigCross(int wight)
        {
            for (int i = 0; i < wight; i++)
            {
                Console.Write("+");
                for (int j = 0; j < wight; j++)
                {
                    if (j == i)
                    {
                        Console.Write('+');
                    }
                    else if (j == wight - i - 1)
                    {
                        Console.Write('+');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write("+");
                Console.WriteLine();
            }
        }



    }

}