import { Component } from '@angular/core';
import { NavbarLink } from '../../models/navbar-link.interface';
import { RouterLink } from '@angular/router';
import { MatButtonModule } from '@angular/material/button';

@Component({
  selector: 'app-sidenav',
  standalone: true,
  imports: [
    RouterLink,
    MatButtonModule
  ],
  templateUrl: './sidenav.component.html',
  styleUrl: './sidenav.component.scss'
})
export class SidenavComponent {
  navLinks: NavbarLink[] = [
    { label: 'Create Poll', url: 'create' },
    { label: 'Demo', url: 'demo' }
  ];
}
