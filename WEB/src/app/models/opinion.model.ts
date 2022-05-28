export class Opinion {
  id: number;

  nombre: string | null;

  apellidos: string | null;

  correoElectronico: string | null;

  telefono: string | null;

  comentario: string | null;

  calificacion: number;

  constructor() {
    this.id = 0;
    this.nombre = null;
    this.apellidos = null;
    this.correoElectronico = null;
    this.telefono = null;
    this.comentario = null;
    this.calificacion = 0;
  }
}
