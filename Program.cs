using System;

namespace bank_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            CreateMember();
        }

        private static void CreateMember()
        {
            while (true)
            {
                Member member = new Member();
                Console.WriteLine("Enter the name of the team member or '' to exit");
                string _name = Console.ReadLine();
                if (_name == "")
                {
                    break;
                }
                try
                {
                    member.Name = _name;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine($"What is {member.Name}'s skill level?");
                string _skillLevel = Console.ReadLine();
                if (_skillLevel == "")
                {
                    break;
                }
                try
                {
                    member.skillLevel = int.Parse(_skillLevel);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine($"What is {member.Name}'s courage? (0 - 2.0)?");
                string _courage = Console.ReadLine();
                if (_courage == "")
                {
                    break;
                }
                try
                {
                    member.courage = Convert.ToDouble(_courage);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine($"{member.Name}'s skill level is {member.skillLevel}, and his courage is {member.courage}");
            }
        }
    }
}
