using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentForPark.Models
{
    public class Comanda
    {
        [Key]
        public int IdComanda { get; set; }
        public int IdUser { get; set; }
        public int IdProdus { get; set; }
        [Required(ErrorMessage = "Cantitatea este obligatorie")]
        [Display(Name = "Cantitate")]
        public int Cantitate { get; set; }
        [Required(ErrorMessage = "Adresa este obligatorie")]
        [Display(Name = "Adresa")]
        public string Adresa { get; set; }
        [Required(ErrorMessage = "Totalul este obligatoriu")]
        [Display(Name = "Pret Total")]
        public double TotalPret { get; set; }
        [Required(ErrorMessage = "Data de livrarare este obligatorie")]
        [Display(Name = "Data de Livrare")]
        public DateTime DataLivrare { get; set; }
        [Required(ErrorMessage = "Data de returnare este obligatorie")]
        [Display(Name = "Data de Returnare")]
        public DateTime DataReturnare { get; set; }
        public virtual User User { get; set; }
        public virtual Produs Produs { get; set; }
    }
}
