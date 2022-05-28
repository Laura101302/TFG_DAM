using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ProductosParticulares")]
public class PParticularEntity
{

    [MaxLength(100)]
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    [MaxLength(100)]
    public string Descripcion { get; set; }
    [MaxLength(100)]
    public string Imagen { get; set; }
    public int ID_Vendedor { get; set; }
    public int ID { get; set; }

}
