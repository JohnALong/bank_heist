﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace bank_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int luck_level = 0;
            int difficulty_level = 0;
            int sum_skill = 0;
            int trial_runs = 0;
            int success = 0;
            int failure = 0;
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("What is the bank's difficulty level up to 100?");
            string _difficulty_level = Console.ReadLine();
            difficulty_level = int.Parse(_difficulty_level);
            Dictionary<string, Member> members = new Dictionary<string, Member>();
            int i = 0;
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
            Console.WriteLine("How many tries would you like?");
            string _trial_runs = Console.ReadLine();
            trial_runs = int.Parse(_trial_runs);

            
            while (i < trial_runs)
            {
                luck_level = r.Next(-10, 10);
                if (sum_skill >= (difficulty_level + luck_level))
                    {
                        Console.WriteLine($"The bank's difficulty was {(difficulty_level + luck_level)}");
                        Console.WriteLine($"The team's skill level was {sum_skill}");
                        Console.WriteLine("You robbed the bank!");
                        i++;
                        success += 1;
                    } else
                    {
                        Console.WriteLine($"The bank's difficulty was {(difficulty_level + luck_level)}");
                        Console.WriteLine($"The team's skill level was {sum_skill}");
                        Console.WriteLine("You need bail money!");
                        i++;
                        failure += 1;
                    }
                    // foreach (KeyValuePair<string, Member> x in members)
                    // {
                    //     Console.WriteLine($"{x.Key} is a skill level of {x.Value.skillLevel} with a courage of {x.Value.courage}");
                    // }
            }
            Console.WriteLine($"You were successful {success} times and failed {failure} times.");
        }
    }
}
