using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ProductosMayoristas")]
public class PMayoristaEntity
{

    [MaxLength(100)]
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    [MaxLength(100)]
    public string Descripcion { get; set; }
    [MaxLength(100)]
    public string Imagen { get; set; }
    public int ID { get; set; }

}
