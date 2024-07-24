public class Reception : Event
{
    private List<string> _rsvpEmails;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, List<string> rsvpEmails) : base(title, description, date, time, address)
    {
        _rsvpEmails = rsvpEmails;
    }

    public  string GenerateFullMessage()
    {
        return $"{GenerateStandardMessage()}\nRSVP Emails: {string.Join(", ", _rsvpEmails)}";
    }



}