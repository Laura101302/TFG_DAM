import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgChartsModule } from 'ng2-charts';
import { CabeceraComponent } from './components/cabecera/cabecera.component';
import { ErrorComponent } from './components/error/error.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PieComponent } from './components/pie/pie.component';
import { InicioSesionComponent } from './components/inicio-sesion/inicio-sesion.component';
import { SobreNosotrosComponent } from './components/sobre-nosotros/sobre-nosotros.component';
import { AboutComponent } from './pages/about/about.component';
import { InicioComponent } from './components/inicio/inicio.component';
import { MayoristasComponent } from './components/mayoristas/mayoristas.component';
import { WholesalersComponent } from './pages/wholesalers/wholesalers.component';
import { ProductMayoristaComponent } from './pages/product-mayorista/product-mayorista.component';
import { ProductosMayoristasComponent } from './components/productos-mayoristas/productos-mayoristas.component';
import { MensajeFinalComponent } from './components/mensaje-final/mensaje-final.component';
import { IndividualsComponent } from './pages/individuals/individuals.component';
import { ParticularesComponent } from './components/particulares/particulares.component';
import { ProductosParticularesComponent } from './components/productos-particulares/productos-particulares.component';
import { ProductParticularComponent } from './pages/product-particular/product-particular.component';
import { RegistroUsuarioComponent } from './components/registro-usuario/registro-usuario.component';
import { OpinionService } from './services/opinion.service';
import { PMayoristaService } from './services/pmayorista.service';
import { PParticularService } from './services/pparticular.service';
import { UsuarioService } from './services/usuario.service';
import { VParticularService } from './services/vparticular.service';
import { cookieHelper } from './helper/cookiehelper';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponentComponent,
    CabeceraComponent,
    ErrorComponent,
    PieComponent,
    InicioSesionComponent,
    SobreNosotrosComponent,
    AboutComponent,
    InicioComponent,
    MayoristasComponent,
    WholesalersComponent,
    ProductMayoristaComponent,
    ProductosMayoristasComponent,
    MensajeFinalComponent,
    IndividualsComponent,
    ParticularesComponent,
    ProductosParticularesComponent,
    ProductParticularComponent,
    RegistroUsuarioComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, ReactiveFormsModule, HttpClientModule, NgChartsModule, NgbModule],
  providers: [OpinionService, PMayoristaService, PParticularService, UsuarioService, VParticularService, cookieHelper],
  exports: [CabeceraComponent],
  bootstrap: [AppComponent],
})
export class AppModule {}
