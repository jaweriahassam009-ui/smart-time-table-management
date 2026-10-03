namespace SmartLifeAI.API.Models;

public class TimeSlot
{
    public int TimeSlotID { get; set; }
    public string DayOfWeek { get; set; } = "";
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}