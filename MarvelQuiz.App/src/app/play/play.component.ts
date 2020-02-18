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

  constructor(public questService: QuestionsService) { }

  ngOnInit() {
  }

  onButtonClick() {
    this.questService.getQuiz().subscribe((data) => {
      this.questionsList = data;
      console.log(this.questionsList)

    });
  }

  onButtonClickNext(){
    this.index++;
    if(this.index == this.questionsList.length)
    this.index = 0;
  }
}
