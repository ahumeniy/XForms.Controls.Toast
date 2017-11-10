using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(Xamarin.Forms.Controls.Extras.Droid.ToastProvider))]
namespace Xamarin.Forms.Controls.Extras.Droid
{
    public class ToastProvider : IToastProvider
    {
        static global::Android.Content.Context _context;

        public static void SetContext(global::Android.Content.Context context) => _context = context;

        public void MakeText(string text)
        {
            var length = global::Android.Widget.ToastLength.Long;
            var toast = global::Android.Widget.Toast.MakeText(_context, text, length);
            toast.Show();
        }
    }
}
