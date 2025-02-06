namespace InnleveringsOppgave2;

class Program
{
    // Use Dictionary for looking up for custom messages based on hours
    static Dictionary<int, string> messageByTime = new Dictionary<int, string>()
    {
        {0,  "The time is past midnight, you should go to bed now, {0}" },
        {1,  "Good night, {0}" },
        {2,  "Still not sleeping, good night, {0}!" },
        {3,  "You should definetely be sleeping now, {0}" },
        {4,  "NOPE! GO BACK TO SLEEP, {0}!!" },
        {5,  "It's not time go get out of bed yet, {0}" },
        {6,  "Early morning, {0}" },
        {7,  "Good morning, {0}" },
        {8,  "Good morning, {0}" },
        {9,  "Good morning, {0}" },
        {10, "Are you ready for our brunchdate, {0}?" },
        {11, "Have a great lunch now, {0}" },
        {12, "Having a late lunch today, {0}?" },
        {13, "Time for your lunch nap, {0}" },
        {14, "Time to make some dinnerplans, {0}" },
        {15, "Winner winner {0} is making dinner!" },
        {16, "{0}! Dinnertime!!" },
        {17, "Your time to clean the disches, {0}" },
        {18, "It's TV time {0}" },
        {19, "MORE TV time {0}" },
        {20, "and a little LoL time before bed {0}" },
        {21, "Time for you to prep for bed {0}" },
        {22, "zzzZZZZz{0}zzZZZZzzz{0}zzzZZZZzzzZZZ{0}zzzZZZzzZZzzz..." },
        {23, "zzzZZZZz{0}zz...ZZZZzzz{0}zzzZZZZ...zzzZZZ{0}zzzZZZ...zzZZzzz...sleep apnea in progress" }
    };
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");

        string? name = Console.ReadLine();

        DateTime nowTime = DateTime.Now;

        int nowHour = nowTime.Hour;

        string? birgerBotAnswer = messageByTime.GetValueOrDefault(nowHour);

        if (birgerBotAnswer == null)
        {
            Console.WriteLine($"OMG {name.ToUpper()} WHAT ARE YOU DOING?! ");
        }
        else
        {
            Console.WriteLine(birgerBotAnswer,name);
            Console.WriteLine(nowTime.ToString());
        }
        Console.Read();
    }
}
