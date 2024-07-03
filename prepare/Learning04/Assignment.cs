public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        _studentName = "Anonymous";
        _topic = "Unknown";
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

// The setter serves to receive the value
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

//The getter serves to return the value, in this case as _topic
    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}