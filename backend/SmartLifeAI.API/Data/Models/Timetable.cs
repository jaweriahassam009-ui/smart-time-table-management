namespace SmartLifeAI.API.Models;

public class Timetable
{
    public int TimetableID { get; set; }
    public int CourseID { get; set; }
    public int TeacherID { get; set; }
    public int ClassID { get; set; }
    public int TimeSlotID { get; set; }
    public string DayOfWeek { get; set; } = "";
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}