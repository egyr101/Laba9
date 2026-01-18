using System;
namespace Laba9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Dictionary<string, string> errorsData = ConfigStorage.storageData.ErrorsData;
            Dictionary<string, string[]> menuData = ConfigStorage.storageData.MenuData;
            Dictionary<string, string> invitationData = ConfigStorage.storageData.InvitationData;

            Menu mainMenu = new Menu(menuData["mainMenu"]);
            Menu createPokemonMenu = new Menu(menuData["createPokemonMenu"]);
            Menu inputAttributesMenu = new Menu(menuData["inputAttributesMenu"]);

            InputHandler inputHandler = new InputHandler(new ErrorHandler(errorsData), invitationData);

            Pokemon pikachu = new Pokemon();

            ShowData.Menu(createPokemonMenu);
            int numberOfTaskCreate = inputHandler.NumberOfTask(createPokemonMenu.QuantityOfTasks);

            switch (numberOfTaskCreate)
            {
                case 1:
                    break;
                case 2:
                    int attack = inputHandler.AttributValue("attack", Pokemon.gameData["minAttack"], Pokemon.gameData["maxAttack"]);
                    int defense = inputHandler.AttributValue("defense", Pokemon.gameData["minDefense"], Pokemon.gameData["maxDefense"]);
                    int stamina = inputHandler.AttributValue("stamina", Pokemon.gameData["minStamina"], Pokemon.gameData["maxStamina"]);

                    pikachu = new Pokemon(attack, defense, stamina);
                    break;
                case 3:
                    pikachu = new Pokemon(rnd);
                    break;
            }
            bool isExited = false;
            while (!isExited)
            {
                ShowData.Menu(mainMenu);
                int numberOfTask = inputHandler.NumberOfTask(mainMenu.QuantityOfTasks);

                switch (numberOfTask)
                {
                    case 1:
                        ShowData.Menu(createPokemonMenu);
                        numberOfTaskCreate = inputHandler.NumberOfTask(createPokemonMenu.QuantityOfTasks);

                        switch (numberOfTaskCreate)
                        {
                            case 1:
                                break;
                            case 2:
                                int attack = inputHandler.AttributValue("attack", Pokemon.gameData["minAttack"], Pokemon.gameData["maxAttack"]);
                                int defense = inputHandler.AttributValue("defense", Pokemon.gameData["minDefense"], Pokemon.gameData["maxDefense"]);
                                int stamina = inputHandler.AttributValue("stamina", Pokemon.gameData["minStamina"], Pokemon.gameData["maxStamina"]);

                                pikachu = new Pokemon(attack, defense, stamina);
                                break;
                            case 3:
                                pikachu = new Pokemon(rnd);
                                break;
                        }
                        break;
                    case 2:
                        ShowData.Pokemon(pikachu);
                        break;
                    case 3:
                        ShowData.Menu(inputAttributesMenu);

                        numberOfTaskCreate = inputHandler.NumberOfTask(inputAttributesMenu.QuantityOfTasks);

                        switch (numberOfTaskCreate)
                        {
                            case 1:
                                int newAttack = inputHandler.AttributValue("attack", Pokemon.gameData["minAttack"], Pokemon.gameData["maxAttack"]);
                                int newDefense = inputHandler.AttributValue("defense", Pokemon.gameData["minDefense"], Pokemon.gameData["maxDefense"]);
                                int newStamina = inputHandler.AttributValue("stamina", Pokemon.gameData["minStamina"], Pokemon.gameData["maxStamina"]);

                                pikachu.ImproveTo(newAttack, newDefense, newStamina);
                                break;
                            case 2:
                                pikachu.ImproveTo(rnd);
                                break;
                        }
                        
                        break;
                    case 4:
                        ShowData.Menu(inputAttributesMenu);

                        numberOfTaskCreate = inputHandler.NumberOfTask(inputAttributesMenu.QuantityOfTasks);

                        switch (numberOfTaskCreate)
                        {
                            case 1:
                                int bonusAttack = inputHandler.AttributValue("attack", pikachu.Attack, Pokemon.gameData["minAttack"], Pokemon.gameData["maxAttack"]);
                                int bonusDefense = inputHandler.AttributValue("defense", pikachu.Defense, Pokemon.gameData["minDefense"], Pokemon.gameData["maxDefense"]);
                                int bonusStamina = inputHandler.AttributValue("stamina", pikachu.Stamina, Pokemon.gameData["minStamina"], Pokemon.gameData["maxStamina"]);

                                pikachu.ImproveBy(bonusAttack, bonusDefense, bonusStamina);
                                break;
                            case 2:
                                pikachu.ImproveBy(rnd);
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Количество созданных покемонов: " + Pokemon.count);
                        break;
                    case 6:
                        isExited = true;
                        break;
                }
            
            }
        }
    }
}
