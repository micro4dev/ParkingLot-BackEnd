using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLot.BackEnd.Data.Models;

public class Tarifa
{
    [Key]
    [Required]
    public int Id { get; set; }

    [MaxLength(150), MinLength(50)]
    public string Nombre { get; set; }

    [MaxLength(5)]
    public string HoraInicialDia { get; set; }

    [MaxLength(5)]
    public string HoraFinalDia { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal PrecioHoraFraccion { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal PrecioDia{ get; set; }

    public int MinutosTolerancia { get; set; }

    [MaxLength(5)]
    public string HoraInicialNoche { get; set; }

    [MaxLength(5)]
    public string HoraFinalNoche { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal MultaNoche { get; set; }


}