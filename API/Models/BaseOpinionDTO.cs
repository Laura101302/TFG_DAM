/// <summary>
/// Base DTO de Opiniones
/// </summary>
public class BaseOpinionDTO
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Telefono { get; set; }
    public string Comentario { get; set; }
    public int Calificacion { get; set; }
    public string CorreoElectronico { get; set; }
}