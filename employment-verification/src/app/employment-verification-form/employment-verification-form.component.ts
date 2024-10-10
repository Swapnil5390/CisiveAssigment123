import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface EmployeeVerification {
  employeeId: number;
  companyName: string;
  verificationCode: string;
}

@Component({
  selector: 'app-employment-verification-form',
  templateUrl: './employment-verification-form.component.html',
  styleUrls: ['./employment-verification-form.component.css']
})
export class EmploymentVerificationFormComponent {
  employeeId: number | null = null;
  companyName: string = '';
  verificationCode: string = '';
  result: string = '';

  constructor(private http: HttpClient) {}

  submitForm() {
    const payload: EmployeeVerification = {
      employeeId: this.employeeId!,
      companyName: this.companyName,
      verificationCode: this.verificationCode
    };

    this.http.post<{ verified: boolean }>('http://localhost:5000/api/Verification/verify-employment', payload)
     .subscribe(response => {
        this.result = response.verified ? 'Verified' : 'Not Verified';
      });
  }
}
