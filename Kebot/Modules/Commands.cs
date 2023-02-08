using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;

namespace Kebot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            ReplyAsync("Pong");
        }
        [Command("courses")]
        public async Task Prices()
        {
            ReplyAsync("Доступные курсы: 3д-моделирование, Разработка игр в Unity, Курсы Python для начинающих, 2д-анимация, Графический дизайн");
        }
        [Command("about")]
        public async Task About()
        {
            ReplyAsync("IT Generator - это ваш способ получить дополнительное образование в области IT по доступной цене! Здесь вы можете пройти различные курсы у первоклассных преподавателей, научитесь применять ваши способности на практике и заведете новые знакомства!");
        }
        [Command("3d")]
        public async Task ThreeD()
        {
            ReplyAsync("Длительность курса: 3 недели. Стоимость курса : 7000 руб.");
        }
        [Command("2d")]
        public async Task TwoD()
        {
            ReplyAsync("Длительность курса: 2 недели. Стоимость курса : 5500 руб.");
        }
        [Command("python")]
        public async Task Python()
        {
            ReplyAsync("Длительность курса: 3 недели. Стоимость курса : 4000 руб.");
        }
        [Command("unity")]
        public async Task Unity()
        {
            ReplyAsync("Длительность курса: 2 недели. Стоимость курса : 4000 руб.");
        }
        [Command("design")]
        public async Task Design()
        {
            ReplyAsync("Длительность курса: 4 недели. Стоимость курса : 10000 руб.");
        }
    }
}
