import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReaderComponent } from './reader/reader.component';
import { WriterComponent } from './writer/writer.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { OpenTelemetryInterceptorModule, OtelColExporterModule, CompositePropagatorModule, OtelWebTracerModule } from '@jufab/opentelemetry-angular-interceptor';
import { environment } from '../environments/environment';

@NgModule({
  declarations: [
    AppComponent,
    ReaderComponent,
    WriterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    // Interceptor
    OpenTelemetryInterceptorModule.forRoot(environment.opentelemetryConfig),
    OtelColExporterModule,
    CompositePropagatorModule,
    // OtelWebTracerModule to configure instrumentation component.
    OtelWebTracerModule.forRoot(environment.opentelemetryConfig),
    FormsModule,
    ReactiveFormsModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
