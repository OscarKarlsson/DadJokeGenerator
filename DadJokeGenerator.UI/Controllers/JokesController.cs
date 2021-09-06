using DadJokeGenerator.Application;
using DadJokeGenerator.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadJokeGenerator.UI.Controllers
{
    public class JokesController : Controller
    {
        private DadJokeManager _dadJokeManager;

        public JokesController(DadJokeManager dadJokeManager)
        {
            _dadJokeManager = dadJokeManager;
        }
        public async Task<IActionResult> Index()
        {
            JokeModel joke = await _dadJokeManager.GetDadJoke();

            return View(joke);
        }

        public IActionResult QuestionMarkMod(string joke)
        {
            ViewBag.joke = _dadJokeManager.ModifyJokeQuestionMark(joke);

            return View();
        }

        public IActionResult ToUpperMod(string joke)
        {
            ViewBag.joke = _dadJokeManager.ModifyJokeToUpper(joke);

            return View();
        }

        public IActionResult viewHistory()
        {
            List<string> allJokes = new List<string>();
            allJokes = _dadJokeManager.GetAllCache();
            return View(allJokes);
        }
    }
}
