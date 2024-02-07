import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-clock',
  templateUrl: './analog-clock.component.html',
  styleUrls: ['./analog-clock.component.css']
})
export class ClockComponent implements OnInit {
  deg: number = 6;
  hour: any;
  min: any;
  sec: any;
  switchBtnText: string = "dark";

  ngOnInit() {
    this.hour = document.querySelector(".hour");
    this.min = document.querySelector(".min");
    this.sec = document.querySelector(".sec");
    this.setClock();

    setInterval(() => {
      this.setClock();
    }, 1000);
  }

  setClock() {
    let day = new Date();
    let hh = day.getHours() * this.deg;
    let mm = day.getMinutes() * this.deg;
    let ss = day.getSeconds() * this.deg;

    this.hour.style.transform = `rotateZ(${hh + mm / 12}deg)`;
    this.min.style.transform = `rotateZ(${mm}deg)`;
    this.sec.style.transform = `rotateZ(${ss}deg)`;
  }

  switchTheme() {
    if (this.switchBtnText.toLowerCase() === "light") {
      this.switchBtnText = "dark";
      document.documentElement.setAttribute("data-theme", "dark");
    } else {
      this.switchBtnText = "light";
      document.documentElement.setAttribute("data-theme", "light");
    }
  }
}
