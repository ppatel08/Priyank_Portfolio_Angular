import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PortfolioComponent } from './public/components/portfolio/portfolio.component';

const routes: Routes = [
  { path: 'portfolio', 
  loadChildren: () => import('./public/public.module').then(m => m.PublicModule) 
  },
  { path: 'admin', 
  loadChildren: () => import('./private/private.module').then(m => m.PrivateModule) 
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
