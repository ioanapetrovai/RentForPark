using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentForPark.Models
{
    public class Produs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Key]
        public int IdProdus { get; set; }
        public string Tip { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public double Pret { get; set; }
    }
}