using Microsoft.EntityFrameworkCore;
using Roladex.Models;

namespace Roladex.Data
{
    public class RoladexContext : DbContext
    {
        public RoladexContext(DbContextOptions<RoladexContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
