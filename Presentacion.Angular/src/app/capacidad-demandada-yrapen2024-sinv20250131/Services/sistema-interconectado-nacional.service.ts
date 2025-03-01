import { inject, Injectable } from '@angular/core';
import { environments } from '../../environments/environments';
import { HttpClient } from '@angular/common/http';
import { SistemaInterconectadoNacionalInterface } from '../interfaces/sistema-interconectado-nacional.interface';
import { map, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SistemaInterconectadoNacionalService {

  private baseUrl: string = environments.urlServido;
  
  http = inject(HttpClient)

  getDatosSistemaInterconectadoNacional():Observable<SistemaInterconectadoNacionalInterface[]>{
    return this.http.get<SistemaInterconectadoNacionalInterface[]>(`${ this.baseUrl }CapacidadDemandadaYRAPEn2024SINv20250131`)
    .pipe(
      map(res => {
        return res
      })
    )
  }
}
