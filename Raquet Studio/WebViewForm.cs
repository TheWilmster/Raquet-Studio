using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Raquet_Studio
{
    public partial class WebViewForm : Form
    {
        public WebViewForm(string url)
        {
            InitializeComponent();
            InitSite(url);
        }

        async void InitSite(string url)
        {
            await WebView.EnsureCoreWebView2Async(null);
            WebView.Source = new Uri(url);
            WebView.CoreWebView2.NewWindowRequested += NewWindowRequestedOverride;
        }

        public WebView2 GetView()
        {
            return WebView;
        }

        private void NewWindowRequestedOverride(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            new Border98(new WebViewForm(e.Uri));
            e.Handled = true;
        }
    }
}
