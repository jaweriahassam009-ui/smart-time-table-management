namespace SmartLifeAI.API.Models;

public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; } = "";
    public string CourseCode { get; set; } = "";
    public int Credits { get; set; }
    public int TeacherID { get; set; }
    public int Duration { get; set; }
}