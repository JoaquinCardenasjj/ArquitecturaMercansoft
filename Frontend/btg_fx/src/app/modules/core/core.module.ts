import { RolesComponent } from "./../roles/roles.component";
import { AvatarComponent } from "./components/avatar/avatar.component";
import { FullCalendarModule } from "@fullcalendar/angular";
import dayGridPlugin from "@fullcalendar/daygrid"; // a plugin
import interactionPlugin from "@fullcalendar/interaction";
import { UsersComponent } from "./../users/users.component";
import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FooterComponent } from "./footer/footer.component";
import { HttpClientModule } from "@angular/common/http";
import { ServicesService } from "./services/services.service";
import { PrincipalComponent } from "../principal/principal.component";
import { ProfileComponent } from "../profile/profile.component";
import { routing } from "./core.routing";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { MaterialModule } from "../core/material.module";
import { MyNavComponent } from "./my-nav/my-nav.component";
import { ModalComponent } from "./modal/modal.component";
import { LoadingComponent } from "./loading/loading.component";
import { DashboardComponent } from "./dashboard/dashboard.component";
import { MatGridListModule } from "@angular/material/grid-list";
import { MatCardModule } from "@angular/material/card";
import { MatMenuModule } from "@angular/material/menu";
import { MatIconModule } from "@angular/material/icon";
import { MatButtonModule } from "@angular/material/button";
import { MatSlideToggleModule } from "@angular/material/slide-toggle";
import { SelectComponent } from "./components/select/select.component";

import { FooterTursitaComponent } from "../core/components/footer-tursita/footer-tursita.component";
import { LoginAdminComponent } from "../login-admin/login-admin.component";



import {
  BuscadormodalComponent,
  DialogOverviewExample,
} from "./components/buscadormodal/buscadormodal.component";
import {
  BuscadormodaliconComponent,
  DialogOverviewExampleIcon,
} from "./components/buscadormodalicon/buscadormodalicon.component";
import { MascarasComponent } from "../mascaras/mascaras.component";

import { TipoCampoComponent } from "../tipo-campo/tipo-campo.component";
import { GenericComponent } from "../generic/generic.component";
import { InputComponent } from "./components/input/input.component";
import { ToogleComponent } from "./components/toogle/toogle.component";
import { SchedulerComponent } from "./components/scheduler/scheduler.component";

import { FlatpickrModule } from "angularx-flatpickr";
import { CalendarModule, DateAdapter } from "angular-calendar";
import { adapterFactory } from "angular-calendar/date-adapters/date-fns";
import timeGridPlugin from "@fullcalendar/timegrid";
import listPlugin from "@fullcalendar/list";
import { MultilistComponent } from "./components/multilist/multilist.component";
import { MatListModule } from "@angular/material/list";
import { AvatarDragDirective } from "./components/avatar/avatarDragDropDirective";
import { DatepickerComponent } from "./components/datepicker/datepicker.component";
import { MatDatepickerModule } from "@angular/material/datepicker";
import { MatNativeDateModule } from "@angular/material/core";
import { MatInputModule } from "@angular/material/input";
import { DatetimeComponent } from "./components/datetime/datetime.component";
import { OwlDateTimeModule, OwlNativeDateTimeModule } from "ng-pick-datetime";
import { SliderComponent } from "./components/slider/slider.component";
import { MatSliderModule } from "@angular/material/slider";
import { MultilistObservacionesComponent } from "./components/multilist-observaciones/multilist-observaciones.component";
import { ClienteComponent } from '../cliente/cliente.component';

FullCalendarModule.registerPlugins([
  dayGridPlugin,
  timeGridPlugin,
  listPlugin,
  interactionPlugin,
]);

@NgModule({
  declarations: [
    //componentes
    FooterComponent,
    MyNavComponent,
    ModalComponent,
    LoadingComponent,
    DashboardComponent,
    SelectComponent,
    PrincipalComponent,
    ProfileComponent,
    FooterTursitaComponent,
    LoginAdminComponent,
    UsersComponent,


    MascarasComponent,

    BuscadormodalComponent,
    DialogOverviewExample,
    BuscadormodaliconComponent,
    DialogOverviewExampleIcon,
    TipoCampoComponent,
    GenericComponent,
    InputComponent,

    MultilistComponent,
    ToogleComponent,
    AvatarComponent,
    AvatarDragDirective,
    RolesComponent,
    SchedulerComponent,
    DatepickerComponent,
    DatetimeComponent,
    SliderComponent,

    MultilistObservacionesComponent,

    ClienteComponent,
  ],

  imports: [
    BrowserModule,
    HttpClientModule,
    routing,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    MatGridListModule,
    MatCardModule,
    MatMenuModule,
    MatIconModule,
    MatButtonModule,
    MatSlideToggleModule,
    FullCalendarModule,
    MatListModule,
    FlatpickrModule.forRoot(),
    CalendarModule.forRoot({
      provide: DateAdapter,
      useFactory: adapterFactory,
    }),
    MatNativeDateModule,
    MatDatepickerModule,
    MatInputModule,
    OwlDateTimeModule,
    OwlNativeDateTimeModule,
    MatSliderModule,
  ],

  exports: [
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    MyNavComponent,
  ],

  providers: [ServicesService],
  bootstrap: [DatetimeComponent], //componente
  entryComponents: [ModalComponent, LoadingComponent, DialogOverviewExample],
})
export class CoreModule {}
