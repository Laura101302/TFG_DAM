import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ErrorComponent } from './components/error/error.component';
import { InicioSesionComponent } from './components/inicio-sesion/inicio-sesion.component';
import { MensajeFinalComponent } from './components/mensaje-final/mensaje-final.component';
import { AboutComponent } from './pages/about/about.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';
import { ProductMayoristaComponent } from './pages/product-mayorista/product-mayorista.component';
import { WholesalersComponent } from './pages/wholesalers/wholesalers.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponentComponent,
  },
  {
    path: 'mayoristas',
    component: WholesalersComponent,
  },
  {
    path: 'mayoristas/productos/1',
    component: ProductMayoristaComponent,
  },
  {
    path: 'exito',
    component: MensajeFinalComponent,
  },
  {
    path: 'sobre-nosotros',
    component: AboutComponent,
  },
  {
    path: 'sign-in',
    component: InicioSesionComponent,
  },
  {
    path: '**',
    component: ErrorComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
