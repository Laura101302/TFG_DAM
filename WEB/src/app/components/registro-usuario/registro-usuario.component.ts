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

  constructor(private fb: FormBuilder, private _usuario: UsuarioService) {
    this.usuario = null;
  }

  ngOnInit(): void {
  }

  signupForm = this.fb.group({
    nombre: ['', Validators.required],
    correo: ['', Validators.required],
    contra: ['', Validators.required],
  });

  onSubmit() {
    this._usuario.postUsuarioData(this.signupForm.value);
    setTimeout("location.href='/'", 3000);
  }
}
