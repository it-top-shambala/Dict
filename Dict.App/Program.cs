// Написать программу "Англо-русский словарь".
// Пользователь может дополнять словарь, но не может изменять или удалять.

namespace Dict.App 
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> dict;
        }

        static void PrintDict(Dictionary<string, List<string>> dict)
        {
            foreach (var (key, list) in dict)
            {
                PrintDictItem(key, list);
            }
        }

        static void PrintDictItem(string key, List<string> values)
        {
            Console.WriteLine($"{key}:");
            foreach (var value in values)
            {
                Console.WriteLine($"\t\t{value}");
            }
            Console.WriteLine();
        }

        static bool AddValueToDictItem(Dictionary<string, List<string>> dict, string key, string newValue)
        {
            if (!dict.ContainsKey(key)) return false;

            /*foreach (var value in dict[key])
            {
                if (value == newValue) return false;
            }*/
            
            if (dict[key].Any(value => value == newValue)) return false;
            
            dict[key].Add(newValue);
            return true;
        }

        static bool AddItemToDict(Dictionary<string, List<string>> dict, string key, List<string> values)
        {
            if (dict.ContainsKey(key)) return false;
            
            dict.Add(key, values);
            return true;

            // return dict.TryAdd(key, values);
        }
    }
}