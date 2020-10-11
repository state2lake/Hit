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

                
                    Control.UserInteractionEnabled = true;
                    Control.AddGestureRecognizer(new UITapGestureRecognizer(() =>
                    {
                        // Control.Layer.BackgroundColor = Color.Red.ToCGColor();
                         customLabel.TranslateTo(-100, 0, 1000);    // Move image left
                         customLabel.TranslateTo(-100, -100, 1000); // Move image up <- you are looking for this one
                         customLabel.TranslateTo(100, 100, 2000);   // Move image diagonally down and right
                         customLabel.TranslateTo(0, 100, 1000);     // Move image left
                         customLabel.TranslateTo(0, 0, 1000);       // Move image up
                    }));
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
