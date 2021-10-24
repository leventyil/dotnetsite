using System.ComponentModel.DataAnnotations;


namespace moviesite.Models
{
    public class CreateRole
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
