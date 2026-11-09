namespace EventEaseApp
{
    public class AttendanceService
    {
        public List<string> Attendees { get; set; } = new();

        public void AddAttendee(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Attendees.Add(name);
        }
    }
}
