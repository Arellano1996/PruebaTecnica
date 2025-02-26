import { inject, Injectable } from '@angular/core';
import { environments } from '../../environments/environments';
import { map, Observable } from 'rxjs';
import { SistemaBajaCaliforniaInterface } from '../interfaces/sistema-baja-california.interface';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SistemaBajaCaliforniaService {
  private baseUrl: string = environments.urlServido;
    
  http = inject(HttpClient)

  getDatosSistemaBajaCalifornia():Observable<SistemaBajaCaliforniaInterface[]>{
    return this.http.get<SistemaBajaCaliforniaInterface[]>(`${ this.baseUrl }CapacidadDemandadaYRAPEn2024BCAv20250131`)
    .pipe(
      map(res => {
        return res
      })
    )
  }
}
