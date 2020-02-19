import { Component, OnInit } from '@angular/core';
import { QuestionsService } from '../questions.service';
import { QuestionResponceModel } from '../Models/QuestionResponceModel';

@Component({
  selector: 'app-play',
  templateUrl: './play.component.html',
  styleUrls: ['./play.component.css']
})
export class PlayComponent implements OnInit {

  public questionsList: QuestionResponceModel[];
  index: number = 0
  answer: string;

  constructor(public questService: QuestionsService) { }

  ngOnInit() {
  }

  myAnswer(event) {
    if (event.target.id == this.questionsList[this.index].correct)
      this.answer = "Correct";
    else
      this.answer = "Wrong";
    console.log(event.target.id);
  }

  onButtonClick() {
    this.questService.getQuiz().subscribe((data) => {
      this.questionsList = data;
      console.log(this.questionsList)

    });
  }

  onButtonClickNext() {
    this.answer = "";
    this.index++;
    if (this.index == this.questionsList.length)
      this.index = 0;
  }
}
