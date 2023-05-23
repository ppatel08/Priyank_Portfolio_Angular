import { Component, Input, OnInit } from '@angular/core';
import Typed from 'typed.js';

@Component({
  selector: 'app-introduction',
  templateUrl: './introduction.component.html',
  styleUrls: ['./introduction.component.scss'],
})
export class IntroductionComponent implements OnInit {

  @Input() PersonalDetails: any = undefined;

backDelay : number=500;
  ngOnInit() {
    const options = {
      strings: ['Innovation.', 'Discovery.'],
      typeSpeed: 100,
      backSpeed: 100,
      showCursor: true,
      cursorChar: '|',
      loop: true,
    };
    const typed = new Typed('.typed-element', options);
  }
}
