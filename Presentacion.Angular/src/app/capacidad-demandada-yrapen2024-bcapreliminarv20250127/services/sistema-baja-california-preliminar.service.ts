import { inject, Injectable } from '@angular/core';
import { environments } from '../../environments/environments';
import { map, Observable } from 'rxjs';
import { SistemaBajaCaliforniaPreliminarInterface } from '../interfaces/sistema-baja-california-preliminar.interface';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
//CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127
export class SistemaBajaCaliforniaPreliminarService {
  private baseUrl: string = environments.urlServido;
    
  http = inject(HttpClient)

  getDatosSistemaBajaCalifornia():Observable<SistemaBajaCaliforniaPreliminarInterface[]>{
    return this.http.get<SistemaBajaCaliforniaPreliminarInterface[]>(`${ this.baseUrl }CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127`)
    .pipe(
      map(res => {
        return res
      })
    )
  }
}
