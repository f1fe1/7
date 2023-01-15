using System;
using _006__task.Border_Control;

class Programm
{
    static void Main()
    {
        var border = new BorderControl();

        var input = Console.ReadLine();
        while(input.ToLower() != "end")
        {
            string[] arrayInput = input.Split(' ');
            switch (arrayInput.Length)
            {
                case 3:
                    border.AddPerson(arrayInput[0], arrayInput[1], int.Parse(arrayInput[2]));
                    break;

                case 2:
                    border.AddRobot(arrayInput[0], arrayInput[1]);
                    break;

                default:
                    throw new FormatException("You entered wrong format of data");
                    break;
            }

            input = Console.ReadLine();
        }

        var zip = Console.ReadLine();
        border.FindID(zip);
        border.ShowID();


        Console.ReadLine();
    }
}