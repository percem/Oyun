using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class NewAdmin:Uye
    {
        //Yeni Kullanıcıdan İstenilecek Olan Bilgiler
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tc { get; set; }
        public DateTime Birth { get; set; }
      
    }
}
