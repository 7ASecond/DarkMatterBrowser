using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkMatterBrowser.Classes
{
    class ThemeManager
    {
        public ImageList LoadBrowserThemeImageList()
        {
            ImageList imageList = new ImageList {ImageSize = new Size(25, 25)};
            imageList.Images.Add("btnBack", Image.FromFile("themes/Default/back.png"));
            imageList.Images.Add("btnForward", Image.FromFile("themes/Default/forward.png"));
            imageList.Images.Add("btnRefresh", Image.FromFile("themes/Default/refresh.png"));
            imageList.Images.Add("btnHome", Image.FromFile("themes/Default/home.png"));
            imageList.Images.Add("btnSettings", Image.FromFile("themes/Default/settings.png"));
            imageList.Images.Add("btnStop", Image.FromFile("themes/Default/stop.png"));


            return imageList;
        }
    }
}
