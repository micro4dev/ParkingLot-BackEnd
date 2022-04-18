using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLot.BackEnd.Data.Models;

[Table("Ticket")]
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
    [ForeignKey(nameof(Vehiculo))]
    public int VehiculoId { get; set; }

    public Vehiculo Vehiculo { get; set; }

    [Required]
    [ForeignKey(nameof(Persona))]
    public int PersonaId { get; set; }

    public Persona Persona { get; set; }

    [Required]
    [ForeignKey(nameof(Tarifa))]
    public int TarifaId { get; set; }

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