using System;

namespace _14_Sequence_With_Equal_Elements_In_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 14" + Environment.NewLine);

            Console.WriteLine("This proram finds the longest sequence of equal string elements in a matrix.");
            string[,] matrix = CreateMatrix();
            SeqData subsequence = GetFirstSubsequence(matrix);
            SearchHorizontalSequence(matrix, ref subsequence);
            SearchVerticalSequence(matrix, ref subsequence);
            SearchLeftUpRightDownDiagonal(matrix, ref subsequence);
            SearchRighUpLeftDownDiagonal(matrix, ref subsequence);
            PrintMatrix(matrix);
            PrintSubsequence(matrix, subsequence);
        }

        private static void PrintSubsequence(string[,] matrix, SeqData subsequence)
        {
            int x = subsequence.X;
            int y = subsequence.Y;
            int len = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == x && col == y && len < subsequence.Length)
                    {
                        Console.Write($"{matrix[row, col],-4} ");
                        len++;

                        if (subsequence.Direction == "horizontal")
                        {
                            y++;
                        }
                        else if (subsequence.Direction == "vertical")
                        {
                            x++;
                        }
                        else if (subsequence.Direction == "\\")
                        {
                            x++;
                            y++;
                        }
                        else
                        {
                            x++;
                            y--;
                        }
                    }
                    else
                    {
                        Console.Write($"{" ", -4} ");
                    }
                }

                Console.WriteLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col], -4} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void SearchRighUpLeftDownDiagonal(string[,] matrix, ref SeqData subsequence)
        {
            SeqData newSeq = new SeqData("", 0, 0, 0, "");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - 1; col > -1; col--)
                {
                    string element = matrix[row, col];
                    int r = row + 1;
                    int c = col - 1;
                    int len = 1;

                    while (r < matrix.GetLength(0) && c > -1)
                    {
                        if (element == matrix[r, c])
                        {
                            len++;
                        }
                        else
                        {
                            break;
                        }

                        r++;
                        c--;
                    }

                    if (len > newSeq.Length)
                    {
                        newSeq.Length = len;
                        newSeq.Data = element;
                        newSeq.X = r - len;
                        newSeq.Y = c + len;
                    }
                }
            }

            if (subsequence.Length < newSeq.Length)
            {
                subsequence = newSeq;
                subsequence.Direction = "/";
            }
            else if (subsequence.Length == newSeq.Length)
            {
                if (newSeq.X < subsequence.X)
                {
                    subsequence = newSeq;
                    subsequence.Direction = "/";
                }
            }
        }

        private static void SearchLeftUpRightDownDiagonal(string[,] matrix, ref SeqData subsequence)
        {
            SeqData newSeq = new SeqData("", 0, 0, 0, "");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string element = matrix[row, col];
                    int r = row + 1;
                    int c = col + 1;
                    int len = 1;

                    while (r < matrix.GetLength(0) && c < matrix.GetLength(1))
                    {
                        if (element == matrix[r, c])
                        {
                            len++;
                        }
                        else
                        {
                            break;
                        }

                        r++;
                        c++;
                    }

                    if (len > newSeq.Length)
                    {
                        newSeq.Length = len;
                        newSeq.Data = element;
                        newSeq.X = r - len;
                        newSeq.Y = c - len;
                    }
                }
            }

            if (subsequence.Length < newSeq.Length)
            {
                subsequence = newSeq;
                subsequence.Direction = "\\";
            }
            else if (subsequence.Length == newSeq.Length)
            {
                if (newSeq.X < subsequence.X)
                {
                    subsequence = newSeq;
                    subsequence.Direction = "\\";
                }
            }
        }

        private static void SearchVerticalSequence(string[,] matrix, ref SeqData subsequence)
        {
            SeqData newSeq = new SeqData("", 0, 0, 0, "");            

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int len = 0;
                string prevElement = string.Empty;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (len == 0)
                    {
                        prevElement = matrix[row, col];
                        len = 1;
                    }
                    else
                    {
                        if (prevElement == matrix[row, col])
                        {
                            len++;
                        }
                        else
                        {
                            prevElement = matrix[row, col];
                            len = 1;
                        }
                    }

                    if (len > newSeq.Length)
                    {
                        newSeq.Length = len;
                        newSeq.Data = prevElement;
                        newSeq.X = row - len + 1;
                        newSeq.Y = col;
                    }
                }
            }

            if (subsequence.Length < newSeq.Length)
            {
                subsequence = newSeq;
                subsequence.Direction = "vertical";
            }
            else if (subsequence.Length == newSeq.Length)
            {
                if (newSeq.X < subsequence.X)
                {
                    subsequence = newSeq;
                    subsequence.Direction = "vertical";
                }
            }
        }

        private static void SearchHorizontalSequence(string[,] matrix, ref SeqData subsequence)
        {
            SeqData newSeq = new SeqData("", 0, 0, 0, "");            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int len = 0;
                string prevElement = string.Empty;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (len == 0)
                    {
                        prevElement = matrix[row, col];
                        len = 1;
                    }
                    else
                    {
                        if (prevElement == matrix[row, col])
                        {
                            len++;
                        }
                        else
                        {
                            prevElement = matrix[row, col];
                            len = 1;
                        }
                    }

                    if (len > newSeq.Length)
                    {
                        newSeq.Length = len;
                        newSeq.Data = prevElement;
                        newSeq.X = row;
                        newSeq.Y = col - len + 1;
                    }
                }
            }

            if (subsequence.Length < newSeq.Length)
            {
                subsequence = newSeq;
                subsequence.Direction = "horizontal";
            }
            else if (subsequence.Length == newSeq.Length)
            {
                if (newSeq.X < subsequence.X)
                {
                    subsequence = newSeq;
                    subsequence.Direction = "horizontal";
                }
            }
        }

        private static SeqData GetFirstSubsequence(string[,] matrix)
        {
            string data = string.Empty;
            int len = 0;
            int x = 0;
            int y = 0;
            bool stop = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                len = 0;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (len == 0)
                    {
                        data = matrix[row, col];                        
                    }
                    else
                    {
                        if (matrix[row, col] != data)
                        {
                            x = row;
                            y = col - len;
                            stop = true;
                            break;
                        }
                    }

                    len++;
                }

                if (stop == true)
                {
                    break;
                }
            }

            SeqData seq = new SeqData(matrix[x, y], len, x, y, "horizontal");
            return seq;
        }        

        private static string[,] CreateMatrix()
        {
            string[,] matrix = new string[,]
            {
                { "ha", "fifi", "ho", "hu" },
                { "ha", "fo", "hu", "xx" },
                { "xx", "hu", "ha", "xx" },
                { "hi", "ho", "ha", "xx" }

            };

            return matrix;
        }
    }

    struct SeqData : IComparable
    {
        public SeqData(string data, int length, int x, int y, string direction)
        {
            this.Data = data;
            this.Length = length;
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }

        public string Data { get; set; }
        public int Length { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }

        public int CompareTo(object obj)
        {
            SeqData newSeqData = (SeqData)obj;

            if (this.Length > newSeqData.Length)
            {
                return 1;
            }
            else if (this.Length == newSeqData.Length)
            {
                return 0;
            }

            return -1;
        }
    }
}