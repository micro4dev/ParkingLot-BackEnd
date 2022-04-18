using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLot.BackEnd.Data.Models;

public class Ticket
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(6)]
    public string NumeroTicket { get; set; }

    [Required]
    public DateTime FechaIngreso { get; set; }

    [Required]
    [MaxLength(6)]
    public string HoraIngreso { get; set; }

    [Required]
    [MaxLength(6)]
    public DateTime FechaSalida { get; set; }

    [Required]
    [MaxLength(6)]
    public string HoraSalida { get; set; }

    [Required]
    public int VehiculoId { get; set; }

    [ForeignKey(nameof(Vehiculo))]
    public Vehiculo Vehiculo { get; set; }

    [Required]
    public int PersonaId { get; set; }

    [ForeignKey(nameof(Persona))]
    public Persona Persona { get; set; }

    [Required]
    public int TarifaId { get; set; }

    [ForeignKey(nameof(Tarifa))]
    public Tarifa Tarifa { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal PrecioHoraFraccion { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal PrecioDia { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalTicket { get; set; }

    [MaxLength(6)]
    public string TiempoTranscurrido { get; set; }
}