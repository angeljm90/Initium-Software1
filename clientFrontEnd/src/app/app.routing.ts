import { Routes } from '@angular/router';

export const rootRouterConfig: Routes = [
  {
    path:'',
     redirectTo: 'sessions/signin',
     pathMatch:'full'
  },
  
  {
    path: '', 
  //  component: AuthLayoutComponent,
   children: [
    
    /*{ 
      path: 'evaluacionRealizada', 
      loadChildren: () => import('./views/inicio/evaluacionRealizada/evaluacionRealizada.module').then(m => m.EvaluacionRealizadaModule),
      data: { title: 'evaluación Realizada'} 
    },*/
   ]
  },
  { 
    path: '**', 
    redirectTo: 'sessions/404'
  }
];

