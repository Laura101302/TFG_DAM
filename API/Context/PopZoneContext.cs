using System.Data.Entity;

public class PopZoneContext : DbContext
{
    public PopZoneContext(string connectionString) : base(connectionString)
    { }
    public DbSet<OpinionEntity> Opiniones { get; set; }
    public DbSet<PMayoristaEntity> PMayoristas { get; set; }

    public DbSet<PParticularEntity> PParticulares { get; set; }

    public DbSet<UsuarioEntity> Usuarios { get; set; }

    public DbSet<VParticularEntity> VParticulares { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
