import { Component, OnInit } from '@angular/core';
import {ApiService} from 'src/app/servicios/api/api.service';
import { DatosUsarios, LoguinUser } from '../modelsLoguin/filter_services';
@Component({
  selector: 'app-sesion',
  templateUrl: './sesion.component.html',
  styleUrls: ['./sesion.component.css']
})
export class SesionComponent {

  headers = new Headers({
    'Authorization':'Bearer',
    'Accept' : 'application/json; charset=utf-8',
    'Content-Type':'application/json; charset=utf-8',
    'Access-Control-Allow-Origin' : '*',
  });
  clave: string ="";
  usuario: string =""; 
  private loguinUser!: LoguinUser;
  private datosUsarios!: DatosUsarios;
  private sesion: string = "";
   

descripcion :string="";
constructor(private api: ApiService ){

}
ngOnInit ()
  { //this.OnIniciar();
  }

   respuesta: boolean=false;

IniciarSesion()
{ 
  this.datosUsarios = {email:"", password: ""};
  this.loguinUser = { transaccion: "",datosUsarios:this.datosUsarios};
  this.loguinUser.transaccion = "autenticarUsuario";
  console.log(this.loguinUser.transaccion);
  this.loguinUser.datosUsarios.email = ((document.getElementById("user") as HTMLInputElement).value);
  this.loguinUser.datosUsarios.password = ((document.getElementById("clave") as HTMLInputElement).value);
  
  this.api.onLoguin(this.loguinUser).subscribe(res => {
		const {codigoRetorno, mensajeRetorno} = res.result;
    console.log(codigoRetorno +" - "+mensajeRetorno);
          alert(mensajeRetorno);
					if (codigoRetorno != "0001")
          { window.location.reload();
          }
          
				});
  
}

}



