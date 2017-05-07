using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentForPark.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Key]
        public int IdUser { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(50, ErrorMessage = "Numele nu poate avea mai mult de 50 de caractere")]
        [Display(Name = "Nume")]
        public string Nume { get; set; }

        [Required(ErrorMessage = "Prenumele este obligatoriu")]
        [StringLength(50, ErrorMessage = "Prenumele nu poate avea mai mult de 50 de caractere")]
        [Display(Name = "Prenume")]
        public string Prenume { get; set; }

        [Required(ErrorMessage = "Username-ul este obligatoriu")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Parola este obligatorie")]
        [StringLength(255, ErrorMessage = "Trebuie sa fie intre 5 si 255 de caractere", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmarea Parolei este obligatorie")]
        [StringLength(255, ErrorMessage = "Trebuie sa fie intre 5 si 255 de caractere", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Data Nasterii este obligatorie")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Nasterii")]
        public DateTime DataNasterii { get; set; }

        [Required(ErrorMessage = "Email-ul este obligatoriu")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefonul este obligatoriu")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Data Inscrierii este obligatorie")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Inscrierii")]
        public DateTime DataInscrierii { get; set; }
        public bool Admin { get; set; }
        public virtual ICollection<Comenzi> Comenzi { get; set; }

    }
}