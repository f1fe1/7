using System;
using _005__task.Border_Control;
class Program
{
    static void Main()
    {
        BorderControl borderControl = new BorderControl();

        string inputData = Console.ReadLine();

        while(inputData.ToLower() != "end")
        {
            string[] arrData = inputData.Split();
            switch (arrData.Length)
            {
                case 3:
                    borderControl.AddPerson(arrData[0], int.Parse(arrData[1]), arrData[2]);
                    break;
                case 2:
                    borderControl.AddRobot(arrData[0], arrData[1]);
                    break;

                default:
                    throw new Exception("Invalid the data!!!");
                    break;
            }

            inputData = Console.ReadLine();
        }

        string needID = Console.ReadLine();
        borderControl.SetIdCode(needID);
        Console.WriteLine(borderControl.GetIdCode(needID));
        Console.ReadLine();
    }
}
