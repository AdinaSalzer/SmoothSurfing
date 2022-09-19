import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';
import { exit } from "nativescript-exit"

@Component({
  selector: 'app-veiw-video',
  templateUrl: './veiw-video.component.html',
  styleUrls: ['./veiw-video.component.scss']
})
export class VeiwVideoComponent implements OnInit {

  constructor(private location: Location) 
    {}
    previousScreen() { //return to previous screen
      this.location.back();
    }
      public exitSmoothSurfing(): void {
        exit(); // will close application
      }
    
  ngOnInit(): void {
  }
 
}
