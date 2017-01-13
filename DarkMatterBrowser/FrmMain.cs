using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkMatterBrowser.Classes;
using DarkMatterBrowser.Forms.Browser;
using DarkMatterBrowser.Models;
using WeifenLuo.WinFormsUI.Docking;

namespace DarkMatterBrowser
{
    public partial class FrmMain : Form
    {
        private readonly ThemeManager _themeManager = new ThemeManager();
        private readonly ImageList _themeImageList;

        public FrmMain()
        {
            InitializeComponent();
            _themeImageList = _themeManager.LoadBrowserThemeImageList();
            if (!Directory.Exists(@"C:\LOS\User\Current\Settings\"))
                Directory.CreateDirectory(@"C:\LOS\User\Current\Settings\");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RemoteBrowserSettings.LoadRemoteBrowserSettings();

            if (_themeImageList != null)
            {
                FrmBrowser browser = new FrmBrowser(imageList: _themeImageList);
                browser.Show(dockPanel,DockState.Document);
            }
        }
    }
}
