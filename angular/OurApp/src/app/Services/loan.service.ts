import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoanService {

  constructor(private http: HttpClient) { }

  getAll(){
    return this.http.get('https://localhost:44337/api/loan-type/get-all');
  }
  create(loan:any){
    return this.http.post('https://localhost:44337/api/loan-type/create', loan);
  }
}
