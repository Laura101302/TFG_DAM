import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';
import { InputFilterComponent } from './components/input-filter/input-filter.component';
import { ListBooksComponent } from './components/list-books/list-books.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BookService } from './services/book.service';
import { CreateBookComponent } from './components/create-book/create-book.component';
import { NgChartsModule } from 'ng2-charts';
import { LineChartComponent } from './components/line-chart/line-chart.component';
import { BarChartComponent } from './components/bar-chart/bar-chart.component';
import { FaltasService } from './services/faltas.service';
import { CabeceraComponent } from './components/cabecera/cabecera.component';
import { ErrorComponent } from './components/error/error.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PieComponent } from './components/pie/pie.component';
import { InicioSesionComponent } from './components/inicio-sesion/inicio-sesion.component';
import { SobreNosotrosComponent } from './components/sobre-nosotros/sobre-nosotros.component';
import { AboutComponent } from './pages/about/about.component';
import { InicioComponent } from './components/inicio/inicio.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponentComponent,
    InputFilterComponent,
    ListBooksComponent,
    CreateBookComponent,
    LineChartComponent,
    BarChartComponent,
    CabeceraComponent,
    ErrorComponent,
    PieComponent,
    InicioSesionComponent,
    SobreNosotrosComponent,
    AboutComponent,
    InicioComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, ReactiveFormsModule, HttpClientModule, NgChartsModule, NgbModule],
  providers: [BookService, FaltasService],
  bootstrap: [AppComponent],
})
export class AppModule {}
