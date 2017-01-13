using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkMatterBrowser.Models
{
    class RemoteBrowserSettings
    {
        internal static string DefaultHomePage { get; set; }

        /// <summary>
        /// TODO: Implement This
        /// </summary>
        internal static void LoadRemoteBrowserSettings()
        {
            DefaultHomePage = @"https://duckduckgo.com/";
        }

    }
}
