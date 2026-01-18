using System;

namespace Laba9
{
    public class ErrorHandler
    {
        private Dictionary<string, string> errorsText;

        public ErrorHandler(Dictionary<string, string> errorsText)
        {
            this.errorsText = errorsText;
        }

        public ErrorHandler()
        {
            this.errorsText = new Dictionary<string, string>();
        }

        public Dictionary<string, string> ErrorsText
        {
            set { errorsText = value; }
        }

        public bool HandleInt(string userInput)
        {
            if(int.TryParse(userInput, out int value))
            {
                return true;
            }
            else
            {
                Console.WriteLine(errorsText["int"]);
                return false;
            }
        }

        public bool HandleNumberOfTask(string userInput, int quantityTask)
        {
            if(int.TryParse(userInput, out int value))
            {
                if (value > 0 && value <= quantityTask)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine(errorsText["numberOfTask"]);
                    return false;
                }
            }
            else 
            {
                Console.WriteLine(errorsText["int"]);
                return false;
            }
        }

        public bool HandleOverflow(string attribut, int currentValue, int addedValue, int minValue, int maxValue)
        {
            if(currentValue + addedValue <= maxValue && currentValue >= minValue)
            {
                return true;
            }
            else
            {
                Console.WriteLine(errorsText[attribut]);
                return false;
            }
        }

        public bool HandleOverflow(string attribut, int userValue, int minValue, int maxValue)
        {
            if (userValue <= maxValue && userValue >= minValue)
            {
                return true;
            }
            else
            {
                Console.WriteLine(errorsText[attribut]);
                return false;
            }
        }
    }
}