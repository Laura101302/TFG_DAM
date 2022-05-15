export class Opinion {
  id: number;

  nombre: string | null;

  apellidos: string | null;

  telefono: string | null;

  comentario: string | null;

  calificacion: number;

  correoelectronico: string | null;

  constructor() {
    this.id = 0;
    this.nombre = null;
    this.apellidos = null;
    this.telefono = null;
    this.comentario = null;
    this.calificacion = 0;
    this.correoelectronico = null;
  }
}
