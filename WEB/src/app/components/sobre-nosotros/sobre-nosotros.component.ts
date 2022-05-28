import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Opinion } from 'src/app/models/opinion.model';
import { OpinionService } from 'src/app/services/opinion.service';

@Component({
  selector: 'app-sobre-nosotros',
  templateUrl: './sobre-nosotros.component.html',
  styleUrls: ['./sobre-nosotros.component.css']
})
export class SobreNosotrosComponent implements OnInit {

  currentRate: number;
  opinion: Opinion[] | null;

  constructor(private fb: FormBuilder, private _opinion: OpinionService) {
    this.currentRate = 0;
    this.opinion = null;
  }

  ngOnInit(): void {
    //Muestra las opiniones que hay en la base de datos
    this._opinion
      .getOpinionData()
      .subscribe((x) => (this.opinion = x));
  }

  opinionForm = this.fb.group({
    Nombre: ['', Validators.required],
    Apellidos: ['', Validators.required],
    CorreoElectronico: ['', Validators.required],
    Telefono: ['', Validators.required],
    Comentario: ['', Validators.required],
  });

  onSubmit() {
    this._opinion.postOpinionData(
      this.opinionForm.value,
      this.currentRate
    );

  }
}
