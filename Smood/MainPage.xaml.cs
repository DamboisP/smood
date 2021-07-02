using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Smood
{
    public partial class MainPage : ContentPage
    {
        private readonly Dictionary<ImageButton, string> _buttonColors;

        public MainPage()
        {
            InitializeComponent();
            // Initializing clicked button colors
            _buttonColors = new Dictionary<ImageButton, string>
            {
                { btn_very_nok, "#F58982" },
                { btn_nok, "#F59E98" },
                { btn_neutral, "#F4F3D6" },
                { btn_ok, "#CFF7D5" },
                { btn_very_ok, "#B0FFBC" }
            };
        }

        public void HandleClick(object sender, EventArgs e)
        {
            var button = (ImageButton)sender;

            // Resetting the background color of other buttons
            foreach (var kvp in _buttonColors)
                if (kvp.Key != button)
                    kvp.Key.BackgroundColor = default(Color);

            if (button.BackgroundColor == default(Color))
                button.BackgroundColor = Color.FromHex(_buttonColors[button]);
            else
                button.BackgroundColor = default(Color);
        }
    }
}
