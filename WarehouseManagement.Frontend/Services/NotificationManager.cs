using WarehouseManagement.Frontend.Models;

namespace WarehouseManagement.Frontend.Services;

public interface INotificationManager
{
    event Action<NotificationModel>? OnNotificationAdded;
    event Action<Guid>? OnNotificationRemoved;

    const int defaultDuration = 1500;

    void Show(NotificationModel notification);
    void Show(string title, string message, NotificationType type = NotificationType.Info, int duration = defaultDuration);
    void ShowSuccess(string title, string message, int duration = defaultDuration);
    void ShowError(string title, string message, int duration = defaultDuration);
    void ShowWarning(string title, string message, int duration = defaultDuration);
    void ShowInfo(string title, string message, int duration = defaultDuration);
    void Remove(Guid id);
}

public class NotificationManager : INotificationManager
{
    public event Action<NotificationModel>? OnNotificationAdded;
    public event Action<Guid>? OnNotificationRemoved;

    const int defaultDuration = 1500;

    public void Show(NotificationModel notification)
    {
        OnNotificationAdded?.Invoke(notification);
        // Автоматическое удаление уведомления через заданное время
        if (notification.Duration > 0)
        {
            Task.Delay(notification.Duration).ContinueWith(_ => Remove(notification.Id));
        }
    }

    public void Show(string title, string message, NotificationType type = NotificationType.Info, int duration = defaultDuration)
    {
        var notification = new NotificationModel
        {
            Title = title,
            Message = message,
            Type = type,
            Duration = duration
        };
        Show(notification);
    }

    public void ShowSuccess(string title, string message, int duration = defaultDuration) =>
        Show(title, message, NotificationType.Success, duration);

    public void ShowError(string title, string message, int duration = defaultDuration) =>
        Show(title, message, NotificationType.Error, duration);

    public void ShowWarning(string title, string message, int duration = defaultDuration) =>
        Show(title, message, NotificationType.Warning, duration);

    public void ShowInfo(string title, string message, int duration = defaultDuration) =>
        Show(title, message, NotificationType.Info, duration);

    public void Remove(Guid id)
    {
        OnNotificationRemoved?.Invoke(id);
    }
}