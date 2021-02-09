// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using System.Collections.Generic;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
public class Location
{
    public string name { get; set; }
    public string region { get; set; }
    public string country { get; set; }
    public double lat { get; set; }
    public double lon { get; set; }
    public string tz_id { get; set; }
    public int localtime_epoch { get; set; }
    public string localtime { get; set; }
}

public class Condition
{
    public string text { get; set; }
    public string icon { get; set; }
    public int code { get; set; }
}

public class Current
{
    public double temp_c { get; set; }
    public double temp_f { get; set; }
    public int is_day { get; set; }
    public string last_updated { get; set; }
    public Condition condition { get; set; }
}

public class dato
{
    public Location location { get; set; }
    public Current current { get; set; }
}





