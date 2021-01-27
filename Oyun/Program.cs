using System;

namespace Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            NewAdmin gamer1= new NewAdmin() {FirstName="Ümmühan", LastName = "PERÇEM", 
                UserName = "Percem.u", Password = "123up", Id = 1, Tc = "45678", UyeNo=1, Birth=new DateTime(1997,02,12)};

            Admin gamer2 = new Admin() { Id = 2, UyeNo = 2, UserName="AkyolS", Password="tekir1995"};

            //İlk Oyun
            Game oyun = new Game();
            oyun.GameName ="GTA";
            oyun.GameId=1;
            oyun.GamePrice =125;

            //2.Oyun
            Game oyun2 = new Game();
            oyun2.GameName ="PUBG";
            oyun2.GameId = 2;
            oyun2.GamePrice =90;

            GameManager campGame = new CampManager();
            campGame.Add(gamer1, oyun);

            GameManager saleGame = new SaleManager();
            saleGame.Update(gamer2, oyun2);
        }
    }
}
