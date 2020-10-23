namespace Final
{
    public class TypeOfClientArray
    {
        private int _normalPrice = 15;
        public int NormalPrice
        {
            get { return _normalPrice; }
            
        }
        private int _limitPrice = 20;
        public int LimitPrice
        {
            get { return _limitPrice; }
        }
        private int _privilegPrice = 10;
        public int PrivilegPrice
        {
            get { return _privilegPrice; }
        }
        private int _limitLine = 150;
        public int Limitline
        {
            get { return _limitLine; }
        }
        private int _privelegPrice2 = 50;
        public int PrivelegPrice2
        {
            get { return _privelegPrice2; }
        }
        static Client pn1 = new Client(481);
        static Client pn2 = new Client(84);
        static Client pn3 = new Client(231);
        static Client pn4 = new Client(151);
        static Client pl1 = new Client(104);
        static Client pl2 = new Client(171);
        static Client pl3 = new Client(584);
        static Client pl4 = new Client(169);
        static Client pS1 = new Client(225);
        static Client pS2 = new Client(340);
        static Client pS3 = new Client(100);
        static Client pS4 = new Client(94);
        static Client pSs1 = new Client(502);
        static Client pSs2 = new Client(107);
        static Client pSs3 = new Client(204);
        static Client pSs4 = new Client(52);
        public static int[,] ArrayNClients()
        {
            int[,] array = new int [1,4];
            
            array = new int[,] {{pn1.Quanity}, {pn2.Quanity},  {pn3.Quanity}, {pn4.Quanity}};
            return array;
        }
        public static int[,] ArrayLIClients()
        {
            int[,] array = new int [1,4];
            
            array = new[,] {{pl1.Quanity}, {pl2.Quanity}, {pl3.Quanity}, {pl4.Quanity}};
            return array;
        }
        public static int[,] ArrayS1Clients()
        {
            int[,] array = new int [1,4];
            
            array = new[,] {{pS1.Quanity}, {pS2.Quanity}, {pS3.Quanity}, {pS4.Quanity}};
            return array;
        }
        public static int[,] ArrayS2Clients()
        {
            int[,] array = new int [1,4];
           
            array = new[,] {{pSs1.Quanity}, {pSs2.Quanity}, {pSs3.Quanity}, {pSs4.Quanity}};
            return array;
        }
        public int[,] allclientsarray()
        {
            int[,] array = new int[4,4];
            array = new int[,] {{pn1.Quanity , pn2.Quanity, pn3.Quanity, pn4.Quanity}, {pl1.Quanity, pl2.Quanity, pl3.Quanity, pl4.Quanity}, {pS1.Quanity, pS2.Quanity, pS3.Quanity, pS4.Quanity}, {pSs1.Quanity, pSs2.Quanity, pSs3.Quanity, pSs4.Quanity}} ;
            return array;
        }
    }
}