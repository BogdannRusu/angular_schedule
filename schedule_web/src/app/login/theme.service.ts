import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ThemeService {

  constructor() { }

  setThemeVariables(background: string, color: string = '#FFFFFF', primaryColor: string) {
    document.documentElement.style.setProperty('--background', background);
    document.documentElement.style.setProperty('--color', color);
    document.documentElement.style.setProperty('--primary-color', primaryColor);
  }

}
