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
            switch (message.Content)
            {
                case var s when s.Contains("blue lock"):
                    await message.Channel.SendMessageAsync("Torne-se aquele que escolhe, e não aquele que espera pra ser escolhido.");
                    break;
                case var s when s.Contains("bom dia"):
                    await message.Channel.SendMessageAsync("Bom dia Diamante Bruto Cheio de Talento. Pronto para transformar o 0 em 1 hoje?");
                    break;
                case var s when s.Contains("boa tarde"):
                    await message.Channel.SendMessageAsync("Boa tarde Egoísta. Encontrou a fórmula para o seu gol?");
                    break;
                case var s when s.Contains("boa noite"):
                    await message.Channel.SendMessageAsync("Boa noite Monstro. Descanse e esteja pronto para devorar amanhã!");
                    break;
                default:
                    break;
            }

        }
    }
}
