import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { PortfolioService } from '../services/portfolio.service';

@Component({
  selector: 'app-public',
  templateUrl: './public.component.html',
  styleUrls: ['./public.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class PublicComponent implements OnInit{
  porfolioDetail : any;
  constructor(public  portfolioService: PortfolioService){

  }
  ngOnInit() {
    this.getPortfolioDetails();
 }
  
 getPortfolioDetails(){
  var username='priyank';
  this.portfolioService.getPortfolioDetails(username).subscribe((res)=>{
    console.log(res);
    this.porfolioDetail = res;
  })
 }
}
