using Microsoft.EntityFrameworkCore;
using ParkingLot.BackEnd.Data.Models;

namespace ParkingLot.BackEnd.Data;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext() : base()
    {
    }

    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Persona> Personas => Set<Persona>();
    public DbSet<Ticket> Tickets => Set<Ticket>();
    public DbSet<TipoDocumentoEntidad> TiposTipoDocumentoEntidades => Set<TipoDocumentoEntidad>();
    public DbSet<Ubigeo> Ubigeos => Set<Ubigeo>();
    public DbSet<Vehiculo> Vehiculos => Set<Vehiculo>();


}