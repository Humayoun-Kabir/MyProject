// src/app/services/employee.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from '../models/employee';

@Injectable({   // <-- Proper decorator syntax
  providedIn: 'root'
})
export class EmployeeService {
  private apiUrl = '/api/employees'; // Matches your ASP.NET Core route

  constructor(private http: HttpClient) { }

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.apiUrl);
  }
}
