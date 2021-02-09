using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace Tarea_3.Pages
{
    public class telapi
    {
        TelegramBotClient tClient;
        public void telegramBot()
        {
            tClient = new TelegramBotClient("1615934679:AAFKmwBDee9cW8rinseZKijvZS3n1hxrWJM");
            var me = tClient.GetMeAsync().Result;
            tClient.OnMessage += TClient_OnMessage;
            }

        private void TClient_OnMessage(object sender, global::Telegram.Bot.Args.MessageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
