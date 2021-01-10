using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new SortedDictionary<string, Demon>();

            foreach (var demon in demons)
            {
                var healthSimbols = demon.Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.');

                var health = 0;

                foreach (var healthSimbol in healthSimbols)
                {
                    health += healthSimbol;
                }

                var regex = new Regex(@"-?\d+\.?\d*");

                var matches = regex.Matches(demon);

                var damage = 0.0;

                foreach (Match match in matches)
                {
                    var currentNumber = double.Parse(match.Value);

                    damage += currentNumber;
                }

                var modifiers = demon.Where(s => s == '*' || s == '/');

                foreach (var modifier in modifiers)
                {
                    if (modifier == '*')
                    {
                        damage *= 2;
                    }
                    else if (modifier == '/')
                    {
                        damage /= 2;
                    }
                }
                result.Add(demon, new Demon
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                });
            }

            foreach (var demonEntry in result)
            {
                var demon = demonEntry.Value;

                Console.WriteLine("{0} - {1} health, {2:F2} damage", demon.Name, demon.Health, demon.Damage);
            }
        }
    }
}
