public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {

    }

    public override void Run()
    {
        
        Console.WriteLine("Breathing in...");
        ShowCountDown(4); 
        Console.WriteLine("Breathing out...");
        ShowCountDown(4); 

        
        int remainingTime = _duration - 8; 

        DateTime endTime = DateTime.Now.AddSeconds(remainingTime); 

        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathing in...");
            ShowCountDown(4); 

            if (DateTime.Now < endTime) 
            {
                Console.WriteLine("Breathing out...");
                ShowCountDown(4); 
            }
        }

        
    }
}