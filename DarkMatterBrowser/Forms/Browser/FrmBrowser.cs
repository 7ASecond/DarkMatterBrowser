using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using DarkMatterBrowser.Controls.Custom;
using DarkMatterBrowser.Models;
using WeifenLuo.WinFormsUI.Docking;

namespace DarkMatterBrowser.Forms.Browser
{
    public partial class FrmBrowser : DockContent
    {
        public FrmBrowser(ImageList imageList)
        {
            InitializeComponent();
            SuspendLayout();


            BrowserBookmarksControl bookmarksControl = new BrowserBookmarksControl {Dock = DockStyle.Top};
            Controls.Add(bookmarksControl);

            BrowserControlBarControl controlBar = new BrowserControlBarControl(imageList) {Dock = DockStyle.Top};
            Controls.Add(controlBar);

            BrowserStatusBarControl statusBarControl = new BrowserStatusBarControl {Dock = DockStyle.Bottom};
            Controls.Add(statusBarControl);

            ChromiumWebBrowser webBrowser = new ChromiumWebBrowser(RemoteBrowserSettings.DefaultHomePage) { Dock = DockStyle.Fill};
            webBrowser.AddressChanged += WebBrowser_AddressChanged;
            webBrowser.ConsoleMessage += WebBrowser_ConsoleMessage;
            webBrowser.FrameLoadEnd += WebBrowser_FrameLoadEnd;
            webBrowser.FrameLoadStart += WebBrowser_FrameLoadStart;
            webBrowser.IsBrowserInitializedChanged += WebBrowser_IsBrowserInitializedChanged;
            webBrowser.LoadError += WebBrowser_LoadError;
            webBrowser.LoadingStateChanged += WebBrowser_LoadingStateChanged;
            webBrowser.StatusMessage += WebBrowser_StatusMessage;
            webBrowser.TitleChanged += WebBrowser_TitleChanged;

            BrowserSettings browserSettings = new BrowserSettings();
            browserSettings.ImageLoading = CefState.Enabled;
            browserSettings.Databases = CefState.Disabled;
            // browserSettings.DefaultEncoding = "utf-8";
            browserSettings.ApplicationCache = CefState.Disabled;
            //browserSettings.FileAccessFromFileUrls = 
            browserSettings.ImageShrinkStandaloneToFit = CefState.Enabled;
            browserSettings.Javascript = CefState.Enabled;
            browserSettings.JavascriptAccessClipboard = CefState.Disabled;
            browserSettings.JavascriptCloseWindows = CefState.Disabled;
            browserSettings.JavascriptDomPaste = CefState.Disabled;
            browserSettings.JavascriptOpenWindows = CefState.Enabled;
            browserSettings.LocalStorage = CefState.Disabled;
            browserSettings.Plugins = CefState.Disabled;
            browserSettings.RemoteFonts = CefState.Disabled;
            browserSettings.UniversalAccessFromFileUrls = CefState.Disabled;
            browserSettings.WebGl = CefState.Enabled;
            browserSettings.WebSecurity = CefState.Enabled;
            webBrowser.BrowserSettings = browserSettings;


            CefSharpSettings.ShutdownOnExit = true;
          CefSettings cs = new CefSettings();
// cs.CachePath           
            cs.CommandLineArgsDisabled = true;
            cs.IgnoreCertificateErrors = false;
            cs.PackLoadingDisabled = false;
            cs.PersistSessionCookies = false;
            cs.PersistUserPreferences = false;
            cs.UserAgent = @"Mozilla/5.0 (Windows; U; Windows NT 6.1; rv:2.2) Gecko/20110201";
            cs.UserDataPath = @"C:\LOS\User\Current\Settings\";
            Controls.Add(webBrowser);



            ResumeLayout();
        }

        private void WebBrowser_TitleChanged(object sender, CefSharp.TitleChangedEventArgs e)
        {
           // Text = e.Title;
        }

        private void WebBrowser_StatusMessage(object sender, CefSharp.StatusMessageEventArgs e)
        {
            
        }

        private void WebBrowser_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {
           
        }

        private void WebBrowser_LoadError(object sender, CefSharp.LoadErrorEventArgs e)
        {
            
        }

        private void WebBrowser_IsBrowserInitializedChanged(object sender, CefSharp.IsBrowserInitializedChangedEventArgs e)
        {
            
        }

        private void WebBrowser_FrameLoadStart(object sender, CefSharp.FrameLoadStartEventArgs e)
        {
           
        }

        private void WebBrowser_FrameLoadEnd(object sender, CefSharp.FrameLoadEndEventArgs e)
        {
           
        }

        private void WebBrowser_ConsoleMessage(object sender, CefSharp.ConsoleMessageEventArgs e)
        {
            
        }

        private void WebBrowser_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e)
        {
           
        }
    }
}
