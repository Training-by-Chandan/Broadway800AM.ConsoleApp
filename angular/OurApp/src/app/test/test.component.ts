import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { LoanService } from '../Services/loan.service';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {
  data:any;
  items:any;
  testForm=new FormGroup({
    loanTitle:new FormControl(''),
    loanDescription:new FormControl(''),
  });
  constructor(private loanService: LoanService) { }

  ngOnInit(): void {
  
   this.getAll();
  }

  getAll()
  {
    this.loanService.getAll().subscribe((d)=>{
      this.items=d
      this.data=this.items.payload;
    });
  }
  Create(){
    this.loanService.create(this.testForm.value).subscribe((d)=>{
      this.items=d;
      this.data=this.items.payload;
    });
   
  }
}
