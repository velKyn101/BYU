using System.Net.Sockets;

public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    Address _address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetStandardDetails()
    {
        return $"{_title}\n{_description}\n{_date.ToShortDateString()}\n{_time}\n{_address.GetFullAdress()}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDetails()
    {
        return $"Type: {GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}