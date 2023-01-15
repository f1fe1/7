using _005__task.Person_and_Robot;
using System;
using System.Text;

namespace _005__task.Border_Control
{
    internal class BorderControl
    {
        List<Person> people;
        List<Robot> robots;
        List<string> list_ID;
        public BorderControl()
        {
            people = new List<Person>();
            robots = new List<Robot>();
            list_ID = new List<string>();
        }

        public void AddPerson(string name, int age, string id)
        {
            Person person = new Person(name, id, age);
            people.Add(person);
        }
        public void AddRobot(string model, string id)
        {
            Robot robot = new Robot(model, id);
            robots.Add(robot);
        }

        public void SetIdCode(string idCode)
        {
            this.list_ID.AddRange(this.people.Where(x => x.Id.EndsWith(idCode)).Select(y => y.Id).ToList());
            this.list_ID.AddRange(this.robots.Where(x => x.Id.EndsWith(idCode)).Select(y => y.Id).ToList());
        }

        public string GetIdCode(string idCode)
        {
            StringBuilder builder = new StringBuilder();
            this.list_ID.Where(x => x.EndsWith(idCode)).ToList().ForEach(x => builder.AppendLine(x));
            return builder.ToString().TrimEnd();
        }
    }
}
