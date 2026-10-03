namespace SmartLifeAI.API.Models;

public class Class
{
    public int ClassID { get; set; }
    public string ClassName { get; set; } = "";
    public string Department { get; set; } = "";
    public int Semester { get; set; }
    public string Section { get; set; } = "";
    public int StudentCount { get; set; }
}