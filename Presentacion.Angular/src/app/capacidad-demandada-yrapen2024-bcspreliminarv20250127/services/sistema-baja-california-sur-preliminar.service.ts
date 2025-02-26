import { inject, Injectable } from '@angular/core';
import { environments } from '../../environments/environments';
import { map, Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { SistemaBajaCaliforniaSurPreliminarInterface } from '../interfaces/sistema-baja-california-preliminar.interface';

@Injectable({
  providedIn: 'root'
})
export class SistemaBajaCaliforniaSurPreliminarService {

  private baseUrl: string = environments.urlServido;
      
  http = inject(HttpClient)

  getDatosSistemaInterconectadoNacionalPreliminar():Observable<SistemaBajaCaliforniaSurPreliminarInterface[]>{
    return this.http.get<SistemaBajaCaliforniaSurPreliminarInterface[]>(`${ this.baseUrl }CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127`)
    .pipe(
      map(res => {
        return res
      })
    )
  }
}
