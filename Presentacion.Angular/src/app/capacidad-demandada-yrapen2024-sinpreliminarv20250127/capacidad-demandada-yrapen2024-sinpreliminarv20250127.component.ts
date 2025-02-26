import { Component, inject, ViewChild } from '@angular/core';
import { SistemaInterconectadoNacionalPreliminarService } from './Services/sistema-interconectado-nacional-preliminar.service';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { SistemaInterconectadoNacionalPreliminarInterface } from './interfaces/sistema-interconectado-nacional-preliminar.interface';
import { MatSort, MatSortModule, Sort } from '@angular/material/sort';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';

@Component({
  selector: 'app-capacidad-demandada-yrapen2024-sinpreliminarv20250127',
  imports: [MatTableModule, MatSortModule, MatPaginatorModule, MatFormFieldModule, MatInputModule, MatTableModule],
  templateUrl: './capacidad-demandada-yrapen2024-sinpreliminarv20250127.component.html',
  //styleUrl: './capacidad-demandada-yrapen2024-sinpreliminarv20250127.component.css'
})
export default class CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Component {
  private _liveAnnouncer = inject(LiveAnnouncer);
  private sistemaService = inject(SistemaInterconectadoNacionalPreliminarService);

  displayedColumns: string[] = [
    'id', 
    'zonaDePotencia', 
    'participante', 
    'subCuentaDelParticipante', 
    'capacidadDemandadaMW', 
    'requisitoAnualDePotenciaMWAnio', 
    'valorDelRequisitoAnualDePotenciaEficienteMWAnio'
  ];

  dataSource = new MatTableDataSource<SistemaInterconectadoNacionalPreliminarInterface>();

  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatPaginator) paginator!: MatPaginator;

  ngOnInit(): void {
    console.log('Iniciando servicio...');
    this.sistemaService.getDatosSistemaInterconectadoNacionalPreliminar().subscribe({
      next: (res: SistemaInterconectadoNacionalPreliminarInterface[]) => {
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
