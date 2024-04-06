public class Adress
{
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;

    public Adress(string streetAdress, string city, string state, string country)
    {
        _streetAdress = streetAdress;
        _city = city;
        _state = state;
        _country = country;
    }


    public bool IsInUSA()
    {
        if (_country == "USA"){
            return true;
        }
        else{
            return false;
        }
    }

    public string GetCountry()
    {
        return _country;
    }
    public string FullAdress()
    {
        return $"{_streetAdress}, {_city},{_state} - {_country}";
    }
}