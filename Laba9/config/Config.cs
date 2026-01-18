using System;
using System.Text.Json;
using System.Text;

namespace Laba9
{
    public class Config
    {
        private Dictionary<string, string> errorsData;
        private Dictionary<string, int> gameData;
        private Dictionary<string, string[]> menuData;
        private Dictionary<string, string> invitationData;
        public Config(string pathErrorsData, string pathGameData, string pathMenuData)
        {
            JsonSerializerOptions options = new JsonSerializerOptions{
                AllowTrailingCommas = true,
            };

            errorsData = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(pathErrorsData), options);
            gameData = JsonSerializer.Deserialize<Dictionary<string, int>>(File.ReadAllText(pathGameData), options);
            menuData = JsonSerializer.Deserialize<Dictionary<string, string[]>>(File.ReadAllText(pathMenuData), options);
            invitationData = new Dictionary<string, string>()
            {
                { "numberOfTask" , "Введите номер задачи: "},
                { "attack", $"Введите значение атаки, после окончания операции оно не должно выйти за диапазон (допустимое значение от {gameData["minAttack"]} до {gameData["maxAttack"]}): " },
                { "defense", $"Введите значение защиты, после окончания операции оно не должно выйти за диапазон (допустимое значение от {gameData["minDefense"]} до {gameData["maxDefense"]}): " },
                { "stamina", $"Введите значение стамины, после окончания операции оно не должно выйти за диапазон (допустимое значение от {gameData["minStamina"]} до {gameData["maxStamina"]}): "},
            };
        }

        public Dictionary<string, string> ErrorsData
        {
            get { return errorsData;}
        }
        public Dictionary<string, int> GameData
        {
            get { return gameData; }
        }
        public Dictionary<string, string[]> MenuData
        {
            get { return menuData; }
        }
        public Dictionary<string, string> InvitationData
        {
            get { return invitationData; }
        }
    }
}
