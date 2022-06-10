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
    
    public bool AddValueToDictItem(string key, string newValue)
    {
        if (!_dict.ContainsKey(key))
        {
            _info?.Invoke($"Слова {key} в словаре не найдено");
            return false;
        }

        if (_dict[key].Any(value => value == newValue))
        {
            _info?.Invoke($"Перевод {newValue} для слова {key} уже существует");
            return false;
        }
            
        _dict[key].Add(newValue);
        _info?.Invoke($"Перевод {newValue} для слова {key} успешно добавлен");
        return true;
    }

    public bool AddItemToDict(string key, List<string> values)
    {
        if (_dict.ContainsKey(key))
        {
            _info?.Invoke($"Слова {key} в словаре уже существует");
            return false;
        }
            
        _dict.Add(key, values);
        _info?.Invoke($"Переводы для слова {key} успешно добавлены");
        return true;
    }

    public Dictionary<string, List<string>> GetDict() => _dict;
}