namespace WarehouseManagement.Frontend.Models;

public enum NotificationType
{
    Info,
    Success,
    Warning,
    Error
}

public class NotificationModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public NotificationType Type { get; set; } = NotificationType.Info;
    public DateTime Timestamp { get; set; } = DateTime.Now;
    public int Duration { get; set; } = 3500;
}