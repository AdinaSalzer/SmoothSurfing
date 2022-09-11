import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit {
  searchMacroForm=({});
    constructor() { }
 
  ngOnInit(): void {
    this.searchMacroForm=new FormGroup({
      searchMacro:new FormControl('',Validators.required), 
    })
  }

}
