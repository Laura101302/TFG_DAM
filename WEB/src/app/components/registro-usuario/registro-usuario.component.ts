import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-registro-usuario',
  templateUrl: './registro-usuario.component.html',
  styleUrls: ['./registro-usuario.component.css']
})
export class RegistroUsuarioComponent implements OnInit {

  isOk: boolean | null;

  login = this.fb.group({
    correo: ['', Validators.required],
    contra: ['', Validators.required],
  });

  constructor(private fb: FormBuilder) {
    this.isOk = null;
  }

  onSubmit() {
    this.isOk =
      this.login.value.correo == 'admin@gmail.com' &&
      this.login.value.contra == 'pass';
      setTimeout("location.href='/'", 3000);
  }

  ngOnInit(): void {
  }

}
