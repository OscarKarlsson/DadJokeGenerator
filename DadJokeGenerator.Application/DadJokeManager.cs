using DadJokeGenerator.DTO;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Threading.Tasks;

namespace DadJokeGenerator.Application
{
    public class DadJokeManager
    {
       
        ObjectCache cache = MemoryCache.Default;
        public DadJokeManager()
        {
            
        }
        public async Task<JokeModel> GetDadJoke()
        {
            JokeModel joke = await DadJokeGenerator.API.JokeProcessor.GetJokeFromApi();
            SetCache(joke);
            return joke;
        }
        public void SetCache(JokeModel joke)
        {
                var cachedJoke = new CacheItem(joke.Id, joke.Joke);
            
                CacheItemPolicy policy = new CacheItemPolicy(); // Skapa cache policy

                cache.Set(cachedJoke, policy); // Spara joke i cachen

            
        }
        public List<string> GetAllCache()
        {
            List<string> AllJokes = new List<string>();
            foreach (var item in MemoryCache.Default)
            {
               AllJokes.Add(item.Value.ToString());
            }
            return AllJokes;
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
