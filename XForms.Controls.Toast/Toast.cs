using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.Controls.Extras
{
    public static class Toast
    {
        static IToastProvider implementation;

        static IToastProvider GetImplementation()
        {
            if (implementation == null)
                implementation = Xamarin.Forms.DependencyService.Get<IToastProvider>();

            return implementation;
        }

        public static void MakeText(string text)
        {
            var _implementarion = GetImplementation();
            if (_implementarion == null)
                throw new NotImplementedException();

            _implementarion.MakeText(text);
        }
    }
}
