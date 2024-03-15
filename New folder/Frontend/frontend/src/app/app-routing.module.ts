import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AssessmentListComponent } from './Components/assessment-list/assessment-list.component';
import { AddAssessmentComponent } from './Components/add-assessment/add-assessment.component';

const routes: Routes = [
  { path: "", component: AssessmentListComponent },
  { path: "AddAssessment", component: AddAssessmentComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
