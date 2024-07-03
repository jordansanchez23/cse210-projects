public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

   
    //This "blank" constructor calls the parameters from the base class//
    public MathAssignment() : base()
    {

    }
 //constructor to include studentname, topic, section and problems//
    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    //Is not necessary //
    //public string GetTextBookSection()
    //{
    //    return _textBookSection;
    //}

    //public void SetTextBookSection(string textBookSection)
    //{
    //    _textBookSection = textBookSection;
    //}

    //public string GetProblems()
    //{
    //    return _problems;
    //}

    //public void SetProblems(string problems)
    //{
    //    _problems = problems;
    //}


    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} - Problems {_problems}";
    }
}