public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {

        _prompts = new List<string>
            {
                "What important lesson did I learn today?",
                "What was the most significant challenge I faced today and how did I overcome it?",
                "What was the best decision I made today and why?",
                "What can I do to improve my day tomorrow?",
                "What was the funniest or most amusing moment I experienced today?"

            };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}