using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class CampManager : GameManager
    {
        public void Add(Uye uye, Game game)
        {
            Console.WriteLine("Oyun Kampanyaya Dahil Edildi!");
        }
        public void Update(Uye uye, Game game)
        {
            Console.WriteLine("Kampanya Ürünleri Güncellendi!");
        }
        public void Delete(Uye uye, Game game)
        {
            Console.WriteLine("Kampanya Dahilindeki Ürün Silindi!");
        }
    }
}
