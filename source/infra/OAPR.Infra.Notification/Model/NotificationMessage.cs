namespace OAPR.Infra.Notification.Model
{
    public class NotificationMessage
    {
        public string Message { get; private set; }

        public NotificationMessage(string message)
        {
            Message = message;
        }
    }
}