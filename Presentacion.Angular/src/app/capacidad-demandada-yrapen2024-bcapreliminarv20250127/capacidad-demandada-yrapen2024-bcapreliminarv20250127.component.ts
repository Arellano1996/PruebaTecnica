import { Component, inject, ViewChild } from '@angular/core';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatSort, MatSortModule, Sort } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { SistemaBajaCaliforniaPreliminarService } from './services/sistema-baja-california-preliminar.service';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { SistemaBajaCaliforniaPreliminarInterface } from './interfaces/sistema-baja-california-preliminar.interface';

@Component({
  selector: 'app-capacidad-demandada-yrapen2024-bcapreliminarv20250127',
  imports: [MatTableModule, MatSortModule, MatPaginatorModule],
  templateUrl: './capacidad-demandada-yrapen2024-bcapreliminarv20250127.component.html',
  //styleUrl: './capacidad-demandada-yrapen2024-bcapreliminarv20250127.component.css'
})
export default class CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127Component {
private _liveAnnouncer = inject(LiveAnnouncer);
  private sistemaService = inject(SistemaBajaCaliforniaPreliminarService);

  displayedColumns: string[] = [
    'id', 
    'zonaDePotencia', 
    'participante', 
    'subCuentaDelParticipante', 
    'capacidadDemandadaMW', 
    'requisitoAnualDePotenciaMWAnio', 
    'valorDelRequisitoAnualDePotenciaEficienteMWAnio'
  ];

  dataSource = new MatTableDataSource<SistemaBajaCaliforniaPreliminarInterface>();

  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatPaginator) paginator!: MatPaginator;

  ngOnInit(): void {
    console.log('Iniciando servicio...');
    this.sistemaService.getDatosSistemaBajaCalifornia().subscribe({
      next: (res: SistemaBajaCaliforniaPreliminarInterface[]) => {
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
