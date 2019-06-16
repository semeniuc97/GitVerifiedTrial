using System;

namespace GitVerifiedCommitTrying
{
    class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length <= 6)
                {
                    this.name = value + " " + "additional";
                }
            }
        }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var person = new Person();
            person.Name = name;

            Console.WriteLine(person.Name);
        }
    }
}
