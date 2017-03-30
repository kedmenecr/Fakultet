using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentiMVC.Models
{
    public class Student
    {

        [Display(Name = "ID Studenta")]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ime je obavezno polje!")]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Prezime je obavezno polje!")]
        public string Prezime { get; set; }


        public char Spol { get; set; }

        [Display(Name = "OIB")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "{0}  treba imati {1} znamenki!")]
        [OIBValidacija(ErrorMessage="Neispravan OIB")]
        public string OIB { get; set; }

        [Display(Name = "Datum rođenja")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage ="Datum rođenja je obavezno polje!")]
        public DateTime DatumRodjenja { get; set; }
        public int? GodinaStudija { get; set; }
        public bool RedovniStudent { get; set; }

    }
}