public class Lecture : Event
{
    private string _speaker;
    private int _seatingCapacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int seatingCapacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _seatingCapacity = seatingCapacity;
    }

    public string GenerateFullMessage()
    {
        return $"{GenerateStandardMessage()}\nEvent type: Lecture\nSpeaker: {_speaker}\nSeating Capacity: {_seatingCapacity}";
    }
}