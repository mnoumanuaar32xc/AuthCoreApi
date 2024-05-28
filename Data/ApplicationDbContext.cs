using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TraningWebApi.Model.Domain;

namespace TraningWebApi.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext( DbContextOptions  <ApplicationDbContext > options): base(options)
        {

        }

        public DbSet<Training> Training { get; set; }




    }
}
