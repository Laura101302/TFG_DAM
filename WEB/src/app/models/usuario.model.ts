export class Usuario {
  id: number;

  nombrecompleto: string | null;

  contrasena: string | null;

  correoelectronico: string | null;

  constructor() {
    this.id = 0;
    this.nombrecompleto = null;
    this.contrasena = null;
    this.correoelectronico = null;
  }
}
