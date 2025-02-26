import { inject, Injectable } from '@angular/core';
import { SistemaInterconectadoNacionalPreliminarInterface } from '../interfaces/sistema-interconectado-nacional-preliminar.interface';
import { map, Observable } from 'rxjs';
import { environments } from '../../environments/environments';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SistemaInterconectadoNacionalPreliminarService {
  
  private baseUrl: string = environments.urlServido;
  
  http = inject(HttpClient)

  getDatosSistemaInterconectadoNacionalPreliminar():Observable<SistemaInterconectadoNacionalPreliminarInterface[]>{
    return this.http.get<SistemaInterconectadoNacionalPreliminarInterface[]>(`${ this.baseUrl }CapacidadDemandadaYRAPEn2024SINPreliminarv20250127`)
    .pipe(
      map(res => {
        return res
      })
    )
  }
}
