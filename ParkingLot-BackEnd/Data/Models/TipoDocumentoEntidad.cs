using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLot.BackEnd.Data.Models;

[Table("TipoDocumentoEntidad")]
public class TipoDocumentoEntidad
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(1)]
    public string Codigo { get; set; }
    [Required]
    [MaxLength(10), MinLength(3)]
    public string Abreviatura { get; set; }
    [Required]
    [MaxLength(100), MinLength(5)]
    public string Nombre { get; set; }
}