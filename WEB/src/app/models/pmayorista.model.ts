export class PMayorista {
  id: number;

  nombre: string | null;

  precio: number;

  descripcion: string | null;

  imagen: string | null;

  constructor() {
    this.id = 0;
    this.nombre = null;
    this.precio = 0;
    this.descripcion = null;
    this.imagen = null;
  }
}
