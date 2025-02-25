import { Routes } from '@angular/router';

export const routes: Routes = [
    {
        path: '',
        pathMatch: 'full',
        title: 'inicio',
        loadComponent: () => import('./inicio/inicio.component')
    },
    {
        path: 'capacidad-demandada-yrapen2024-sinv20250131',
        pathMatch: 'full',
        title: 'capacidad-demandada-yrapen2024-sinv20250131',
        loadComponent: () => import('./capacidad-demandada-yrapen2024-sinv20250131/capacidad-demandada-yrapen2024-sinv20250131.component')
    },
    {
        path: 'capacidad-demandada-yrapen2024-sinpreliminarv20250127',
        pathMatch: 'full',
        title: 'capacidad-demandada-yrapen2024-sinpreliminarv20250127',
        loadComponent: () => import('./capacidad-demandada-yrapen2024-sinpreliminarv20250127/capacidad-demandada-yrapen2024-sinpreliminarv20250127.component')
    },
    {
        path: 'capacidad-demandada-yrapen2024-bcsv20250131',
        pathMatch: 'full',
        title: 'capacidad-demandada-yrapen2024-bcsv20250131',
        loadComponent: () => import('./capacidad-demandada-yrapen2024-bcsv20250131/capacidad-demandada-yrapen2024-bcsv20250131.component')
    },
    {
        path: 'capacidad-demandada-yrapen2024-bcspreliminarv20250127',
        pathMatch: 'full',
        title: 'capacidad-demandada-yrapen2024-bcspreliminarv20250127',
        loadComponent: () => import('./capacidad-demandada-yrapen2024-bcspreliminarv20250127/capacidad-demandada-yrapen2024-bcspreliminarv20250127.component')
    },
    {
        path: 'capacidad-demandada-yrapen2024-bcav20250131',
        pathMatch: 'full',
        title: 'capacidad-demandada-yrapen2024-bcav20250131',
        loadComponent: () => import('./capacidad-demandada-yrapen2024-bcav20250131/capacidad-demandada-yrapen2024-bcav20250131.component')
    },
    {
        path: 'capacidad-demandada-yrapen2024-bcapreliminarv20250127',
        pathMatch: 'full',
        title: 'capacidad-demandada-yrapen2024-bcapreliminarv20250127',
        loadComponent: () => import('./capacidad-demandada-yrapen2024-bcapreliminarv20250127/capacidad-demandada-yrapen2024-bcapreliminarv20250127.component')
    },
    {
        path: '**',
        pathMatch: 'full',
        title: 'Página no encontrada',
        loadComponent: () => import('./shared/nofound/nofound.component')
    },

];
