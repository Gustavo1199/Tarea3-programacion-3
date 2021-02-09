public class From
{
    public string first_name { get; set; }
    public string username { get; set; }
}

public class Chat
{
    public string title { get; set; }
    public string type { get; set; }
}

public class Result
{
    public From from { get; set; }
    public Chat chat { get; set; }
    public string text { get; set; }
}

public class DatosT
{
    public bool ok { get; set; }
    public Result result { get; set; }
}