import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder, FormArray } from '@angular/forms';


@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit {
  searchMacroForm=({})
  companyForm = this.fb.group({
    companyName: new FormControl('', [Validators.required]),
    admins: this.fb.array([])
  })
  constructor(private fb: FormBuilder) { 
    
  }
  get admins() {
    return this.companyForm.controls["admins"] as FormArray;
  }
 
  ngOnInit(): void {
    this.searchMacroForm=new FormGroup({
      searchMacro:new FormControl('',Validators.required), 
    })
  }

}
