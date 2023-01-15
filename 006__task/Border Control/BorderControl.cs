using _006__task.Domains;
using _006__task.Interfaces;
using System;

namespace _006__task.Border_Control
{
    internal class BorderControl
    {
        private List<Person> people;
        private List<Robot> robots;
        private List<IIdNumber> errors;
        public BorderControl()
        {
            people = new List<Person>();
            robots = new List<Robot>();
            errors = new List<IIdNumber>();
        }
        public void AddPerson(string name, string id, int age)
        {
            var perosn = new Person(name, id, age);
            people.Add(perosn);
        }

        public void AddRobot(string model, string id)
        {
            var robot = new Robot(model, id);
            robots.Add(robot);
        }
        public void FindID(string zip)
        {
            foreach(var person in people)
            {
                if (person.Id.EndsWith(zip))
                {
                    errors.Add(person);
                }
            }

            foreach(var robot in robots)
            {
                if (robot.Id.EndsWith(zip))
                {
                    errors.Add(robot);
                }
            }
        }

        public void ShowID()
        {
            foreach(var error in errors)
            {
                Console.WriteLine($"The ID number is: {error.Id}");
            }
        }
    }
}
