using DadJokeGenerator.DTO;
using System;
using System.Threading.Tasks;

namespace DadJokeGenerator.Application
{
    public class DadJokeManager
    {
        public async Task<JokeModel> GetDadJoke()
        {
            JokeModel joke = await DadJokeGenerator.API.JokeProcessor.GetJokeFromApi();

            return joke;
        }

        public string ModifyJokeToUpper(string joke)
        {
            joke = joke.ToUpper();

            return joke;
        }

        public string ModifyJokeQuestionMark(string joke)
        {
            joke = joke + "???";

            return joke;
        }
    }
}
