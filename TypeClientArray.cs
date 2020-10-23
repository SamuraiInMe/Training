namespace Final
{
    public class TypeClientArray
    {
        public static int[] ArrayNClients()
        {
            int[] array = new int [4];
            Client pn1 = new Client(481);
            Client pn2 = new Client(84);
            Client pn3 = new Client(231);
            Client pn4 = new Client(151);
            array = new[] {pn1.Quanity, pn2.Quanity, pn3.Quanity, pn4.Quanity};
            return array;
        }
        
        public static int[] ArrayLIClients()
        {
            int[] array = new int [4];
            Client pl1 = new Client(104);
            Client pl2 = new Client(171);
            Client pl3 = new Client(584);
            Client pl4 = new Client(169);
            array = new[] {pl1.Quanity, pl2.Quanity, pl3.Quanity, pl4.Quanity};
            return array;
        }
        
        public static int[] ArrayS1Clients()
        {
            int[] array = new int [4];
            Client pS1 = new Client(225);
            Client pS2 = new Client(340);
            Client pS3 = new Client(100);
            Client pS4 = new Client(94);
            array = new[] {pS1.Quanity, pS2.Quanity, pS3.Quanity, pS4.Quanity};
            return array;
        }
        
        public static int[] ArrayS2Clients()
        {
            int[] array = new int [4];
            Client pSs1 = new Client(502);
            Client pSs2 = new Client(107);
            Client pSs3 = new Client(204);
            Client pSs4 = new Client(52);
            array = new[] {pSs1.Quanity, pSs2.Quanity, pSs3.Quanity, pSs4.Quanity};
            return array;
        }
    }
}