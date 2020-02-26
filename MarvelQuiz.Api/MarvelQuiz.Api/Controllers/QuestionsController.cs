using System;
using System.Collections.Generic;
using System.IO;
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
        private List<Question> questionsList = new List<Question>()
        {
            (new Question("What Color is the Incredible Hulk?", "Green", "Red", "Blue", "Yellow", "ans1", "hulk.JPG")),
            (new Question("What does Captain America use to battle Villians?", "Hammer", "Sword", "Shield", "Blaster", "ans3", "captainA.JPG")),
            (new Question("Who does Black Widow work for?", "Hydra", "Tony Stark", "F.B.I", "S.H.I.E.L.D", "ans4", "widow.JPG")),
            (new Question("Where does the Black Panther Live?", "Jungle", "Wakanda", "S.H.I.E.L.D", "America", "ans2", "panther.JPG")),
            (new Question("What can Spider-Man do?", "Read Minds", "Swim Fast", "Turn into a Spider", "Climb Walls", "ans4", "spiderman.JPG")),
            (new Question("Star-Lord is a member of what Group?", "Justice League", "Suicide Squad", "Fantastic Four", "Gardians of the Galaxy", "ans4", "starlord.JPG"))
        };

        public List<Question> GetQuestions()
        {
            List<Question> quiz = new List<Question>();
            Random num = new Random();
            Question randomQ;

            for (int i = 0; i < 3; i++)
            {
                do
                {
                    randomQ = questionsList[(num.Next(0, questionsList.Count))];
                } while (quiz.IndexOf(randomQ) > -1);

                quiz.Add(randomQ);
            }

            return quiz;
        }

        [HttpGet("image")]
        public IActionResult Get(string image)
        {
            string rootPath = Directory.GetCurrentDirectory() + "\\Images\\";
            return PhysicalFile(rootPath + image, "image /jpeg");
        }
    }
}