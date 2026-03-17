namespace backend.Models;

public class StudySession
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int DurationMinutes { get; set; }
    public string Notes { get; set; } = string.Empty;
    public int SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;
    public int UserId { get; set; }
    public User User { get; set; } = null!;
}