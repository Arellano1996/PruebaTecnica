import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { AlturaNavBar } from './core/constantes';

@Component({
  selector: 'app-root',
  imports: [
    RouterOutlet,
    NavbarComponent
  ],
  templateUrl: './app.component.html',
  //styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'PruebaTecnica';
  alturaNavBar = AlturaNavBar
}
