import { Component, OnInit } from '@angular/core';
import { ThemeService } from './theme.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private themeService: ThemeService) { }

  ngOnInit(): void {
    this.setTheme();
  }

  setTheme() {
    this.themeService.setThemeVariables('#1a1a2e', '#ffffff', '#0f3460');
  }

}
