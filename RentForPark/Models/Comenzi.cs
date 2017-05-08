using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentForPark.Models
{
    public class Comenzi
    {
        public int IdComenzi { get; set; }
        public int IdUser { get; set; }
        public int IdProdus { get; set; }
        public int Cantitate { get; set; }
        public string Adresa { get; set; }
        public double TotalPret { get; set; }
        public DateTime DataLivrare { get; set; }
        public DateTime DataReturnare { get; set; }
        public virtual User User { get; set; }
        public virtual Produse Produse { get; set; }
    }
}