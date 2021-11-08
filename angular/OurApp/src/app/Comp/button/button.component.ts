import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {
  @Input('buttontext') buttontext='';
  @Input('btnclass') btnclass='btn-primary';
  constructor() { }

  ngOnInit(): void {
  }

}
