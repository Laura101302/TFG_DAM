import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { cookieHelper } from 'src/app/helper/cookiehelper';
import { Usuario } from 'src/app/models/usuario.model';
import { UsuarioService } from 'src/app/services/usuario.service';

@Component({
  selector: 'app-inicio-sesion',
  templateUrl: './inicio-sesion.component.html',
  styleUrls: ['./inicio-sesion.component.css']
})
export class InicioSesionComponent implements OnInit {

  usuario: Usuario | null;

  login = this.fb.group({
    correo: ['', Validators.required],
    contra: ['', Validators.required],
  });

  constructor(private fb: FormBuilder, private _usuario: UsuarioService, private cookie: cookieHelper) {
    this.usuario = null;
  }

  onSubmit() {
    this._usuario.getUsuarioData(this.login.value.correo).subscribe((x) => (this.usuario = x) && this.comprobacion(x.nombreCompleto));
  }

  ngOnInit(): void {
    if(this.cookie.getCookie() != ""){
      setTimeout("location.href='/'")
    }
  }

  comprobacion(nombre: string){
    try{
      if(this.login.value.contra == this.usuario?.contrasena){
        this.cookie.setCookie(nombre);
        setTimeout("location.href='/'")
        window.alert("Inicio de sesión correcto\nPulse 'Aceptar' para volver a la página principal");
      }else{
        window.alert("El usuario y/o la contraseña no son correctos");
      }
    }catch{
      console.log("Usuario/Contraseña erróneo")
    }
  }
}
