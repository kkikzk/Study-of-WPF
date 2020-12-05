using System;

namespace Case07.ViewModel
{
    public class UserNotificationObject
    {
        public event EventHandler<NotifyErrorEventArgs> NotifyErrorEvent;
        public static string EventName { private set; get; } = nameof(NotifyErrorEvent);

        public class NotifyErrorEventArgs : EventArgs
        {
            public string Message { get; set; }
        }

        public void NotifyError(string message)
        {
            //イベントを発行する
            NotifyErrorEvent?.Invoke(this, new NotifyErrorEventArgs() { Message = message });
        }
    }

    public class UserNotificationObjectTrigger : Microsoft.Xaml.Behaviors.EventTrigger
    {
        public UserNotificationObjectTrigger()
            : base(UserNotificationObject.EventName)
        {
        }
    }
}
