namespace Dict.App;

public static class LogToFile
{
    private static void WriteToFile(string path, string message)
    {
        var file = new StreamWriter(path, true);
        file.WriteLine($"{DateTime.Now:g}: {message}");
        file.Close();
    }

    public static void Info(string path, string message)
    {
        WriteToFile(path, $"[INFO] {message}");
    }
}