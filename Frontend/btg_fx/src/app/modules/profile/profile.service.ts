import { Injectable } from "@angular/core";
import * as Globals from "../../modules/core/globals";
import { HttpClient, HttpParams, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
@Injectable({
  providedIn: "root",
})
export class ProfileService {
  serverUrl: string;
  constructor(private http: HttpClient) {
    this.serverUrl = Globals.SERVER;
  }

  getMyProfile(objeTosend): Observable<any> {
    let params = "";
    const { filter, properties } = objeTosend;
    params = "1";
    let body = {
      usuarioId:  params
    };
    let headers = new HttpHeaders().set("Content-Type", "application/json");
    return this.http.post(this.serverUrl, body, { headers: headers });
  }
}
