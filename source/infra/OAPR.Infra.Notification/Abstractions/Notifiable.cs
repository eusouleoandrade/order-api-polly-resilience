using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using OAPR.Infra.Notification.Interfaces;
using OAPR.Infra.Notification.Model;

namespace OAPR.Infra.Notification.Abstractions
{
    public abstract class Notifiable : INotifiable
    {
        private List<NotificationMessage> _errorNotifications;

        private List<NotificationMessage> _successNotifications;

        [NotMapped]
        [JsonIgnore]
        public bool HasErrorNotification
            => ErrorNotifications.Any();

        [NotMapped]
        [JsonIgnore]
        public bool HasSuccessNotification
            => SuccessNotifications.Any();

        [NotMapped]
        [JsonIgnore]
        public IReadOnlyList<NotificationMessage> ErrorNotifications
            => _errorNotifications;

        [NotMapped]
        [JsonIgnore]
        public IReadOnlyList<NotificationMessage> SuccessNotifications
            => _successNotifications;

        public Notifiable()
        {
            _errorNotifications = new List<NotificationMessage>();
            _successNotifications = new List<NotificationMessage>();
        }

        protected void AddErrorNotification(NotificationMessage errorNotificationMessage)
            => _errorNotifications.Add(errorNotificationMessage);

        protected void AddErrorNotification(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
                _errorNotifications.Add(new NotificationMessage(message));
        }

        protected void AddErrorNotification(IEnumerable<string> messages)
        {
            if (messages.Any())
                messages.ToList().ForEach(message => AddErrorNotification(message));
        }

        protected void AddErrorNotification(IEnumerable<NotificationMessage> messages)
        {
            if (messages.Any())
                messages.ToList().ForEach(message => AddErrorNotification(message));
        }

        protected void AddSuccessNotification(NotificationMessage successNotificationMessage)
            => _successNotifications.Add(successNotificationMessage);
    }
}