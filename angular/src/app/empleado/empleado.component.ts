import { Component, OnInit } from '@angular/core';
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
  ListaProdcuts : any =[];
private consultaProductos!: ConsultaProductos;
constructor(private api: ApiService){

}
ngOnInit ()
  { this.OnIniciar();
  }

OnIniciar()
{
  this.consultaProductos = {transaccion:"generico",tipo:4}

  this.api.onInicio(this.consultaProductos).subscribe(data =>
    { console.log(data);
      this.ListaProdcuts=data;
    })
  ;

}
}



