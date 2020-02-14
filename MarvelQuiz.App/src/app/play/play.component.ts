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
  showQuiz: boolean = false;
  ind: number = 0

  constructor(public questService: QuestionsService) { }

  ngOnInit() {
    $('#answers').hide();
  }

  onButtonClick() {
    this.questService.getQuiz().subscribe((data) => {
      this.questionsList = data;
      console.log(this.questionsList)

    });
  }

  onButtonClickNext(){
    $('#answers').show();
    $('#question').html(this.questionsList[this.ind].quest);
    $('#ans1').html(this.questionsList[this.ind].ans1);
    $('#ans2').html(this.questionsList[this.ind].ans2);
    $('#ans3').html(this.questionsList[this.ind].ans3);
    $('#ans4').html(this.questionsList[this.ind].ans4);
    this.ind++;
    if(this.ind == this.questionsList.length)
    this.ind = 0;
    this.showQuiz = true;
  }
}
