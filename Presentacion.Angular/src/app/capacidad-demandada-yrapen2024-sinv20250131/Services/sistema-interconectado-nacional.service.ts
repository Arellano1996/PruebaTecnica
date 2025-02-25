import { inject, Injectable } from '@angular/core';
import { environments } from '../../environments/environments';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SistemaInterconectadoNacionalService {

  private baseUrl: string = environments.urlServido;
  
  httpClient = inject(HttpClient)

  
}
