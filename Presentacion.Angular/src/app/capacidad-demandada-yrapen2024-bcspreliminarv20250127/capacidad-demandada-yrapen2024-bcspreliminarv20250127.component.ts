import { Component, inject, ViewChild } from '@angular/core';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatSort, MatSortModule, Sort } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { SistemaBajaCaliforniaSurPreliminarInterface } from './interfaces/sistema-baja-california-preliminar.interface';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { SistemaBajaCaliforniaSurPreliminarService } from './services/sistema-baja-california-sur-preliminar.service';

@Component({
  selector: 'app-capacidad-demandada-yrapen2024-bcspreliminarv20250127',
  imports: [MatTableModule, MatSortModule, MatPaginatorModule],
  templateUrl: './capacidad-demandada-yrapen2024-bcspreliminarv20250127.component.html',
  //styleUrl: './capacidad-demandada-yrapen2024-bcspreliminarv20250127.component.css'
})
export default class CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127Component {
private _liveAnnouncer = inject(LiveAnnouncer);
  private sistemaService = inject(SistemaBajaCaliforniaSurPreliminarService);

  displayedColumns: string[] = [
    'id', 
    'zonaDePotencia', 
    'participante', 
    'subCuentaDelParticipante', 
    'capacidadDemandadaMW', 
    'requisitoAnualDePotenciaMWAnio', 
    'valorDelRequisitoAnualDePotenciaEficienteMWAnio'
  ];

  dataSource = new MatTableDataSource<SistemaBajaCaliforniaSurPreliminarInterface>();

  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatPaginator) paginator!: MatPaginator;

  ngOnInit(): void {
    console.log('Iniciando servicio...');
    this.sistemaService.getDatosSistemaInterconectadoNacionalPreliminar().subscribe({
      next: (res: SistemaBajaCaliforniaSurPreliminarInterface[]) => {
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
}
