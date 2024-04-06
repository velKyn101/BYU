public class Custumer
{
    private string _name;
    private Adress adress;

    public Custumer(string name, Adress adress)
    {
        _name = name;
        this.adress = adress;
    }

    public bool IsInUSA()
    {
        if (adress.IsInUSA())
        {
            return true;
        }
        else
        {
            return false;   
        }
    }

    public string GetName()
    {
        return _name;
    }
    public string GetAdress()
    {
        return adress.FullAdress();
    }
}