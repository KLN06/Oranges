using System;

namespace Oranges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the value of K, the number of rows");
            var K = int.Parse(Console.ReadLine());
            Console.WriteLine("Now type in the value of L, the number of columns");
            var L = int.Parse(Console.ReadLine());
            if (K <= 0 || K > L || L > 10000)
            {
                throw new ArgumentException("Invalid K or L value!");
            }
            Console.WriteLine("Great! Now type in the value of R, the number of days");
            var R = int.Parse(Console.ReadLine());
            if (R <= 0 || R > 1000)
            {
                throw new ArgumentException("Invalid R value!");
            }
            Console.WriteLine("Are there 1 or 2 rotten oranges? Type in 1 or 2");
            var numOfRottenOranges = int.Parse(Console.ReadLine());
            if (numOfRottenOranges != 1 && numOfRottenOranges != 2)
            {
                throw new ArgumentException("The number of oranges must be either 1 or 2!");
            }

            var rottenOranges = new List<(int row, int column)>();
            
            for (int i = 0; i < numOfRottenOranges; i++)
            {
                Console.WriteLine("Type in the row and column value of a rotten orange, separated by a space");
                string[] stringValuesArr = Console.ReadLine().Split(" ");
                var row = int.Parse(stringValuesArr[0]);
                var column = int.Parse(stringValuesArr[1]);
                rottenOranges.Add((row, column));
            }

            var allOranges = K * L;

            for (int i = 0; i < R; i++)
            {
                for(int o = 0; o<rottenOranges.Count; o++)
                {
                    var orange = rottenOranges[o];
                    {

                        if (orange.row != K - 1 && orange.column != L - 1 && orange.row != 0 && orange.column != 0)
                        {

                            if (!rottenOranges.Contains(((orange.row) + 1, orange.column)))
                            {
                                rottenOranges.Add(((orange.row) + 1, orange.column));
                            }
                            if (!rottenOranges.Contains(((orange.row) - 1, orange.column)))
                            {
                                rottenOranges.Add(((orange.row) - 1, orange.column));
                            }
                            if (!rottenOranges.Contains((orange.row, (orange.column) + 1)))
                            {
                                rottenOranges.Add((orange.row, (orange.column) + 1));
                            }
                            if (!rottenOranges.Contains((orange.row, (orange.column) - 1)))
                            {
                                rottenOranges.Add((orange.row, (orange.column) - 1));
                            }
                        }
                        else if (orange.row == 0)
                        {
                            if (orange.column == 0)
                            {
                                if (!rottenOranges.Contains(((orange.row) + 1, orange.column)))
                                {
                                    rottenOranges.Add(((orange.row) + 1, orange.column));
                                }
                                if (!rottenOranges.Contains((orange.row, (orange.column) + 1)))
                                {
                                    rottenOranges.Add((orange.row, (orange.column) + 1));
                                }
                            }
                            else if (orange.column == L - 1)
                            {
                                if (!rottenOranges.Contains((orange.row, (orange.column) - 1)))
                                {
                                    rottenOranges.Add((orange.row, (orange.column) - 1));
                                }
                                if (!rottenOranges.Contains(((orange.row) + 1, orange.column)))
                                {
                                    rottenOranges.Add(((orange.row) + 1, orange.column));
                                }
                            }
                            else
                            {
                                if (!rottenOranges.Contains(((orange.row) + 1, orange.column)))
                                {
                                    rottenOranges.Add(((orange.row) + 1, orange.column));
                                }
                                if (!rottenOranges.Contains((orange.row, (orange.column) + 1)))
                                {
                                    rottenOranges.Add((orange.row, (orange.column) + 1));
                                }
                                if (!rottenOranges.Contains((orange.row, (orange.column) - 1)))
                                {
                                    rottenOranges.Add((orange.row, (orange.column) - 1));
                                }
                            }

                        }
                        else if (orange.row == K - 1)
                        {
                            if (orange.column == 0)
                            {
                                if (!rottenOranges.Contains(((orange.row) - 1, orange.column)))
                                {
                                    rottenOranges.Add(((orange.row) - 1, orange.column));
                                }
                                if (!rottenOranges.Contains((orange.row, (orange.column) + 1)))
                                {
                                    rottenOranges.Add((orange.row, (orange.column) + 1));
                                }
                            }
                            else if (orange.column == L - 1)
                            {
                                if (!rottenOranges.Contains(((orange.row) - 1, orange.column)))
                                {
                                    rottenOranges.Add(((orange.row) - 1, orange.column));
                                }
                                if (!rottenOranges.Contains((orange.row, (orange.column) - 1)))
                                {
                                    rottenOranges.Add((orange.row, (orange.column) - 1));
                                }
                            }
                            else
                            {
                                if (!rottenOranges.Contains(((orange.row) - 1, orange.column)))
                                {
                                    rottenOranges.Add(((orange.row) - 1, orange.column));
                                }
                                if (!rottenOranges.Contains((orange.row, (orange.column) + 1)))
                                {
                                    rottenOranges.Add((orange.row, (orange.column) + 1));
                                }
                                if (!rottenOranges.Contains((orange.row, (orange.column) - 1)))
                                {
                                    rottenOranges.Add((orange.row, (orange.column) - 1));
                                }
                            }
                        }

                    }


                }
            }
            var unrottenOranges = allOranges - rottenOranges.Count;
            Console.WriteLine(unrottenOranges);
        }
    }
}
