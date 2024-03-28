using TyperProject.Auth;

namespace TyperProject.Records
{
    public class Record
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public float WordsPerMinute { get; set; }
        public DateTime Date { get; set; }
    }
}
