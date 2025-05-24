using PPAI_backend.datos.dtos;
using PPAI_backend.models.entities;

public class DatosOI
{
    public int Numero { get; set; }
    public DateTime FechaFin { get; set; }
    public string NombreEstacion { get; set; } = string.Empty;
    public int IdSismografo { get; set; } 
    public string EmpleadoId { get; set; }= string.Empty;
    public string EstadoId { get; set; } = string.Empty;

    public List<OrdenDeInspeccion> OrdenesDeInspeccion { get; set; } = new List<OrdenDeInspeccion>();
    public List<CambioEstadoDto> CambioEstado { get; set; } = new List<CambioEstadoDto>();
    
}

