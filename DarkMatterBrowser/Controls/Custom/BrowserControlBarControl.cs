using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkMatterBrowser.Controls.Custom
{
    public partial class BrowserControlBarControl : UserControl
    {

        private int _currentToolStripWidth = 0;
        private int _currentToolStripHeight = 0;
        private int _currentButtonWidth = 0;
       
        public BrowserControlBarControl(ImageList imageList)
        {
            InitializeComponent();

            _currentToolStripHeight = toolStrip1.Height;
            _currentToolStripWidth = toolStrip1.Width;

            buttonBack.Image = imageList.Images["btnBack"]; 
            buttonForward.Image = imageList.Images["btnForward"];
            buttonRefresh.Image = imageList.Images["btnRefresh"];
            buttonHome.Image = imageList.Images["btnHome"];
            buttonSettings.Image = imageList.Images["btnSettings"];

            _currentButtonWidth = GetButtonWidthTotal();

        }

        /// <summary>
        /// TODO: Also Implement Height Adjustments for URIInputBox and the Buttons.
        /// </summary>
        private void SizeUriInputBox()
        {
            ;
            if (toolStrip1.DisplayRectangle.Width != _currentToolStripWidth)
            {
                _currentToolStripWidth = DisplayRectangle.Width; // Update our values
                var availableSpace = DisplayRectangle.Width - _currentButtonWidth;
                URIInputBox.Width = availableSpace - Margin.Horizontal;
            }           
        }

        private int GetButtonWidthTotal()
        {
            var width = 0;
            foreach (ToolStripItem toolStrip1Control in toolStrip1.Items)
            {
                if (toolStrip1Control.Name.ToLowerInvariant().StartsWith("button"))
                {
                    width += toolStrip1Control.Width;
                    width += toolStrip1Control.Margin.Horizontal;
                }
            }
            return width + 10;
        }

        private void toolStrip1_SizeChanged(object sender, EventArgs e)
        {
            SizeUriInputBox();
            toolStrip1.PerformLayout();
        }

        private void toolStrip1_Resize(object sender, EventArgs e)
        {
            SizeUriInputBox();
            toolStrip1.PerformLayout();
        }
    }
}
