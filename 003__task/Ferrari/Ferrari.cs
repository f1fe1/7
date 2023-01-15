using _003__task.IInterfaces;
using System;
using System.Text;

namespace _003__task.Ferrari
{
    internal class Ferrari : IPushTheGas, IUseBrakes
    {
        private readonly string name;
        private string driver;
        public Ferrari(string driver)
        {
            this.name = "488-Spider";
            this.Driver = driver;
        }
        public string Driver
        {
            get { return this.driver; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("You entered the wrong name!");
                }
                this.driver = value;    
            }
        }
        public string GetPushTheGas()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Push the Gas!");
            string result = builder.ToString().TrimEnd();
            return result;
        }
        public string GetBrakes()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Brakes!");
            string result = builder.ToString().TrimEnd();
            return result;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"The model: {this.name} + the driver is {this.Driver} \n" +
                 $"Method 1: {this.GetBrakes()} + Method 2: {this.GetPushTheGas()}");
            string result = builder.ToString().TrimEnd();
            return result;
        }
    }
}
