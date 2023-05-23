import { Component, Input } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-portfolio',
  templateUrl: './portfolio.component.html',
  styleUrls: ['./portfolio.component.scss']
})
export class PortfolioComponent {

  unique:any;

  Environment : string =  environment.siteURL;
  
  @Input() PersonalDetails : any = undefined;
  mainPersonalDetails:any= undefined;
  constructor(){
  }
  
}
