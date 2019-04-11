using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Yazar
    {
        public int YazarId { get; set; }

        [Required(ErrorMessage ="Yazar Adı Soyadını girmediniz")]
        [StringLength(100, ErrorMessage ="Ad Soyad Alanı 100 karakterden fazla olamaz.")]
        [Display(Name ="Yazarın Adı Soyadı")]
        public string YazarAdiSoyadi { get; set; }

        [Display(Name = "Yazarın Doğum Tarihi")]
        public DateTime YazarDogumTarihi { get; set; }

        [Display(Name = "Yazarın E-Posta Adresi")]
        [Required(ErrorMessage ="E-Posta adresi girmediniz.")]
        public string YazarEmailAdresi { get; set; }

    }
}