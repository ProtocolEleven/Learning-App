import { Component } from '@angular/core';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { CommonModule } from '@angular/common';
import { PlansPricingComponent } from '../plans-pricing/plans-pricing.component';



@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CarouselModule, CommonModule, PlansPricingComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  myInterval = 1500;
  activeSlideIndex = 0;
  slides: { image: string; text?: string }[] = [
    { image: 'assets/picture1.jpg' },
    { image: 'assets/picture2.jpg' },
    { image: 'assets/picture3.jpg' }
  ];
}
