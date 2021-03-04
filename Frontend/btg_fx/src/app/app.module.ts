import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { routing } from "./app-routing.module";
import { AppComponent } from "./app.component";

//modulos
import { CoreModule } from "./modules/core/core.module";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { MaterialModule } from "./modules/core/material.module";
import { LayoutModule } from "@angular/cdk/layout";
import { FlexLayoutModule } from "@angular/flex-layout";
import { SocialLoginModule } from "angularx-social-login";

import { MAT_DIALOG_DATA, MatDialogRef } from "@angular/material/dialog";
import { FormsModule } from "@angular/forms";

@NgModule({
  declarations: [AppComponent], //, RolesComponent
  imports: [
    BrowserModule,
    routing,
    CoreModule,
    BrowserAnimationsModule,
    MaterialModule,
    LayoutModule,
    FlexLayoutModule,
    SocialLoginModule,
    FormsModule
  ],
  providers: [
    { provide: MAT_DIALOG_DATA, useValue: {} },
    { provide: MatDialogRef, useValue: {} },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
