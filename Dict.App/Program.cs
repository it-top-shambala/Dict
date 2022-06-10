// Написать программу "Англо-русский словарь".
// Пользователь может дополнять словарь, но не может изменять или удалять.

namespace Dict.App 
{
    internal class Program
    {
        static void Main()
        {
            var dict = new EngToRusDict();
            dict.AddHandler((msg) => LogToFile.Info("info.log", msg));
            
            var key = "exit";
            var values = new List<string> { "выход" };
            dict.AddItemToDict(key, values);

            key = "book";
            values = new List<string> { "книга", "заказывать" };
            dict.AddItemToDict(key, values);
            
            PrintDict(dict.GetDict());
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
                Console.WriteLine($"\t{value}");
            }
            Console.WriteLine();
        }
    }
}