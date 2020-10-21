using System;

namespace tryMasMas
{

    internal class Program
    {
        private static int _sum = 0;
        private static int _sum0 = 0;
        private static int _i = 0;
        private static int _j = 0;
        public static void Main()
        {
            int[][] allclieints = AllClientsArray();
            int[][] allcheck = AllClientsCheck();
            Console.WriteLine("Массив");
            PrintArray(allclieints);
           
            
            Console.WriteLine("Сортировка По убыванию");
            SortMin(allcheck);
            Console.WriteLine();
            Console.WriteLine("Сортировка По возрастанию");
            SortMax(allclieints);
            Console.WriteLine();
            int[][] allclieints1 = AllClientsArray();
            SummClient(allclieints1);
            Console.WriteLine();
            SummLg(allclieints1);

        }

        static void SortMin(int[][] array)
        {
            int temp = 0;
            int k = 0;
            for (_i = 0; _i < array.Length; _i++)
            {
                for (_j = 0; _j < array.Length; _j++)
                {
                    for (k = 0; k < array[_i].Length; k++)
                    {
                        for (int l = 0; l < array[_i].Length; l++)
                        {
                            if (array[_i][_j] < array[k][l])
                            {
                                temp = array[_i][_j];
                                array[_i][_j] = array[k][l];
                                array[k][l] = temp;
                            }
                        }
                    }
                }
            }

            PrintArray(array);
        }
        
        static void SortMax(int[][] array)
        {
            int temp = 0;
            int k = 0;
            for (_i = 0; _i < array.Length; _i++)
            {
                for (_j = 0; _j < array.Length; _j++)
                {
                    for (k = 0; k < array[_i].Length; k++)
                    {
                        for (int l = 0; l < array[_i].Length; l++)
                        {
                            if (array[_i][_j] > array[k][l])
                            {
                                temp = array[_i][_j];
                                array[_i][_j] = array[k][l];
                                array[k][l] = temp;
                            }
                        }
                    }
                }
            }

            PrintArray(array);
        }

        static void SummClient(int[][] array)
        {
            _i = 0;
            _j = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            for (; _i < array.Length; _i++)
            {
                if (_i == 0)
                {
                    do
                    {
                        sum1 = sum1 + array[_i][_j] * 15;
                        _j++;
                    } while (_j < array[_i].Length);
                    _j = 0;
                }
                else if (_i == 1)
                {
                    do
                    {
                        if (array[_i][_j] > 150)
                        {
                            int limits150 = array[_i][_j] - 150;
                            sum2 = sum2 + (150 * 15) + (limits150 * 20);
                        }

                        else if (array[_i][_j] < 150)
                        {
                            sum2 = sum2 + array[_i][_j] * 15;
                        }

                        _j++;
                    } while (_j < array[_i].Length);
                    _j = 0;
                }
                else if (_i == 2)
                {
                    do
                    {
                        sum3 = sum3 + array[_i][_j] * 10;
                        _j++;
                    } while (_j < array[_i].Length);
                    _j = 0;
                }
                else
                {
                    do
                    {
                        int special2 = array[_i][_j] - 50;
                        sum4 = sum4 + special2 * 15;
                        _j++;
                    } while (_j < array[_i].Length);
                    _j = 0;
                }

                _sum = sum1 + sum2 + sum3 + sum4;
            }

            Console.WriteLine($"Общая сумма: {_sum}");

        }

        static void SummLg(int[][] array)
        {
            int lg = 0;
            for (_i = 0; _i < array.Length; _i++)
            {
                for (_j = 0; _j < array[_i].LongLength; _j++)
                {
                    _sum0 = _sum0 + array[_i][_j];
                }
            }

            lg = _sum0 * 15 - _sum;
            Console.WriteLine($"Общий размер льгот: {lg}");
        }

        static void PrintArray(int[][] array)
        {
            foreach (int[] row in array)
            {
                Console.WriteLine("------------------------------");
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }
        }

        private static int[][] AllClientsArray()
        {
            int[][] allclieints = new int[4][];
            allclieints[0] = new int[4] {481, 84, 231, 151};
            allclieints[1] = new int[4] {104, 171, 584, 169};
            allclieints[2] = new int[4] {225, 340, 100, 94};
            allclieints[3] = new int[4] {502, 107, 204, 52};
            return allclieints;
        }
        private static int[][] Check()
        {
            int[][] allcheck = new int[4][];
            allcheck[0] = new int[4] {1, 0, 0, 0};
            allcheck[1] = new int[4] {0, 0, 0, 0};
            allcheck[2] = new int[4] {0, 0, 0, 0};
            allcheck[3] = new int[4] {0, 0, 0, 0};
            return allcheck;
        }
        
        private static int[][] AllClientsCheck()
        {
            int[][] allCheck = Check();
            int[][] allClients = AllClientsArray();
            for (; _i < allClients.Length; _i++)
            {
                if (_i == 0)
                {
                    do
                    {
                        allCheck[_i][_j] = allClients[_i][_j] * 15;
                        _j++;
                    } 
                    while (_j < allClients[_i].Length);
                    _j = 0;
                }
                else if (_i == 1)
                {
                    do
                    {
                        if (allClients[_i][_j] > 150)
                        {
                            allCheck[_i][_j] = (allClients[_i][_j] - 150) * 20 + 150 * 15;
                        }
                        else
                        {
                            allCheck[_i][_j] = allClients[_i][_j] * 15;
                        }
                        _j++;
                    } 
                    while (_j < allClients[_i].Length);
                    _j = 0;
                }
                else if (_i == 2)
                {
                    do
                    {
                        allCheck[_i][_j] = allClients[_i][_j] * 10;
                        _j++;
                    }
                    while(_j < allClients[_i].Length);
                    _j = 0;
                }
                else
                {
                    do
                    {
                        if (allClients[_i][_j] > 50)
                        {
                            allCheck[_i][_j] = (allClients[_i][_j] - 50) * 15;
                        }
                        else
                        {
                            allCheck[_i][_j] = 0;
                        }
                        _j++;
                    }
                    while (_j < allClients[_i].Length);
                    _j = 0;
                }
                
            }
            return allCheck;
        }
    }
}