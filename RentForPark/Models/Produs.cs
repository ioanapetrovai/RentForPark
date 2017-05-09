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
        [Required(ErrorMessage = "Tipul este obligatoriu")]
        [Display(Name = "Tip")]
        public string Tip { get; set; }
        [Required(ErrorMessage = "Numele este obligatoriu")]
        [Display(Name = "Nume")]
        public string Nume { get; set; }
        [Required(ErrorMessage = "Descrierea este obligatorie")]
        [Display(Name = "Descriere")]
        public string Descriere { get; set; }
        [Required(ErrorMessage = "Pretul este obligatoriu")]
        [Display(Name = "Pret")]
        public double Pret { get; set; }

        public virtual ICollection<Comanda> Comenzi { get; set; }


    }
}
