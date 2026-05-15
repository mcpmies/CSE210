class Questions
{
    private List<string> _questionList = new List<string>()
    {
        "What was the best part of your day?",
        "What was the worst part of your day?",
        "How did I see the hand of the Lord in your life today?",
        "What was the most interesting thing that happened today?",
        "What were you grateful for today?"
    };
    
    private Random random = new Random();

    public string SelectQuestion()
    {
        int index = random.Next(_questionList.Count);
        string randomQuestion = _questionList[index];

        return randomQuestion;
    }
}