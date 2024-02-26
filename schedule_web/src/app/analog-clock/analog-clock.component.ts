import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-clock',
  templateUrl: './analog-clock.component.html',
  styleUrls: ['./analog-clock.component.css']
})
export class ClockComponent implements OnInit {

  hour: string = '00';
  minute: string = '00';
  second: string = '00';

  constructor() { }

  ngOnInit(): void {
    this.setTime();
  }

  setTime() {
    setInterval(() => {
      const date = new Date();
      this.second = this.formatTime(date.getSeconds());
      this.minute = this.formatTime(date.getMinutes());
      let hour = date.getHours();
      hour = (hour > 12) ? hour - 12 : hour;
      hour = (hour == 0) ? 12 : hour;
      this.hour = this.formatTime(hour);
    }, 1000);
  }

  formatTime(time: number): string {
    return (time < 10) ? '0' + time : time.toString();
  }
}
