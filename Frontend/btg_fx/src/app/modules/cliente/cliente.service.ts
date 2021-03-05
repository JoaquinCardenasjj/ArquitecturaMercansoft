import { Injectable } from "@angular/core";
import * as Globals from "../../modules/core/globals";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Cliente } from "../core/interfaces/cliente.interface";
import { HttpService } from "../core/services/HttpService";
import { ToolsService } from "../core/services/tools.service";

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  public CLIENTE: any;
  serverUrl: string;
  constructor(
    private http: HttpClient,
    private httpService: HttpService,
    private toolService: ToolsService
  ) {
    this.serverUrl = Globals.SERVER;
  }

  createCliente(objeTosend: Cliente): Observable<any> {
    let headers = new HttpHeaders().set("Content-Type", "application/json");
    return this.http.post(this.serverUrl + '/Cliente/registrar', objeTosend, { headers: headers });
  }

  updateCliente(objeTosend: Cliente): Observable<any> {
    let headers = new HttpHeaders().set("Content-Type", "application/json");
    return this.http.put(this.serverUrl + '/Cliente/editar', objeTosend, { headers: headers });
  }

  deleteCliente(objeTosend: Cliente) {
    let idClient = objeTosend.idCliente
    console.log("-||--**||***QUE TRAJO idClient", idClient)
      
    let headers = new HttpHeaders().set("Content-Type", "application/json");
    return this.http.post(this.serverUrl + '/Cliente/eliminar', idClient, { headers: headers });
  }

}
