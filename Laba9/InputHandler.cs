using System;
using System.Xml.Linq;

namespace Laba9
{
    public class InputHandler
    {
        private ErrorHandler errorHandler;
        private Dictionary<string, string> messages;

        public InputHandler(ErrorHandler errorHandler, Dictionary<string, string> messages)
        {
            this.errorHandler = errorHandler;
            this.messages = messages;
        }

        private string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public int AttributValue(string attribut, int min, int max)
        {
            int userInt = 0;
            bool isCorrectInput = false;

            while (!isCorrectInput)
            {
                string userInput = GetUserInput(messages[attribut]);
                isCorrectInput = errorHandler.HandleInt(userInput);

                if (isCorrectInput)
                {
                    userInt = int.Parse(userInput);
                    isCorrectInput = errorHandler.HandleOverflow(attribut, userInt, min, max);
                }
            }

            return userInt;
        }

        public int AttributValue(string attribut, int min, int max, int currentValue)
        {
            int userInt = 0;
            bool isCorrectInput = false;

            while (!isCorrectInput)
            {
                string userInput = GetUserInput(messages[attribut]);
                isCorrectInput = errorHandler.HandleInt(userInput);

                if (isCorrectInput)
                {
                    userInt = int.Parse(userInput);
                    isCorrectInput = errorHandler.HandleOverflow(attribut, currentValue, userInt, min, max);
                }
            }

            return userInt;
        }
        public int NumberOfTask(int quantityTask)
        {
            int userNumberOfTask = 0;
            bool isCorrectInput = false;

            while (!isCorrectInput)
            {
                string userInput = GetUserInput(messages["numberOfTask"]);
                isCorrectInput = errorHandler.HandleNumberOfTask(userInput, quantityTask);

                if (isCorrectInput)
                {
                    userNumberOfTask= int.Parse(userInput);
                    break;
                }
            }
            return userNumberOfTask;
        }
    }
}
