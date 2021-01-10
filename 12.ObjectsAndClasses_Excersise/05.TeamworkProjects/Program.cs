using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Създаваме си един нов лист, в който ще се пазят екипите ни. При създаването на нов екип, ще го добавяме тук
            List<Team> teams = new List<Team>();

            // Прочитаме едно цяло число, което представлява броя на екипите, които трябва да регистрираме
            int numberOfTeams = int.Parse(Console.ReadLine());

            // След това ще четем стрингове, докато не получим командата "end of assignment"
            

            for (int i = 0; i < numberOfTeams; i++)
            {
                // Тук ще добавяме отбор
                var info = Console.ReadLine().Split("-").ToArray();

                //Като го сплитнем, това ще ни даде човека, който иска да създаде отбора и кой отбор иска да суздаде
                string creator = info[0];
                string teamName = info[1];

                // Правим си проверка дали името на отбора, който искаме да създадем вече не съществува в листа teams
                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                // Тук ще си създаваме отбор
                Team team = new Team(teamName, creator);

                // Сега този екип си го добавяме в лист с екипите (който е в началото на главния метод)
                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                // Тук ще добавяме човек към отбора
                    var info = command.Split("->").ToArray();
                    string person = info[0];
                    string teamName = info[1];

                // Проверяваме дали има човек, който иска да се присуедини към несъществуващ екип
                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                // Проверява дали в екипите има такъв екип (х), за който екип списъка с екипите, който съдържа този човек, който ние искаме сега да добавим. 
                if (teams.Any(x => x.peopleJoined.Contains(person) || teams.Any(x => x.Creator == person && x.Name == teamName)))
                {
                    Console.WriteLine($"Member {person} cannot join team {teamName}!");
                    continue;
                }

                int index = teams.FindIndex(x => x.Name == teamName); // Това намира конкретния екип, към който искаме да добавим човека.

                teams[index].peopleJoined.Add(person);
            }

            // Това ще ни върне един лист с екипите, за които хората, които са се присъединили са 0 и листа е подреден по имената на хората
            var teamsToBeDisbanded = teams.FindAll(x => x.peopleJoined.Count == 0).OrderBy(x => x.Name).ToList();

            var validTeams = teams.FindAll(x => x.peopleJoined.Count > 0).OrderBy(x => x.Name).ToList();

            // Принтираме първо валидните екипи
            Console.WriteLine(string.Join(Environment.NewLine, validTeams
                .OrderByDescending(x => x.peopleJoined.Count)
                .ThenBy(x => x.Name)));

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToBeDisbanded)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }

        //Ще си създадем един лист от хора, които са се присъединили към екипите
        public List<string> peopleJoined;  //За сега го оставяме така, без get; set; 


        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            peopleJoined = new List<string>();  // Тук единствено инициализираме листа с хората. Когато влиза нов човек в екипа, тогава ще казваме на този лист да го добави.

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine("- " + Creator);

            
            foreach (var member in peopleJoined)
            {
                sb.AppendLine("-- " + member);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
