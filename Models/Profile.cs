

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace moviesite.Models
{
    public class Profile : IdentityDbContext
    {
        public int Id { get; set; }
    }

    [Keyless]
    public class WantToWatch
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
    }
}
