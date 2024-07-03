public class WritingAssignment : Assignment
{
    private string _title;

    //constructor for "blank" parameters
    public WritingAssignment() : base()
    {

    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

//Is not necessary 
//Getter & setter//
   // public string GetTitle()
    //{
    //    return _title;
    //}

//    public void SetTitle(string title)
//    {
//        _title = title;
//    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}