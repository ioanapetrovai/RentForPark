using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentForPark.Models
{
    public class Comenzi
    {

        public virtual User User { get; set; }
        public virtual Produse Produse { get; set; }
    }
}