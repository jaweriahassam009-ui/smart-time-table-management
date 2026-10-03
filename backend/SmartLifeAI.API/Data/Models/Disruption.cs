namespace SmartLifeAI.API.Models;

public class Disruption
{
    public int DisruptionID { get; set; }
    public int UserID { get; set; }
    public string DisruptionType { get; set; } = "";
    public string Description { get; set; } = "";
    public DateTime DisruptionDate { get; set; }
    public int AvailableHours { get; set; }
    public DateTime CreatedAt { get; set; }
}