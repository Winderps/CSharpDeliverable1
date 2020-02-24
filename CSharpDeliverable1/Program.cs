using System;

namespace CSharpDeliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";
            string flightType = "";
            string vacationType = "";
            int groupSize = 0;

            Console.Write("What type of trip will you be going on? (please enter musical, tropical, or adventurous): ");
            vacationType = Console.ReadLine().ToLower();
            Console.Write("How many will you be travelling with? ");
            groupSize = int.Parse(Console.ReadLine());
            switch(vacationType)
            {
                case "musical":
                    destination = "New Orleans";
                    break;
                case "tropical":
                    destination = "a beach vacation in Mexico";
                    break;
                case "adventurous":
                    destination = "go whitewater rafting in the Grand Canyon";
                    break;
            }
            if (groupSize >= 6)
                flightType = "charter";
            else if (groupSize >= 3)
                flightType = "helicopter";
            else
                flightType = "first class";

            string result = $"Since you are {(groupSize == 1 ? "on your own" : $"a group of {groupSize}")} going on {(vacationType == "adventurous" ? "an" : "a")} {vacationType} vacation, you should take a {flightType} flight to {destination}.";

            Console.WriteLine(result);

        }
    }
}
