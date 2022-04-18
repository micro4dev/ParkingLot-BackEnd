using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ParkingLot.BackEnd.Data.Models;

public class Persona
{
    [Key]
    [Required]
    public int Id { get; set; }

    public DateTime FechaRegistro { get; set; }

    [MaxLength(150), MinLength(50)]
    public string Nombre { get; set; }

    public int TipoDocumentoId { get; set; }

    [ForeignKey(nameof(TipoDocumentoEntidad))]
    public TipoDocumentoEntidad TipoDocumento { get; set; }

    [MaxLength(25), MinLength(8)]
    public string NumeroDocumento { get; set; }

    [MaxLength(100), MinLength(50)]
    public string CorreoElectronico { get; set; }


    [ForeignKey(nameof(Ubigeo))]
    public int UbigeoId { get; set; }

    public Ubigeo Ubigeo { get; set; }

    [MaxLength(150), MinLength(50)]
    public string Direccion { get; set; }


}