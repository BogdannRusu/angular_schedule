import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from './service/auth.service';
import { ThemeService } from './theme.service';
import { FormControl, FormGroup, FormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  standalone: true,
  imports: [FormsModule]
})

export class LoginComponent implements OnInit {

  username: string;
  password: string;
  remember: boolean;

  constructor(
    private themeService: ThemeService, 
    private router: Router
    ) {
      this.username = '';
      this.password = '';
      this.remember = false;
    }

  ngOnInit(): void {   this.setTheme();    }
  setTheme() { this.themeService.setThemeVariables('#1a1a2e', '#ffffff', '#0f3460'); }

  loginForm = new FormGroup({
    username: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required])
  })

  login() {
    // Implement your login logic here
    console.log('Login clicked');
  }

  //Return Username
  get Username() {  return this.loginForm.controls['username'];  }

  //Submit LoginForm
  onSubmit(){
    this.router.navigate(['./header']);
  }
  
}