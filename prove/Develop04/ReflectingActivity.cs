public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Queue<string> _promptQueue;
    private Queue<string> _questionQueue;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        InitializeQueues();
    }

     private void InitializeQueues()
    {
        
        _promptQueue = new Queue<string>(_prompts.OrderBy(x => _random.Next()));
        _questionQueue = new Queue<string>(_questions.OrderBy(x => _random.Next()));
    }

    public override void Run()
    {
        
        DisplayPrompt();
        DisplayQuestions();
        
    }

    private static Random _random = new Random();

    public string GetNextPrompt()
    {
        if (_promptQueue.Count == 0)
        {
            InitializeQueues();
        }
        return _promptQueue.Dequeue();
    }

    public string GetNextQuestion()
    {
        if (_questionQueue.Count == 0)
        {
            InitializeQueues();
        }
        return _questionQueue.Dequeue();
    }

    public void DisplayPrompt()
{
    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
        string prompt = GetNextPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("When you have something in mind, press Enter to continue.");

        
        DateTime waitEndTime = DateTime.Now.AddSeconds(5); 
        
        while (DateTime.Now < waitEndTime)
        {
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                break;
        }
    }
}

    public void DisplayQuestions()
    {
        Console.WriteLine("Reflect on the following questions:");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetNextQuestion();
            Console.WriteLine($"- {question}");
            Console.ReadLine();
        }
    }
}