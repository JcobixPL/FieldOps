using Microsoft.EntityFrameworkCore;

namespace FieldOps.Infrastructure.Persistence;

public sealed class FieldOpsDbContext : DbContext
{
    public FieldOpsDbContext(DbContextOptions<FieldOpsDbContext> options)
        : base(options) { }
}
