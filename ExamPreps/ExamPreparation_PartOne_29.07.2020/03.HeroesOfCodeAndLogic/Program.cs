using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogic
{
    // Правим си един клас Hero,  в който ще си държим стойностите HP i MP. Колкото и много данни да имаме, просто си ги изброяваме в класа.
    class Hero
    {
        public int HP { get; set; }
        public int MP { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            // Ще си направим един речник от стринг и класа Hero. Key ни е стринга (името на героя), а Value ни е класа Hero (съвкупност от HP i MP)
            Dictionary<string, KeyValuePair<int, int>> heroes = new Dictionary<string, KeyValuePair<int, int>>;

            // Сега трябва да прочетем всички герои
            for (int i = 0; i < n; i++)
            {
                // Четем си входа и директно го сплитваме
                string[] input = Console.ReadLine().Split();
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);

                // Правим си един клас
                Hero hero = new Hero() { HP = hp, MP = mp };

                // Сега в дикшинърито (heroes) добавяме името на героя и данните за HP и MP
                heroes.Add(heroName, new KeyValuePair<int, int>(hp, mp));
            }


            // Едва сега започваме с командите
            string command = Console.ReadLine();
           
            while (command != "End")
            {
                // Прочитаме си първата команда и я сплитваме
                // CastSpell – {hero name} – {MP needed} – {spell name}
                if (command.Contains("CastSpell"))
                {
                    string[] splitted = command.Split(" - ");
                    string name = splitted[1];
                    int mpNeeded = int.Parse(splitted[2]);
                    string spellName = splitted[3];

                    // Намаляваме магията с тази, от която има нужда
                    
                    if (heroes[name].Value - mpNeeded >= 0)
                    {
                        heroes[name].Value -= mpNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name].MP} MP!");
                    }

                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }

                // Прочитаме втората команда и я сплитваме
                // TakeDamage – {hero name} – {damage} – {attacker}
                if (command.Contains("TakeDamage"))
                {
                    string[] splitted = command.Split(" - ");
                    string name = splitted[1];
                    int damage = int.Parse(splitted[2]);
                    string attacker = splitted[3];

                    // Намаляваме магията с тази, от която има нужда
                    heroes[name].Key -= damage;
                    if (heroes[name].Key > 0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name].HP} HP left!");
                    }

                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                    }
                }

                // Прочитаме третата команда и я сплитваме
                // Recharge – {hero name} – {amount}
                if (command.Contains("Recharge"))
                {
                    string[] splitted = command.Split(" - ");
                    string name = splitted[1];
                    int recharge = int.Parse(splitted[2]);

                    if (heroes[name].MP + recharge > 200)
                    {
                        recharge = 200 - heroes[name].MP;
                    }
                    heroes[name].MP += recharge;
                    Console.WriteLine($"{name} recharged for {recharge} MP!");
                }

                // Прочитаме четвъртата команда и я сплитваме
                // Heal – {hero name} – {amount}
                if (command.Contains("Heal"))
                {
                    string[] splitted = command.Split(" - ");
                    string name = splitted[1];
                    int recharge = int.Parse(splitted[2]);

                    if (heroes[name].HP + recharge > 100)
                    {
                        recharge = 100 - heroes[name].HP;
                    }
                    heroes[name].HP += recharge;
                    Console.WriteLine($"{name} healed for {recharge} HP!");
                }

                command = Console.ReadLine();
            }

            // Последно отпечатваме списъка с живите герои, подредени в намаляващ порядък по НР и после в нарастващ порядък по име
            var sortedHeroes = heroes.OrderByDescending(hero => hero.Value.HP)
                .ThenBy(hero => hero.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var hero in sortedHeroes)
            {
                if (hero.Value.HP > 0)
                {
                    Console.WriteLine(hero.Key);
                    Console.WriteLine($"  HP: { hero.Value.HP }");
                    Console.WriteLine($"  MP: { hero.Value.MP }");
                }
                
            }
        }
    }
}
