using System;

namespace Laba9
{
    internal class Pokemon
    {
        public static int count = 0;
        public static Dictionary<string, int> gameData = ConfigStorage.storageData.GameData;
        private int attack;
        private int defense;
        private int stamina;

        public Pokemon(int attack, int defense, int stamina)
        {
            this.attack = attack;
            this.defense = defense;
            this.stamina = stamina;
            count++;
        }

        public Pokemon()
        {
            attack = gameData["minAttack"];
            defense = gameData["minDefense"];
            stamina = gameData["minStamina"];
            count++;
        }

        public Pokemon(Random rnd)
        {
            attack = rnd.Next(gameData["minAttack"], gameData["maxAttack"]);
            defense = rnd.Next(gameData["minDefense"], gameData["maxDefense"]);
            stamina = rnd.Next(gameData["minStamina"], gameData["maxStamina"]);
            count++;
        }

        public int Attack 
        {
            get { return attack; }
            set { attack = value;}
        }
        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }

        public int GetAttack()
        {
            return attack;
        }

        public int GetDefense()
        {
            return defense;
        }

        public int GetStamina()
        {
            return stamina;
        }
        public void ImproveBy(int attack, int defense, int stamina)
        {
            this.attack += attack;
            this.defense += defense;
            this.stamina += stamina;
        }

        public void ImproveBy(Random rnd)
        {
            this.attack += rnd.Next(1, gameData["maxAttack"] - attack);
            this.defense += rnd.Next(1, gameData["maxDefense"] - defense);
            this.stamina += rnd.Next(1, gameData["maxStamina"] - stamina);
        }

        public void ImproveTo(int attack, int defense, int stamina)
        {
            this.attack = attack;
            this.defense = defense;
            this.stamina = stamina;
        }
        public void ImproveTo(Random rnd)
        {
            attack = rnd.Next(gameData["minAttack"], gameData["maxAttack"]);
            defense = rnd.Next(gameData["minDefense"], gameData["maxDefense"]);
            stamina = rnd.Next(gameData["minStamina"], gameData["maxStamina"]);
        }
        static public Pokemon ImproveBy(Pokemon p, int attack, int defense, int stamina)
        {
            p.attack += attack;
            p.defense += defense;
            p.stamina += stamina;
            return p;
        }

        static public Pokemon ImproveTo(Pokemon p, int attack, int defense, int stamina)
        {
            p.attack = attack;
            p.defense = defense;
            p.stamina = stamina;
            return p;
        }
    }
}
