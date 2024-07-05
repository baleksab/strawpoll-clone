import { Component, EventEmitter, Output } from '@angular/core';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { RouterLink } from '@angular/router';
import { NavbarLink } from '../../models/navbar-link.interface';
import { MatSidenav, MatSidenavModule } from '@angular/material/sidenav';

@Component({
    selector: 'app-navbar',
    standalone: true,
    templateUrl: './navbar.component.html',
    styleUrl: './navbar.component.scss',
    imports: [
        MatToolbarModule,
        MatIconModule,
        MatButtonModule,
        RouterLink,
        MatSidenavModule,
        MatSidenav,
    ]
})
export class NavbarComponent {
  @Output() sideNavToggle: EventEmitter<void> = new EventEmitter<void>();

  navLinks: NavbarLink[] = [
    { label: 'Create Poll', url: 'create' },
    { label: 'Demo', url: 'demo' }
  ];
}
