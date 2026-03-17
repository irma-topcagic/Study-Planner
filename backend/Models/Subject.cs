namespace backend.Models;

public class Subject
{
        public int Id{get; set;}
        public string Name{get; set;} = string.Empty;
        public string Color{get; set;}="#4F46E5";
        public int UserId{get; set;}
        public User User{get; set;}
}
