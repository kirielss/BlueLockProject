using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace BlueLockProject
{
    public class Bot
    {

        private DiscordSocketClient _client;
        private Config _config;

        public Bot(Config config)
        {
            _config = config;
        }

        public async Task RunAsync()
        {
            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, _config.Token);
            await _client.StartAsync();

            // here to add bot event handlers
            _client.MessageReceived += OnMessageReceived;

            // keep the bot running
            await Task.Delay(-1);
        }

        private async Task OnMessageReceived(SocketMessage message)
        {
            // bot message handling logic
            if (message.Content.Contains("blue lock"))
            {
                await Console.Out.WriteLineAsync("a mensagem chegou!!!");
                await message.Channel.SendMessageAsync("Torne-se aquele que escolhe, e não aquele que espera pra ser escolhido.");
            }
        }
    }
}
