import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import Swal from 'sweetalert2';
import { Cliente } from '../core/interfaces/cliente.interface';
import { ClientService } from '../core/services/client.service';
import { ClienteService } from './cliente.service';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.scss']
})
export class ClienteComponent implements OnInit {

  public IsWaiting: boolean;
  public showListado: boolean = true;
  public showForm: boolean = false;
  public showBtnActualizar: Boolean = false;
  public eliminado: boolean = true;
  public activo: boolean = true;
  public etiquetaListado = "Listado de Clientes";
  public etiquetaNombreModulo = "Campos";
  public detaForm: FormGroup;

  public cliente: any;
//  listaClientes: Array<Cliente> = [];
  public listaClientes: [any];//: any = [];

  mockedItems: SelItem[] = [
    {'value': '1', 'nombre': 'CC'},
    {'value': '2', 'nombre': 'CE'},
    {'value': '3', 'nombre': 'NIT'},
    {'value': '4', 'nombre': 'CD'},
    {'value': '5', 'nombre': 'PS'}
  ];

  public IsWaitings: boolean=false;
  public acts: SelItem[] = this.mockedItems;
  public firms: SelItem[] = this.mockedItems;

  constructor(public _clientService: ClientService, public clienteService: ClienteService) {
    
    this.cliente = {
      documento: "",
      nombre: "",
    };
  }

  onClientSelected(selected) {//: Cliente

    this.cliente = selected;
    this.IsWaitings = true;

    /*this.detaForm.controls["act_id"].setValue(selected.tipoIdentificacion);
    this.detaForm.controls["name"].setValue(selected.name); */
  }

  /*actionAdicionar() {
    this.showListado = false;
    this.showForm = true;
  }*/

  procesarRolAdd(rolSelected: any ){
    this.detaForm.controls['act_id'].setValue(rolSelected.value);
  }

  /*procesarFirma(rolSelected: any ){
    this.detaForm.controls['firma'].setValue(rolSelected.value);
  }*/

  guardar() {
    let newClient: Cliente = {
//      id: this.application.id,
        tipoIdentificacion: this.detaForm.controls["act_id"].value,
        identificacion: this.detaForm.controls["identificacion"].value,
        name: this.detaForm.controls["name"].value,
        activo: this.detaForm.controls["activo"].value,
        eliminado: this.detaForm.controls["eliminado"].value
    };

    console.log("---*****TTTTT//////", newClient)
    
    this.clienteService.createCliente(newClient).subscribe(async () => {
      
    });
  }
  /*this.showForm = false;
    this.showListado = true;*/

  cancelar() {
    this.showForm = false;
    this.showListado = true;
  }

  actionActualizar(){}

  eliminar() {
    /*Swal.fire({
      title: "Realmente quieres eliminar la Applicación seleccionada?",
      showCancelButton: true,
      confirmButtonText: `Aceptar`,
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.applicationService
          .deleteApplication(this.application.id)
          .subscribe((res) => {
            this.showForm = false;
            this.aplicacionForm.reset();
            Swal.fire(
              "Operación exitosa",
              "Aplicación Eliminada Correctamente!.",
              "success"
            );
            this.fetchApplications();
            this.showListado = true;
            this.showContent = true;
          });
      } else if (result.isDenied) {
      }
    });*/
  }

  listClientes = (obj?) => {
    this.IsWaiting = true;
    this._clientService.getAll(obj).subscribe((res) => {
      console.log("-||--*****PERO QUE TRAJO", res.objetoResultado)
      this.listaClientes = res.objetoResultado;
      this.IsWaiting = false;
    });
  };

  ngOnInit() {
    this.detaForm = new FormGroup({
      _id: new FormControl("", [Validators.maxLength(50)]),

      act_id: new FormControl("", [
        Validators.required,
        Validators.maxLength(50),
      ]),

      name: new FormControl("", [
        Validators.required,
        Validators.maxLength(50),
      ]),

      lastName: new FormControl("", [
        Validators.required,
        Validators.maxLength(50),
      ]),

      identificacion: new FormControl("", [
        Validators.required,
        Validators.maxLength(50),
      ]),

      activo: new FormControl("", [
        Validators.required,
        Validators.maxLength(50),
      ]),

      eliminado: new FormControl("", [
        Validators.required,
        Validators.maxLength(50),
      ]),

      email: new FormControl("", [
        Validators.required,
        Validators.maxLength(50),
      ]),

      phoneNumber: new FormControl("", [
        Validators.required,
        Validators.maxLength(50),
      ]),

      urlPhoto: new FormControl("", [Validators.maxLength(500)])
    });
//    this.listClientes();
  }
}

interface SelItem {
  nombre: string;
  value: string;
}
