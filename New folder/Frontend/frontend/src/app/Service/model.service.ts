import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ModelService {

  private url = "https://localhost:44333/api/Values";

  constructor(private http: HttpClient) { }

  getAllAssessments(): Observable<Assessment[]> {
    return this.http.get<Assessment[]>(this.url);
  }

  addAssQues(assQuesDto: AssQuesDto): Observable<AssQuesDto> {
    return this.http.post<AssQuesDto>(this.url, assQuesDto);
  }
}

export interface Assessment {
  id: number;
  assessmentName: string;
}
export interface AssQuesDto {
  assessmentName: string;
  quedto: QuestionDto[];
}

export interface QuestionDto {
  question: string,
  questionType: string
}
