using _004__task.IInterfaces;
using System;
using System.Text;

namespace _004__task.Smartphone
{
    public class Smartphone : IPhone
    {
        public string PhoneNumber { get; set; }
        public string URLAddress { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Calling: {this.PhoneNumber}\n")
                .Append($"Browsing: {this.URLAddress}\n")
                .Append($"Email: {this.Email}\n");

            string result = builder.ToString().TrimEnd();
            return result;
        }
    }
}
