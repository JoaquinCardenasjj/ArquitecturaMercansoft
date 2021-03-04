import { HttpClient, HttpHeaders  } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import * as Globals from "../globals";
import { HttpService } from './HttpService';
import { ToolsService } from './tools.service';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  serverUrl: string;
  constructor(
    private http: HttpClient,
    private httpService: HttpService,
    private toolService: ToolsService
  ) {
    this.serverUrl = Globals.SERVER;
  }

  getAll(objeTosend: any): Observable<any> {
    let filtro = "";
    let params = "";
    let ordenamiento = "";

    if (objeTosend != null && objeTosend != undefined && objeTosend) {
      filtro = `filter: {
         ${Object.keys(objeTosend).map((prop) => {
           if (
             typeof objeTosend[prop] === "string" ||
             objeTosend[prop] instanceof String
           ) {
             return `${prop} : "${objeTosend[prop]}"`;
           } else {
             return `${prop} : ${objeTosend[prop]}`;
           }
         })}
        }`;
    }

    params = this.toolService.getParams(filtro, ordenamiento);

    let body = {
      /*query: `query{
            pacientes ${params}{
              id
              Cedula
              TipoDoc
              Apellidos1
              Apellidos2
              Nombres1
              Nombres2
              Apellidos
              Nombres
              FechaNacimiento
              TelCasa
              TelOficina
              Direccion
              Ciudad
              Municipio
              FechaIngreso
              Sexo
              RemitidoPor
              Ocupacion
              Mail
              Contacto
              EstadoCivil
              Nacionaliad
              EPS
              EMPRESA_ID
            }
          }`,*/
    };
    let headers = new HttpHeaders().set("Content-Type", "application/json");
    return this.http.get(this.serverUrl + '/Cliente/consultar');//, body, { headers: headers }
  }
}
