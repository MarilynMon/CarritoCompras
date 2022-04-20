import { Injectable } from '@angular/core';
import {responseI} from 'src/app/models copy/response';
import { HttpClient,HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Persona } from 'src/app/models copy/Persona';
import { map } from 'rxjs/operators';
import { ConsultaProductos, LoguinUser, ProductosResponse } from 'src/app/modelsLoguin/filter_services';
@Injectable({
  providedIn: 'root'
})

export class ApiService {

  headers = new Headers({
    'Authorization':'Bearer',
    'Accept' : 'application/json; charset=utf-8',
    'Content-Type':'application/json; charset=utf-8',
    'Access-Control-Allow-Origin' : '*',
  });

  ngOnInit(): void{
  //  this.onInicio();
  }

urlSesion:string ="https://localhost:44311/api";

descripcion :string="";
  constructor( public http:HttpClient) { }
  httpOptions = {headers: new HttpHeaders({'Content-Type': 'application/json'})
};

  onInicio(filters: ConsultaProductos):Observable<ProductosResponse[]>{
    let direccion = "https://localhost:44311/api/services/app/Products/GetProducts";
		let params = new HttpParams().set('transaccion', filters.transaccion).set('tipo', filters.tipo);
		return this.http.get<ProductosResponse[]>(`${direccion}`, { params })
    ;
  }


  onLoguin(filters:LoguinUser):Observable<any>{
    let headers = new HttpHeaders();
		headers.set('enctype', 'multipart/form-data');
		headers.set('Content-Type', 'multipart/form-data');
    this.urlSesion = this.urlSesion + "/services/app/Products/LoginUser";
		return this.http.post<any>(this.urlSesion, filters, {
			headers: headers,
		});

}
}
