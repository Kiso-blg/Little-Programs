using System;
using System.Text;

namespace _20_FillSquareWithTrimino
{
    class Program
    {
        private const string StrEnterSize = "Enter square size (2^n).";
        private const string StrEnterNumber = "Please, enter a number.";
        private static char mark = 'A';
        private static char[,] Table;

        static void Main()
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#Triminoes" + Environment.NewLine);
            Console.OutputEncoding = Encoding.UTF8;
            
            GenerateTable();
            Coords firstC = GetFirstCoordinates();
            int side = Table.GetLength(0);
            Table[firstC.X, firstC.Y] = mark++;
            Coords endC = new Coords(Table.GetLength(0) - 1, Table.GetLength(1) - 1);
            PlaceTrimino(firstC, side, endC);
            PrintTable();
        }

        private static void PlaceTrimino(Coords point, int side, Coords end)
        {
            int newSide = side / 2;

            if (newSide < 1)
            {
                return;
            }

            Coords middle = new Coords(end.X - newSide, end.Y - newSide);

            if (point.X > middle.X && point.Y > middle.Y)
            {
                Coords newPoint = new Coords(middle.X, middle.Y);

                Table[newPoint.X, newPoint.Y] = mark;
                Table[newPoint.X, newPoint.Y + 1] = mark;
                Table[newPoint.X + 1, newPoint.Y] = mark++;

                PlaceTrimino(new Coords(newPoint.X, newPoint.Y), newSide, new Coords(newPoint.X, newPoint.Y));
                PlaceTrimino(new Coords(newPoint.X, newPoint.Y + 1), newSide, new Coords(end.X - newSide, end.Y));
                PlaceTrimino(new Coords(newPoint.X + 1, newPoint.Y), newSide, new Coords(end.X, end.Y - newSide));
                PlaceTrimino(point, newSide, end);
            }            
            else if (point.X > middle.X && point.Y <= middle.Y)
            {
                Coords newPoint = new Coords(middle.X, middle.Y + 1);

                Table[newPoint.X, newPoint.Y] = mark;
                Table[newPoint.X, newPoint.Y - 1] = mark;
                Table[newPoint.X + 1, newPoint.Y] = mark++;

                PlaceTrimino(new Coords(newPoint.X, newPoint.Y - 1), newSide, new Coords(newPoint.X, newPoint.Y - 1));
                PlaceTrimino(new Coords(newPoint.X, newPoint.Y), newSide, new Coords(newPoint.X, (newPoint.Y - 1) + newSide));
                PlaceTrimino(new Coords(newPoint.X + 1, newPoint.Y), newSide, new Coords(newPoint.X + newSide, (newPoint.Y - 1) + newSide));
                PlaceTrimino(point, newSide, new Coords(end.X, end.Y - newSide));
            }
            else if (point.X <= middle.X && point.Y <= middle.Y)
            {
                Coords newPoint = new Coords(middle.X + 1, middle.Y + 1);

                Table[newPoint.X, newPoint.Y] = mark;
                Table[newPoint.X - 1, newPoint.Y] = mark;
                Table[newPoint.X, newPoint.Y - 1] = mark++;

                PlaceTrimino(new Coords(newPoint.X - 1, newPoint.Y), newSide, new Coords(newPoint.X - 1, (newPoint.Y - 1) + newSide));
                PlaceTrimino(new Coords(newPoint.X, newPoint.Y), newSide, new Coords((newPoint.X - 1) + newSide, (newPoint.Y - 1) + newSide));
                PlaceTrimino(new Coords(newPoint.X, newPoint.Y - 1), newSide, new Coords((newPoint.X - 1) + newSide, (newPoint.Y - 1)));
                PlaceTrimino(point, newSide, new Coords(end.X - newSide, end.Y - newSide));
            }
            else if (point.X <= middle.X && point.Y > middle.Y)
            {
                Coords newPoint = new Coords(middle.X + 1, middle.Y);

                Table[newPoint.X, newPoint.Y] = mark;
                Table[newPoint.X - 1, newPoint.Y] = mark;
                Table[newPoint.X, newPoint.Y + 1] = mark++;

                PlaceTrimino(new Coords(newPoint.X - 1, newPoint.Y), newSide, new Coords(newPoint.X - 1, newPoint.Y));
                PlaceTrimino(new Coords(newPoint.X, newPoint.Y), newSide, new Coords((newPoint.X - 1) + newSide, newPoint.Y));
                PlaceTrimino(new Coords(newPoint.X, newPoint.Y + 1), newSide, new Coords((newPoint.X - 1) + newSide, newPoint.Y + newSide));
                PlaceTrimino(point, newSide, new Coords(end.X - newSide, end.Y));
            }
        }

        private static Coords GetFirstCoordinates()
        {
            Console.WriteLine($"Enter X coordinate between 0 and {Table.GetLength(0) - 1}.");
            int pointX = GetXYCoordinates();
            Console.WriteLine($"Enter Y coordinate between 0 and {Table.GetLength(0) - 1}.");
            int pointY = GetXYCoordinates();

            return new Coords(pointX, pointY);
        }

        private static int GetXYCoordinates()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int point))
            {
                Console.WriteLine(StrEnterNumber);
                point = GetXYCoordinates();
            }
            else
            {
                if (point < 0 || point > Table.GetLength(0) - 1)
                {
                    Console.WriteLine($"Point must be between 0 and {Table.GetLength(0) - 1} including.");
                    point = GetXYCoordinates();
                }
            }

            return point;
        }

        private static void GenerateTable()
        {
            Console.WriteLine(StrEnterSize);
            Console.Write("N = ");
            int power = GetPow();
            int size = Convert.ToInt32(Math.Pow(2, power));

            Table = new char[size, size];

            for (int row = 0; row < Table.GetLength(0); row++)
            {
                for (int col = 0; col < Table.GetLength(1); col++)
                {
                    Table[row, col] = '-';
                }
            }
        }

        private static int GetPow()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int power))
            {
                Console.WriteLine(StrEnterNumber);
                power = GetPow();
            }

            return power;
        }

        private static void PrintTable()
        {
            string result = string.Empty;

            for (int row = 0; row < Table.GetLength(0); row++)
            {
                for (int col = 0; col < Table.GetLength(1); col++)
                {
                    result += Table[row, col] + " ";
                }

                result += Environment.NewLine;
            }

            Console.WriteLine(result);
        }

        struct Coords
        {
            public Coords(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString() => $"X = {this.X}, {this.Y}";
        }
    }
}