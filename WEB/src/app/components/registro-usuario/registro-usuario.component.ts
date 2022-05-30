import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Usuario } from 'src/app/models/usuario.model';
import { UsuarioService } from 'src/app/services/usuario.service';

@Component({
  selector: 'app-registro-usuario',
  templateUrl: './registro-usuario.component.html',
  styleUrls: ['./registro-usuario.component.css']
})
export class RegistroUsuarioComponent implements OnInit {

  usuario: Usuario | null;

  signup = this.fb.group({
    nombre: ['', Validators.required],
    correo: ['', Validators.required],
    contra: ['', Validators.required],
    biscontra: ['', Validators.required]
  });

  constructor(private fb: FormBuilder, private _usuario: UsuarioService) {
    this.usuario = null;
  }

  ngOnInit(): void {
  }

  onSubmit() {;
    this.comprobacion();
  }

  comprobacion(){
    try{
      if(this.signup.value.contra == this.signup.value.biscontra){
        this._usuario.postUsuarioData(this.signup.value);
        window.alert("Usuario creado correctamente\nPulse 'Aceptar' para volver a la página pricipal");
        setTimeout("location.href='/'");
      }else{
        window.alert("Las contraseñas no coinciden");
      }
    }catch{
      console.log("Las contraseñas no coinciden");
    }
  }
}
