using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    interface GameManager
    {
        //Ekleme
        void Add(Uye uye, Game game);

        //Güncelleme
        void Update(Uye uye, Game game);

        //Silme
        void Delete(Uye uye, Game game);
    }
}
