using System;

namespace SandboxProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.SetFirstName("Roberto");
            person1.SetLastName("Ramirez");

            Console.WriteLine(person1.GetFullName());

            ChurchMember person2 = new ChurchMember();
            person2.SetFirstName("Veronica");
            person2.SetLastName("Curiel");
            person2.SetCalling("Primary President");

            Console.WriteLine(person2.GetChurchMemberInfo());

        }
    }
}
