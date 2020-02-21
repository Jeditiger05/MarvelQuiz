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
        private List<Question> quiz = new List<Question>() 
        {
            (new Question("What Color is the Incredible Hulk?", "Green", "Red", "Blue", "Yellow", "ans1", "hulk.JPG")),
            (new Question("What does Captain America use to battle Villians?", "Hammer", "Sword", "Shield", "Blaster", "ans3", "captainA.JPG")),
            (new Question("Who does Black Widow work for?", "Hydra", "Tony Stark", "F.B.I", "S.H.I.E.L.D", "ans4", "widow.JPG")),
            (new Question("Where does the Black Panther Live?", "Jungle", "Wakanda", "S.H.I.E.L.D", "America", "ans2", "panther.JPG"))
        };

        public List<Question> GetQuestions()
        {
            return this.quiz;
        }

        [HttpGet("image")]
        public IActionResult Get(string image)
        {
            return PhysicalFile(@"C:\Users\John\Projects\MarvelQuiz\MarvelQuiz.Api\MarvelQuiz.Api\Images\" + image, "image /jpeg");

        }
    }
}