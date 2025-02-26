import { inject, Injectable } from '@angular/core';
import { environments } from '../../environments/environments';
import { HttpClient } from '@angular/common/http';
import { map, Observable } from 'rxjs';
import { SistemaBajaCaliforniaSurInterface } from '../interfaces/sistema-baja-california.interface';

@Injectable({
  providedIn: 'root'
})
export class SistemaBajaCaliforniaSurService {
  private baseUrl: string = environments.urlServido;
    
  http = inject(HttpClient)

  getDatosSistemaBajaCalifornia():Observable<SistemaBajaCaliforniaSurInterface[]>{
    return this.http.get<SistemaBajaCaliforniaSurInterface[]>(`${ this.baseUrl }CapacidadDemandadaYRAPEn2024BCSv20250131`)
    .pipe(
      map(res => {
        return res
      })
    )
  }
}
