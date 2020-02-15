using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarvelQuiz.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarvelQuiz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        public List<Question> GetQuestions()
        {
            List<Question> quiz = new List<Question>();
            quiz.Add(new Question("What Color is the Incredible Hulk?", "Green", "Red", "Blue", "Yellow", "#answer1"));
            quiz.Add(new Question("What does Captain America use to battle Villians?", "Hammer", "Sword", "Shield", "Blaster", "#answer3"));
            quiz.Add(new Question("Who does Black Widow work for?", "Hydra", "Tony Stark", "F.B.I", "S.H.I.E.L.D", "#answer4"));

            return quiz;
        }
    }
}