import { AfterViewInit, Component, ElementRef, ViewChild } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements AfterViewInit {
  title: string = 'front';

  @ViewChild('test') testDiv!: ElementRef;

  ngAfterViewInit(): void {
    console.log(this.testDiv.nativeElement.innerHTML);
  }
}
