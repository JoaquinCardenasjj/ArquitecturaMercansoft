import { Component } from "@angular/core";
import { BreakpointObserver, Breakpoints } from "@angular/cdk/layout";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import { Router } from "@angular/router";
import { UserSession } from "../interfaces/usersession.interface";

@Component({
  selector: "my-nav",
  templateUrl: "./my-nav.component.html",
  styleUrls: ["./my-nav.component.scss"],
})
export class MyNavComponent {
  public session: UserSession;
  public serverURlImagesUsuarios: String;
  public actualUrlFoto: string;
  public etiquetas: any = {};
  public MostrarSolicitudesCapitan: boolean = false;
  public MostrarRouter: boolean = true;
  public urlLogo: string;
  public usuario;
  public array;
  public navSizeCss = { "margin-left": "255px;" };
  userKey: string = "USUARIO";

  isHandset$: Observable<boolean> = this.breakpointObserver
    .observe(Breakpoints.Handset)
    .pipe(map((result) => result.matches));

  constructor(
    private breakpointObserver: BreakpointObserver,
    private router: Router
  ) {
    this.urlLogo = "";//"../../../assets/small.png"
    this.usuario = JSON.parse(localStorage.getItem(this.userKey));
  }
  ngOnInit() {
    /*this.getUserFromLocalStorage();
    this.array = this.usuario.PERMISOS.map((item) => {
      if (item.applicationId) {
        item.routerLink = item.url_menu + item.applicationId;
      } else {
        item.routerLink = item.url_menu;
      }
      return item;
    });*/
    this.array = [
      {
        "nombre": "Perfil",
        "descripcion": "Perfil",
        "icon": "account_circle",
        "url_menu": "/dashboard/perfil",
        "applicationId": null
      },
      {
        "nombre": "Usuarios",
        "descripcion": "1",
        "icon": "accessibility",
        "url_menu": "/dashboard/generic-list",
        "applicationId": 27
      },
      {
        "nombre": "Clientes",
        "descripcion": "Clientes",
        "icon": "account_box",
        "url_menu": "/dashboard/cliente",
        "applicationId": null
      },
      {
        "nombre": "Salir",
        "descripcion": "Salir",
        "icon": "exit_to_app",
        "url_menu": "/salida",
        "applicationId": null
      }
    ]
  }

  logout(ruta) {
    localStorage.removeItem(this.userKey);
    this.router.navigate([ruta]);
  }

  mostrarSolicitudes() {
    this.MostrarRouter = false;
  }

  mostrarRouter(item) {
    this.MostrarRouter = true;
    if (item.applicationId) {
      this.router.routeReuseStrategy.shouldReuseRoute = () => false;
      this.router.navigate([item.url_menu], {
        queryParams: { applicationId: item.applicationId },
      });
    } else {
      if (item.url_menu == "/salida") {
        this.logout(item.url_menu);
      } else {
        this.router.navigate([item.url_menu]);
      }
    }
  }

  getUserFromLocalStorage() {
    this.usuario = JSON.parse(localStorage.getItem(this.userKey));
  }

  afterClick() {
    this.navSizeCss =
      this.navSizeCss["margin-left"] == "0px;"
        ? { "margin-left": "255px;" }
        : { "margin-left": "0px;" };
  }
}
