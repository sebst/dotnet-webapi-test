using Microsoft.EntityFrameworkCore;

namespace dotnet_webapi_test.Models;

public class SessionContext : DbContext
{
    public SessionContext(DbContextOptions<SessionContext> options)
        : base(options)
    {
    }

    public DbSet<SessionItem> SessionItems { get; set; } = null!;
}