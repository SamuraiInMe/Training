using System;

namespace Final
{
    public class ClientsCalculator : TypeOfClientArray
    {
        public int[,] clientscalculator()
        {
            int[,] allcheck = new int[4,4] {{0,0,0,0}, {0,0,0,0}, {0,0,0,0}, {0,0,0,0}};;
            int i = 0;
            int j = 0;
            TypeOfClientArray allClients = new TypeOfClientArray();
            int[,] allclient = allClients.allclientsarray();
            int n = allclient.Length / 4;
            for (; i < n; i++)
            {
                if (i == 0)
                {
                    do
                    {
                        allcheck[i,j] = allclient[i,j] * NormalPrice;
                        j++;
                    } 
                    while (j < n);
                    j = 0;
                }
                else if (i == 1)
                {
                    do
                    {
                        if (allclient[i,j] > Limitline)
                        {
                            allcheck[i,j] = (allclient[i,j] - Limitline) * LimitPrice + Limitline * NormalPrice;
                        }
                        else
                        {
                            allcheck[i,j] = allclient[i,j] *NormalPrice;
                        }
                        j++;
                    } 
                    while (j < n);
                    j = 0;
                }
                else if (i == 2)
                {
                    do
                    {
                        allcheck[i,j] = allclient[i,j] * PrivilegPrice;
                        j++;
                    }
                    while(j < n);
                    j = 0;
                }
                else
                {
                    do
                    {
                        if (allclient[i,j] > PrivelegPrice2)
                        {
                            allcheck[i,j] = (allclient[i,j] - PrivelegPrice2) * NormalPrice;
                        }
                        else
                        {
                            allcheck[i,j] = 0;
                        }
                        j++;
                    }
                    while (j < n);
                    j = 0;
                }
            }
            return allcheck;
        }
    }
}