import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PublicRoutingModule } from './public-routing.module';
import { PublicComponent } from './public/public.component';
import { SideBarComponent } from './shared/components/side-bar/side-bar.component';
import { PortfolioComponent } from './components/portfolio/portfolio.component';
import { IntroductionComponent } from './components/introduction/introduction.component';
import { AboutMeComponent } from './components/about-me/about-me.component';
import { WhatIDoComponent } from './components/what-ido/what-ido.component';
import { MyResumeComponent } from './components/my-resume/my-resume.component';
import { ContactUsComponent } from './components/contact-us/contact-us.component';
import { TestimonialsComponent } from './components/testimonials/testimonials.component';
import { NgxTypedJsModule } from 'ngx-typed-js';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SearchPipePipe } from './pipes/search-pipe.pipe';


@NgModule({
  declarations: [
    PublicComponent,
    SideBarComponent,
    PortfolioComponent,
    IntroductionComponent,
    AboutMeComponent,
    WhatIDoComponent,
    MyResumeComponent,
    TestimonialsComponent,
    ContactUsComponent,
    SearchPipePipe
    
  ],
  imports: [
    CommonModule,
    PublicRoutingModule,
    NgxTypedJsModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class PublicModule { }
