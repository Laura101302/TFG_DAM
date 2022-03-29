import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-inicio-sesion',
  templateUrl: './inicio-sesion.component.html',
  styleUrls: ['./inicio-sesion.component.css']
})
export class InicioSesionComponent implements OnInit {

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
