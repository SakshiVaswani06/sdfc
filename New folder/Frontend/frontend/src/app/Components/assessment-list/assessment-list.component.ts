import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Assessment, ModelService } from 'src/app/Service/model.service';


@Component({
  selector: 'app-assessment-list',
  templateUrl: './assessment-list.component.html',
  styleUrls: ['./assessment-list.component.css']
})
export class AssessmentListComponent {
  assessments: Assessment[] = [];

  constructor(private route: Router, private services: ModelService) { }

  ngOnInit(): void {
    this.getData();
  }

  getData(): void {
    this.services.getAllAssessments().subscribe(
      data => {
        this.assessments = data;
      },
      error => {
        console.error('Error fetching data:', error);
      }
    );
  }
  adddata(){
    this.route.navigate(["/AddAssessment"]);
  }
}

