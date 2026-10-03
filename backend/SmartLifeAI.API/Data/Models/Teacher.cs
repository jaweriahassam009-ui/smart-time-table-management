namespace SmartLifeAI.API.Models;

public class Teacher
{
    public int TeacherID { get; set; }
    public string TeacherName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Specialization { get; set; } = "";
    public string Availability { get; set; } = "";
}