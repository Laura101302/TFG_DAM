export class Usuario {
  id: number;

  nombreCompleto: string;

  contrasena: string | null;

  correoElectronico: string | null;

  constructor() {
    this.id = 0;
    this.nombreCompleto = "";
    this.contrasena = null;
    this.correoElectronico = null;
  }
}
