import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { QuestionResponceModel } from './Models/QuestionResponceModel';

@Injectable({
  providedIn: 'root'
})
export class QuestionsService {

  constructor(private client: HttpClient) { }

  getQuiz(){
    return this.client.get<QuestionResponceModel[]>("https://localhost:44351/api/questions");
  }
}
