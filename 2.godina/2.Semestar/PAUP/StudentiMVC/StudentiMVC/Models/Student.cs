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

        [Required(AllowEmptyStrings =false,ErrorMessage ="Ime je obavezno polje!")]
        public string  Ime { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Prezime je obavezno polje!")]
        public string Prezime { get; set; }
        public Spol Spol { get; set; }

        [Display(Name = "OIB")]
        public string OIB { get; set; }

        [Display(Name = "Datum rođenja")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}",ApplyFormatInEditMode = true)]
        [Required(AllowEmptyStrings = false,ErrorMessage ="Datum rođenja je obavezno polje!")]
        public DateTime Datumrodjenja { get; set; }
        public int? GodinaStudija { get; set; }
        public RedovniStudent RedovniStudent { get; set; }

    }
}