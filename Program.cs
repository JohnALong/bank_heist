using System;
using System.Collections.Generic;
using System.Linq;

namespace bank_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int luck_level = r.Next(-10, 10);
            int difficulty_level = 100;
            int sum_skill = 0;
            Console.WriteLine("Plan your heist!");
            Dictionary<string, Member> members = new Dictionary<string, Member>();

            while (true)
            {
                Member member = new Member();
                Console.WriteLine("Enter the name of the team member or '' to exit");
                string _name = Console.ReadLine();
                if (_name == "")
                {
                    break;
                } else
                {
                    member.Name = _name;
                }
                Console.WriteLine($"What is {member.Name}'s skill level?");
                string _skillLevel = Console.ReadLine();
                {
                    member.skillLevel = int.Parse(_skillLevel);
                }
                Console.WriteLine($"What is {member.Name}'s courage? (0 - 2.0)?");
                string _courage = Console.ReadLine();
                member.courage = Convert.ToDouble(_courage);
                members.Add(member.Name, member);
            }
            Console.WriteLine($"There are {members.Count} members on the team");
            sum_skill = members.Sum(x => x.Value.skillLevel);
            

            if (sum_skill >= (difficulty_level + luck_level))
            {
                Console.WriteLine($"The bank's difficulty was {(difficulty_level + luck_level)}");
                Console.WriteLine($"The team's skill level was {sum_skill}");
                Console.WriteLine("You robbed the bank!");
            } else
            {
                Console.WriteLine($"The bank's difficulty was {(difficulty_level + luck_level)}");
                Console.WriteLine($"The team's skill level was {sum_skill}");
                Console.WriteLine("You need bail money!");
            }
            // foreach (KeyValuePair<string, Member> x in members)
            // {
            //     Console.WriteLine($"{x.Key} is a skill level of {x.Value.skillLevel} with a courage of {x.Value.courage}");
            // }
        }
    }
}
