using OAPR.Infra.Notification.Model;

namespace OAPR.Infra.Notification.Interfaces
{
    public interface INotifiable
    {
        bool HasErrorNotification { get; }

        bool HasSuccessNotification { get; }

        IReadOnlyList<NotificationMessage> ErrorNotificationResult { get; }

        IReadOnlyList<NotificationMessage> SuccessNotificationResult { get; }
    }
}