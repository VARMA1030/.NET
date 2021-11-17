import { Component, OnInit } from '@angular/core';
import { eventModel } from 'src/Models/eventModel';
import { MyeventService } from '../myevent.service';

@Component({
  selector: 'app-eventlist',
  templateUrl: './eventlist.component.html',
  styleUrls: ['./eventlist.component.css']
})
export class EventlistComponent implements OnInit {
  eventdata: Array<eventModel>=[];
  constructor(private s:MyeventService) { }

  ngOnInit(): void {
    this.s.getEvents().subscribe(data => {
      this.eventdata = data;
      // console.log(this.supplierdata);
    });
  }
  // showevents(){
  //   this.s.getEvents().subscribe(data => {
  //     this.eventdata = data;
  //     // console.log(this.supplierdata);
  //   });
  // }

}
