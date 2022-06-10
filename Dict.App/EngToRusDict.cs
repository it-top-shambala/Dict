namespace Dict.App;

public class EngToRusDict
{
    private Dictionary<string, List<string>> _dict;
    private Action<string> _info;

    public EngToRusDict()
    {
        _dict = new Dictionary<string, List<string>>();
    }
    public EngToRusDict(Dictionary<string, List<string>> dict)
    {
        _dict = dict;
    }

    public void AddHandler(Action<string> action)
    {
        if (_info is null)
        {
            _info = action;
        }
        else
        {
            _info += action;
        }
    }
    public void DelHandler(Action<string> action)
    {
        _info -= action; //TODO
    }
}