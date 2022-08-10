using System.ComponentModel.DataAnnotations;


namespace moviesite.Models
{
    public class Film
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "İsim boş Bırakılamaz.")]
        public string FilmName { get; set; }

        [Required(ErrorMessage = "Yıl boş Bırakılamaz.")]
        public int FilmYear { get; set; }

        [Required(ErrorMessage = "Uzunluk boş Bırakılamaz.")]
        public int FilmLength { get; set; }

        [Required(ErrorMessage = "IMDb Score boş Bırakılamaz.")]
        public string FilmScore { get; set; }

        [Required(ErrorMessage = "Metascore Score boş Bırakılamaz.")]
        public int FilmScoreTwo { get; set; }


    }
}
