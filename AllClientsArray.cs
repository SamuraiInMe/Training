using System.Collections.Generic;

namespace Final
{
    public class AllClientsArray 
    {
        public int[,] allclientsarray()
        {    
            int[,] allclientsArray = new int[4,4];
            allclientsArray = new[,] {{0,0,0,0}, {0,0,0,0}, {0,0,0,0}, {0,0,0,0}};
            int[,] array1 = TypeOfClientArray.ArrayNClients();
            int[,] array2 = TypeOfClientArray.ArrayLIClients();
            int[,] array3 = TypeOfClientArray.ArrayS1Clients();
            int[,] array4 = TypeOfClientArray.ArrayS2Clients();

            for (int i = 0; i < allclientsArray.Length; i++)
            {
                for (int j = 0; j < allclientsArray.Length; j++)
                {
                    
                }
            }
            return allclientsArray;
        }

    }    
}
