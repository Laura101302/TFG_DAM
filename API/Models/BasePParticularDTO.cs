/// <summary>
/// Base DTO de ProductosParticulares
/// </summary>
public class BasePParticularDTO
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Descripcion { get; set; }
    public string Imagen { get; set; }
    public int ID_Vendedor { get; set; }
}