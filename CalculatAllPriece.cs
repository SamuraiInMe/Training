namespace Final
{
    public class CalculatAllPriece : TypeOfClientArray
    {
        private static int Sum { get; set; }
        public int Price(int[,] array)
        {
            ClientsCalculator allprice = new ClientsCalculator();
            int i = 0;
            int j = 0;
            int n = array.Length / 4;
            for (; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Sum = Sum + array[i,j];
                }
            }
            return Sum;
        }
        public int Privileges(int[,] array)
        {
            ClientsCalculator Sum = new ClientsCalculator();
            ClientsCalculator calculator = new ClientsCalculator();
            int lg = 0;
            int i = 0;
            int j = 0;
            int sum0 = 0;
            int n = array.Length / 4;
            for (; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    sum0 = sum0 + array[i,j];
                }
            }
            lg = sum0*NormalPrice - CalculatAllPriece.Sum;
            return lg;
        }
    }
}