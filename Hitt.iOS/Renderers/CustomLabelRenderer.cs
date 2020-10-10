using System;
using System.ComponentModel;
using Foundation;
using Hitt.iOS.Renderers;
using Hitt.Navigation;
using Hitt.UserControls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace Hitt.iOS.Renderers
{
    public class CustomLabelRenderer : LabelRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if(Control == null) { return; }

            if(e.NewElement != null)
            {
                var customLabel = e.NewElement as CustomLabel;

                //if(customLabel.Selectable)
                //{
                //  //  Control.UserInteractionEnabled = true;
                //  //  Control.AddGestureRecognizer(new UILongPressGestureRecognizer(() =>
                //  //{
                //  //    if (Control.TextColor == Color.LightGray.ToUIColor())
                //  //    {
                //  //        Control.TextColor = Color.Black.ToUIColor();
                //  //    }
                //  //    else
                //  //    {
                //  //        Control.TextColor = Color.LightGray.ToUIColor();
                //  //    }
                //  //}));
                //}
                if(customLabel.Selectable)
                {
                    Control.UserInteractionEnabled = true;
                    Control.AddGestureRecognizer(new UITapGestureRecognizer(() =>
                    {
                        Control.Layer.BackgroundColor = Color.Red.ToCGColor();
                    }));

                   
                }
            }
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if(Control == null)  return;
            var customLabel = sender as CustomLabel;
            if(Control == null)
            {
                return;
            }
        }
        public CustomLabelRenderer()
        {
        }
    }
}
