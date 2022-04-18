using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLot.BackEnd.Data.Models;

[Table("Vehiculo")]
public class Vehiculo
{
    [Key]
    [Required]
    public int Id { get; set; }

    [MaxLength(10), MinLength(5)]
    public string PlacaVehicular { get; set; }

    [ForeignKey(nameof(Persona))]
    public int PersonaId { get; set; }

    public Persona Persona { get; set; }

    [ForeignKey(nameof(Tarifa))]
    public int TarifaId { get; set; }

    public Tarifa Tarifa { get; set; }
}