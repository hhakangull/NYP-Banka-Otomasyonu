﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class TicariMusteri : Musteri
    {
        public Banka Banka;
        
        public TicariMusteri(Banka Banka)
        {
            this.Banka = Banka;
        }
       
       
    }
}
