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
        List<Question> quiz = new List<Question>();
        public List<Question> GetQuestions()
        {
            quiz.Add(new Question("What Color is the Incredible Hulk?", "Green", "Red", "Blue", "Yellow", "ans1"));
            quiz.Add(new Question("What does Captain America use to battle Villians?", "Hammer", "Sword", "Shield", "Blaster", "ans3"));
            quiz.Add(new Question("Who does Black Widow work for?", "Hydra", "Tony Stark", "F.B.I", "S.H.I.E.L.D", "ans4"));

            return quiz;
        }

        [HttpGet("image")]
        public IActionResult Get(int image)
        {
            switch (image)
            {
                case 0: return PhysicalFile(@"C:\Users\John\Projects\MarvelQuiz\MarvelQuiz.Api\MarvelQuiz.Api\Images\hulk.JPG", "image/jpeg");
                case 1: return PhysicalFile(@"C:\Users\John\Projects\MarvelQuiz\MarvelQuiz.Api\MarvelQuiz.Api\Images\captainA.JPG", "image/jpeg");
                case 2: return PhysicalFile(@"C:\Users\John\Projects\MarvelQuiz\MarvelQuiz.Api\MarvelQuiz.Api\Images\widow.JPG", "image/jpeg");
                default: return null;
            }
        }
    }
}