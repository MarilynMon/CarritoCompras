import { Component, OnInit } from '@angular/core';

import { Persona } from 'src/app/models copy/Persona';
import {ApiService} from 'src/app/servicios/api/api.service';
import { ConsultaProductos, ProductosArray, ProductosResponse } from '../modelsLoguin/filter_services';
@Component({
  selector: 'app-empleado',
  templateUrl: './empleado.component.html',
  styleUrls: ['./empleado.component.css']
})
export class EmpleadoComponent{
  headers = new Headers({
    'Authorization':'Bearer',
    'Accept' : 'application/json; charset=utf-8',
    'Content-Type':'application/json; charset=utf-8',
    'Access-Control-Allow-Origin' : '*',
  });
  ProductoArray: ProductosArray[]= [];
url:string ="https://localhost:44311/api/services/app/Products/GetProducts";
descripcion :string="";
private consultaProductos!: ConsultaProductos;
constructor(private api: ApiService){

}
ngOnInit ()
  { this.OnIniciar();
  }
 selectProducto!: ProductosResponse;

OnIniciar()
{ debugger;
  this.consultaProductos = {transaccion:"generico",tipo:4}
  
  this.api.onInicio(this.consultaProductos).subscribe(data =>
    { console.log(data);
        for (let i =0; i<= data.length;i++)
        {
          //this.selectProducto.id = data[i].;
          this.selectProducto.descripcion = data[i].descripcion;
          this.selectProducto.detalle = data[i].detalle;
          this.selectProducto.precio = data[i].precio;
          /*this.selectProducto.cedula = data[i].cedula;
          this.selectProducto.usuario = data[i].usuario;
          this.selectProducto.contras = data[i].contras;
          this.selectProducto.fecha = data[i].fecha;
          this.selectProducto.direccion = data[i].direccion;
          this.selectProducto.telefono = data[i].telefono;
          this.selectProducto.estado_vac = data[i].estado_vac;*/
          this.ProductoArray.push(this.selectProducto);
         // this.selectProducto {detalle:"", this.descripcion:"", precio=0};
        }
    })
  ;

}
}



