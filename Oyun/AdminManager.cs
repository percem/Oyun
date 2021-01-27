using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class AdminManager
    {
        public void Add(Uye uye)
        {
            Console.WriteLine(uye.UserName+" başarıyla eklendi!");
        }
        public void Update(Uye uye)
        {
            Console.WriteLine(uye.UserName+" kullanıcı kaydı güncellendi!");
        }
        public void Delete(Uye uye)
        {
            Console.WriteLine(uye.UserName + " kullanıcı sistemden silindi!");
        }
    }
}
