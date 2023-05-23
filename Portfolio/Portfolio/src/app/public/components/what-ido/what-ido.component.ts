import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-what-ido',
  templateUrl: './what-ido.component.html',
  styleUrls: ['./what-ido.component.scss']
})
export class WhatIDoComponent {

  @Input() PersonalDetails : any = undefined;
}
