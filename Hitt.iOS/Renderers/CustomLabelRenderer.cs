using System;
using System.ComponentModel;
using Foundation;
using Hitt.iOS.Renderers;
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

                if(customLabel.Selectable)
                {
                    Control.UserInteractionEnabled = true;
                    Control.AddGestureRecognizer(new UILongPressGestureRecognizer(() =>
                  {
                      var menuContr = UIMenuController.SharedMenuController;
                      if (menuContr.MenuVisible)
                          return;
                      BecomeFirstResponder();
                      menuContr.SetTargetRect(this.Frame, this.Superview);
                      menuContr.SetMenuVisible(true, true);
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

            //if (customLabel.Underline && !string.IsNullOrEmpty(customLabel.Text))
            //    Control.AttributedText = new NSMutableAttributedString (customLabel.Text, underlineStyle: NSUnderlineStyle.Single);

            //var role = (Element as CustomLabel).Role;
            //switch(role)
            //{
            //    case Forms.Common.Resources.LabelRoleType.Button;
            //}
        }
        public CustomLabelRenderer()
        {
        }
    }
}
