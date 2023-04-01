using System;
using Newtonsoft.Json;

namespace BlueLockProject
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            string configJson = File.ReadAllText("config.json");
            var config = JsonConvert.DeserializeObject<Config>(configJson);
            Bot bot = new Bot(config);
            await bot.RunAsync();
        }
    }
}