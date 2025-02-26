import { Component, inject, AfterViewInit, OnInit, ViewChild } from '@angular/core';
import { SistemaInterconectadoNacionalService } from './Services/sistema-interconectado-nacional.service';
import { SistemaInterconectadoNacionalInterface } from './interfaces/sistema-interconectado-nacional.interface';

import { LiveAnnouncer } from '@angular/cdk/a11y';
import { MatSort, Sort, MatSortModule } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatFormFieldModule } from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';

@Component({
  selector: 'app-capacidad-demandada-yrapen2024-sinv20250131',
  imports: [MatTableModule, MatSortModule, MatPaginatorModule, MatFormFieldModule, MatInputModule, MatTableModule],

  
  templateUrl: './capacidad-demandada-yrapen2024-sinv20250131.component.html',
})
export default class CapacidadDemandadaYRAPEn2024SINv20250131Component implements OnInit, AfterViewInit {
  
  private _liveAnnouncer = inject(LiveAnnouncer);
  private sistemaService = inject(SistemaInterconectadoNacionalService);

  displayedColumns: string[] = [
    'id', 
    'zonaDePotencia', 
    'participante', 
    'subCuentaDelParticipante', 
    'capacidadDemandadaMW', 
    'requisitoAnualDePotenciaMWAnio', 
    'valorDelRequisitoAnualDePotenciaEficienteMWAnio'
  ];

  dataSource = new MatTableDataSource<SistemaInterconectadoNacionalInterface>();

  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatPaginator) paginator!: MatPaginator;

  ngOnInit(): void {
    console.log('Iniciando servicio...');
    this.sistemaService.getDatosSistemaInterconectadoNacional().subscribe({
      next: (res: SistemaInterconectadoNacionalInterface[]) => {
        //console.log('Datos recibidos:', res);
        this.dataSource.data = res; // Solo actualiza los datos en lugar de crear una nueva instancia
      },
      error: (err) => {
        console.error('Error al obtener datos:', err);
      }
    });
  }

  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  /** Announce the change in sort state for assistive technology. */
  announceSortChange(sortState: Sort): void {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
}
