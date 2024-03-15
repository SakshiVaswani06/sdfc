import { Component } from '@angular/core';
import { AssQuesDto, ModelService, QuestionDto } from 'src/app/Service/model.service';

@Component({
  selector: 'app-add-assessment',
  templateUrl: './add-assessment.component.html',
  styleUrls: ['./add-assessment.component.css']
})
export class AddAssessmentComponent {

  assQuesDto: AssQuesDto = { assessmentName: '', quedto: [] };
  newQuestion: QuestionDto = { question: '', questionType: '' };
  showQuestionModal = false;

  constructor(private services: ModelService) { }

  addAssQues(): void {
    debugger
    this.services.addAssQues(this.assQuesDto).subscribe(
      response => {
        console.log(response); 
      },
      error => {
        console.error(error); 
      }
    );
  }

  openQuestionModal(): void {
    this.showQuestionModal = true;
  }

  closeQuestionModal(): void {
    this.showQuestionModal = false;
  }

  addQuestion(): void {
    debugger
    this.assQuesDto.quedto.push(this.newQuestion);
    this.newQuestion = { question: '', questionType: '' };
  }
}