import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiResponse } from '../models/api-response';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  constructor(private http: HttpClient) {

  }

  post<T>(url: any, payload: any): Observable<ApiResponse<T>> {
    return this.http.post<ApiResponse<T>>(url, payload);
  }

  put<T>(url: any, payload: any): Observable<ApiResponse<T>> {
    return this.http.put<ApiResponse<T>>(url, payload);
  }

  get<T>(url: any, params?: any): Observable<ApiResponse<T>> {
    if (params)
      return this.http.get<ApiResponse<T>>(url, { params: params})
    else
      return this.http.get<ApiResponse<T>>(url);
  }

  delete<T>(url: any, payload: any): Observable<ApiResponse<T>> {
      return this.http.delete<ApiResponse<T>>(url, { body: payload})
  }
}
