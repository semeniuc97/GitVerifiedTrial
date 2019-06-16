using System;

namespace GitVerifiedCommitTrying
{
    class Person
    {
        private string name;
        private Company company;

        public Person()
        {
            this.company = new Company();
        }
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
                    this.name = value + " " + "additional" + company.name;
                }
            }
        }
        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine(this.name + " " + this.company.name);
        }
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
