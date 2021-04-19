using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace moviesite.Models
{
    public class Film
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "İsim boş Bırakılamaz.")]
        public string FilmName { get; set; }

        [Required(ErrorMessage = "Yıl boş Bırakılamaz.")]
        public int FilmYear { get; set; }

        [Required(ErrorMessage = "Uzunluk boş Bırakılamaz.")]
        public int FilmLength { get; set; }

        [Required(ErrorMessage = "IMDb Score boş Bırakılamaz.")]
        public float FilmScore { get; set; }

        [Required(ErrorMessage = "Metascore Score boş Bırakılamaz.")]
        public int FilmScoreTwo { get; set; }


    }
}
