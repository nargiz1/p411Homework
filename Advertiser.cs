using System;
using System.Collections.Generic;
using System.Text;

namespace Homework16._10
{
    class Advertiser: User
    {
        public Advertisement Advert { get; set; }

        public override string ToString()
        {
            return $"{Advert}";
        }
    }
}
