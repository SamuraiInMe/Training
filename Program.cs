using System;

namespace Final
{
    
    class Program
    {
        public static void Main()
        {
            TypeOfClientArray AllClients = new TypeOfClientArray();
            CalculatAllPriece allPriece = new CalculatAllPriece();
            ClientsCalculator calculator = new ClientsCalculator();
            CalculatAllPriece Privileges = new CalculatAllPriece();
            ClientsSorter SortMax = new ClientsSorter();
            ClientsSorter SortMin = new ClientsSorter();
            
            Console.WriteLine("Массив потреблённой клиентами энергии по убыванию:");
            printarray(SortMax.SortMax(AllClients.allclientsarray()));
            Console.WriteLine();
            Console.WriteLine("Массив величины оплаты клиентов по возрастанию:");
            printarray(SortMin.SortMin(calculator.clientscalculator()));
            Console.WriteLine();
            Console.WriteLine("Массив по типу клиентов:");
            printarray(AllClients.allclientsarray());
            Console.WriteLine();
            Console.WriteLine($"Общая сумма : {allPriece.Price(calculator.clientscalculator())}");
            Console.WriteLine();
            Console.WriteLine($"Общая сумма льгот: {Privileges.Privileges(AllClients.allclientsarray())}");
            Console.WriteLine();
        }
        public static void printarray(int[,] array)
        {
            int j = 0;
            int n = array.Length / 4;
            for (int i=0; i<n; i++)
            {
                while (j < n)
                {
                    Console.Write($" {array[i,j]} ");
                    j++;
                }
                j = 0;
                Console.WriteLine();
            }
        }
        
    }
}
    