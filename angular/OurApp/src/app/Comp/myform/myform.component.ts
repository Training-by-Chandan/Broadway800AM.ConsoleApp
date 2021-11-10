import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-myform',
  templateUrl: './myform.component.html',
  styleUrls: ['./myform.component.css']
})
export class MyformComponent implements OnInit {
 myform=new FormGroup({
   firstName:new FormControl(''), 
    lastName:new FormControl(''),
    email:new FormControl(''),
 });
 str:string="Test";
 payload:any;
  constructor() {

   }

  ngOnInit(): void {
    
  }

  onSubmit(){
    this.str=this.myform.value.firstName+", "+ this.myform.value.lastName+", "+ this.myform.value.email;
   
  }
  data:any;
  GetAllLoans(){
   // this.data=this.loans.getLoans();
  }
}
