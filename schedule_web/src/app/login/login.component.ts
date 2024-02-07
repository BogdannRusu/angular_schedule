import { Component, OnInit } from '@angular/core';
import { ThemeService } from './theme.service';
import { ReactiveFormsModule, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {

  constructor(private themeService: ThemeService, private fb: FormBuilder) { }

  ngOnInit(): void {   this.setTheme();    }
  setTheme() { this.themeService.setThemeVariables('#1a1a2e', '#ffffff', '#0f3460'); }

  loginForm = this.fb.group({
    username: ['', [Validators.required, Validators.email]],
    password: ['', [Validators.required]]
  })

  //Return Username
  get Username() {  return this.loginForm.controls['username'];  }

  //Submit LoginForm
  onSubmit(){

  }
  
}

