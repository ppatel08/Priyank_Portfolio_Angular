import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpService } from 'src/app/core/services/http.service';
import { environment } from 'src/environments/environment';
import { GetPortfolioDetail_API, SendMessage_API } from '../constants/api-endpoint';

@Injectable({
  providedIn: 'root'
})
export class PortfolioService {

  private portfolioApiUrl: string = environment.url;
  
  constructor(private http: HttpService) { }

  getPortfolioDetails(payload : any): Observable<any> {
    return this.http.get(this.portfolioApiUrl + GetPortfolioDetail_API + '?username=' +  payload);
  }
  sendMessage(payload : any): Observable<any> {
    return this.http.post(this.portfolioApiUrl + SendMessage_API,  payload);
  }
  

}
