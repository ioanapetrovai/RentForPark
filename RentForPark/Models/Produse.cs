using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentForPark.Models
{
    public class Produse
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ProdusId { get; set; }
        public string Tip { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public double Pret { get; set; }

        public virtual ICollection<Comenzi> Comenzi { get; set; }


    }
}