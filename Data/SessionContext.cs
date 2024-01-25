using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnet_webapi_test.Models;

    public class SessionContext : DbContext
    {
        public SessionContext (DbContextOptions<SessionContext> options)
            : base(options)
        {
        }

        public DbSet<dotnet_webapi_test.Models.SessionItem> SessionItem { get; set; } = default!;
    }
