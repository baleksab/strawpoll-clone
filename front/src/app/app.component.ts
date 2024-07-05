import { SidenavComponent } from './core/components/sidenav/sidenav.component';
import { Component } from '@angular/core';
import { NavbarComponent } from "./core/components/navbar/navbar.component";
import { MatSidenav, MatSidenavContainer, MatSidenavContent } from '@angular/material/sidenav';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.scss',
    imports: [
      NavbarComponent,
      MatSidenavContainer,
      MatSidenav,
      MatSidenavContent,
      SidenavComponent
    ]
})
export class AppComponent {

}
