using System;


    void MooseSays(string message)
    {
        Console.WriteLine(@"
   *         *   *         *
         *           ()           *
    *   ___      ___// ____   * 
 *     {   \   _/ * / /    }    *   *
  *    {__  \_/ *  /_/  __/      *
    *    _\  /_*__*_\   /__     *
        {___(_______/   ___}  *    *
 *    *     \_  ~~ ~~  /            *
         *    |(o} (o}  \_      * *
   *          | ^   ^         *
    ,   *   _/          __       *
  __|\__  (o)  (o) {   }     *
   \   /  |_      _|\_/             *
 *  |/\|  [________],        *     *
    ` \\     \\___//       *
       \\     ^^^^^              *
");

        Console.WriteLine(message);

    }

    void MooseSpeaks(string message)
{
    Console.WriteLine(message);
}

string Answer(int num)
{
    List<string> answers = new List<string> {
        "As I see it, yes.",
        "Ask again later.",
        "Better not tell you now.",
        "Cannot predict now.",
        "Concentrate and ask again.",
        "Don't count on it.",
        "It is certain.",
        "It is decidedly so.",
        "Most likely.",
        "My reply is no.",
        "My sources say no.",
        "Outlook not so good.",
        "Outlook good.",
        "Reply hazy, try again.",
        "Signs point to yes.",
        "Very doubtful.",
        "Without a doubt.",
        "Yes.",
        "Yes - definitely.",
        "You may rely on it."
    };

    return answers[num];
}

    MooseSays("*** Hello, 'tis I, the Magic Moose! ***");
    MooseSpeaks("Ask any question, and I shall provide an answer.");

int Random()
{
    Random r = new Random();
    int genRand = r.Next(0, 19);
    return genRand;
}

bool MooseAsks(string question)
{
    Console.Write($"{question}");
    string answer = Console.ReadLine();
    if (answer == null || answer == "")
    {
        return false;
    }
    else if (answer != "")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void MooseReplies()
{
    MooseAsks("What is thine question?");
    MooseSpeaks(Answer(Random()));
}

MooseReplies();