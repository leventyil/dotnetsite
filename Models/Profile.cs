

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace moviesite.Models
{
    public class Profile : IdentityDbContext
    {
        public int Id { get; set; }
    }

    public class WantToWatch
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string MovieId { get; set; }
    }

    public class Watched
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string MovieId { get; set; }
    }
}
