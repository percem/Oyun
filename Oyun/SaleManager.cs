using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class SaleManager : GameManager
    {
        public void Add(Uye uye, Game game)
        {
            Console.WriteLine("Oyun Satışta!");
        }
        public void Update(Uye uye, Game game)
        {
            Console.WriteLine("Satış Ürünü Güncellendi!");
        }
        public void Delete(Uye uye, Game game)
        {
            Console.WriteLine("Satış Ürünü Silindi!");
        }
    }
}
