
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ConsultaProductos, LoguinUser } from '../models/filter_services';


@Injectable({
  providedIn: 'root'
})
export class CompensationService {

  private Url = "https://localhost:44311/api";
  constructor(private http: HttpClient) { 
  }


  GetProducts(filters: ConsultaProductos): Observable<any> {
    let params = new HttpParams();

    Object.keys(filters).forEach(function (key) {
      if (filters[key] != null)
        params = params.append(key, filters[key]);
    });

    return this.http.get<any>(`${this.Url}/services/app/Products/GetProducts`, { params }).pipe(map(result => result['result']));
  }

  
  CrearTokenLoguin(filters:LoguinUser):Observable<any>{

    let json = JSON.stringify(filters);
      return this.http.post<any>(`${this.Url}/services/app/Products/LoginUser`,filters).
        pipe(map(result=>result['result']));
    }
}