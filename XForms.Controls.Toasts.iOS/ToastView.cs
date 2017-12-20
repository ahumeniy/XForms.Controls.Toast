using System;
using System.Drawing;

using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace Xamarin.Forms.Controls.Extras.iOS
{
    [Register("ToastView")]
    public class ToastView : UIView
    {
        UILabel textLabel;

        public ToastView()
        {
            Initialize();
        }

        public ToastView(CGRect frame, string text) : base(frame)
        {
            BackgroundColor = UIColor.Clear;
            AutoresizingMask = UIViewAutoresizing.All;

            nfloat labelHeight = 32;
            nfloat labelWidth = frame.Width - 20;

            nfloat centerX = Frame.Width / 2;
            nfloat centerY = frame.Height - 20;

            nfloat x = 10;
            nfloat y = Frame.Height - labelHeight - 20;

            var posrect = new CGRect(x, y, labelWidth, labelHeight);

            textLabel = new UILabel(posrect);
            textLabel.BackgroundColor = Color.FromHex("#99000000").ToUIColor();
            textLabel.TextAlignment = UITextAlignment.Center;
            textLabel.Font = textLabel.Font.WithSize(12);
            textLabel.AutoresizingMask = UIViewAutoresizing.FlexibleBottomMargin;
            textLabel.Text = text;
            textLabel.TextColor = Color.White.ToUIColor();
            textLabel.Layer.MasksToBounds = true;
            textLabel.Layer.CornerRadius = 10;
            UserInteractionEnabled = false;

            AddSubview(textLabel);
        }

        public void Hide()
        {
            UIView.Animate(0.5, () => { Alpha = 0; }, () => { RemoveFromSuperview(); });
        }

        void Initialize()
        {
        }
    }
}