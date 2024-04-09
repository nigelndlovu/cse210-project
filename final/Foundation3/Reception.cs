using System;

public class Reception : Event
{
    private string _email { get; set; }

    public Reception(string title, string description, DateTime date, string time, Address address, string email)
        : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {_email}";
    }
}