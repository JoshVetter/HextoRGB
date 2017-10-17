using System;

using UIKit;

namespace HextoRGB
{
    public partial class ViewController : UIViewController
    {
        

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            Newbutton.TouchUpInside+= Newbutton_TouchUpInside;
        }

        void Newbutton_TouchUpInside(object sender, EventArgs e)
        {
			string hexValue = HexValueTextField.Text;
			string redHexValue = hexValue.Substring(0, 2);
			string greenHexValue = hexValue.Substring(2, 2);
			string blueHexValue = hexValue.Substring(4, 2);

			int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
			int greenValue = int.Parse(greenHexValue, System.Globalization.NumberStyles.HexNumber);
			int blueValue = int.Parse(blueHexValue, System.Globalization.NumberStyles.HexNumber);

			RedValueLabel.Text = redValue.ToString();
			GreenValueLabel.Text = greenValue.ToString();
			BlueValueLabel.Text = blueValue.ToString();
        }   
     



			
        








        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
