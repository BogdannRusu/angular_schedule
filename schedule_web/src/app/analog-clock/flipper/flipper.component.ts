import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-flipper',
  templateUrl: './flipper.component.html',
  styleUrls: ['./flipper.component.css']
})
export class FlipperComponent {
  @Input() value: string = '00';
}
