using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegaIDE_V2.Server.Models;
using VegaIDE_V2.Shared;

namespace VegaIDE_V2.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Editor> Editors { get; set; }
        public DbSet<Submission> Submissions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Editor>().HasData(

                new Editor
                {
                    Id = 1,
                    Code = "def test():\n    print(\"Hello, World\")",
                    Language = "Python"
                }

                );


            builder.Entity<Submission>().HasData(

                new Submission
                {
                    Id = 1,
                    Output = "",
                    Result = false
                }

                );

        }


    }
}
