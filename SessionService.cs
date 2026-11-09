namespace EventEaseApp
{
    public class SessionService
    {
        public string? CurrentUserName { get; set; }
        public bool IsRegistered => !string.IsNullOrWhiteSpace(CurrentUserName);
    }
}