using System.ComponentModel.DataAnnotations;

namespace ParkingLot.BackEnd.Data.Models;

public class Ubigeo
{
    [Key]
    [Required]
    public int Id { get; set; }
    [MaxLength(6)]
    public string CodigoUbigeo { get; set; }
    [MaxLength(2)]
    public string CodigoDepartamento { get; set; }
    [MaxLength(100)]
    public string NombreDepartamento { get; set; }
    [MaxLength(2)]
    public string CodigoProvincia { get; set; }
    [MaxLength(100)]
    public string NombreProvincia { get; set; }
    [MaxLength(2)]
    public string CodigoDistrito { get; set; }
    [MaxLength(100)]
    public string NombreDistrito { get; set; }
}