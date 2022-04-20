import { Component, Injector, ChangeDetectionStrategy } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { FormControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ConsultaProductos, LoguinUser } from '../models/filter_services';
import{CompensationService} from '../services/compensation.service'

@Component({
  templateUrl: './home.component.html',
  animations: [appModuleAnimation()],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class HomeComponent extends AppComponentBase {
  filterForm: FormGroup;
  private productFB: FormBuilder;
  private loguinInput: LoguinUser;
  private compensationService: CompensationService;
  constructor(injector: Injector) {
    super(injector);
    
    filterForm: FormGroup;
  }

  ngOnInit()
  {
    this.filterForm = this.productFB.group({
      user : new FormControl("", []),
      contraseña : new FormControl("", []),
      loguin: new FormControl("", []),
    });
  }


  consultarLoguin(){
     this.loguinInput.Transaccion= "autenticarUsuario";
     this.loguinInput.DatosUsarios.Email = this.filterForm.get("user").value;
     this.loguinInput.DatosUsarios.Password = this.filterForm.get("contraseña").value;

     this.compensationService.CrearTokenLoguin(this.loguinInput).subscribe(
       data => {
        console.log(data.result.token);
     });

  }

}
