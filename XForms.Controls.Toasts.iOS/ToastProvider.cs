using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(Xamarin.Forms.Controls.Extras.iOS.ToastProvider))]
namespace Xamarin.Forms.Controls.Extras.iOS
{
    public class ToastProvider : IToastProvider
    {
        NSTimer alertDelay;
        ToastView alert;

        public void MakeText(string text)
        {
            if (alert != null)
                DismissMessage();
            if (alertDelay != null)
                DismissMessage();

            alertDelay = NSTimer.CreateScheduledTimer(3.5, (obj) => DismissMessage());
            var bounds = UIScreen.MainScreen.Bounds;
            alert = new ToastView(bounds, text);
            UIApplication.SharedApplication.KeyWindow.Add(alert);
        }

        private void DismissMessage()
        {
            if (alert != null)
                alert.Hide();

            if (alertDelay != null)
                alertDelay.Dispose();

            alert = null;
            alertDelay = null;
        }
    }
}
