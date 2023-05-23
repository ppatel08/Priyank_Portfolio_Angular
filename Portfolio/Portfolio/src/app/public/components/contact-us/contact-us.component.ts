import { Component, Input } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { PortfolioService } from '../../services/portfolio.service';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrls: ['./contact-us.component.scss'],
})
export class ContactUsComponent {
  @Input() PersonalDetails: any = undefined;

  isSubmitted: boolean = false;
  contactForm: FormGroup;
  constructor(private portfolioService: PortfolioService) {
    this.contactForm = new FormGroup({
      name: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required, Validators.email]),
      message: new FormControl('', [
        Validators.required,
        Validators.maxLength(200),
      ]),
    });
  }

  Send() {
    this.isSubmitted = true;
    if (this.contactForm.invalid) {
      return;
    }
    this.portfolioService
      .sendMessage(this.contactForm.value)
      .subscribe((res) => {
        this.contactForm.reset();
        this.contactForm.markAsPristine();
        this.isSubmitted = false;
      });
  }
}
