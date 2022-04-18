using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLot.BackEnd.Data.Models;

public class Vehiculo
{
    [Key]
    [Required]
    public int Id { get; set; }

    [MaxLength(10), MinLength(5)]
    public string PlacaVehicular { get; set; }

    public int PersonaId { get; set; }

    [ForeignKey(nameof(Persona))]
    public Persona Persona { get; set; }

    public int TarifaId { get; set; }

    [ForeignKey(nameof(Tarifa))]
    public Tarifa Tarifa { get; set; }
}