using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore
{
    public partial class BrowserInfo : System.Web.UI.Page
    {
        [Obsolete]
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sbText = new StringBuilder();
            // Get the reference to the HttpBrowserCapabilities object 
            HttpBrowserCapabilities browser = Request.Browser;
            // Display the properties of the HttpBrowserCapabilities Class
            sbText.AppendFormat("Browser : " + browser.Browser + "<br>");
            sbText.AppendFormat("Browser Version: " + browser.Version + "<br>");
            sbText.AppendFormat("Client's Platform: " + browser.Platform + "<br>");
            sbText.AppendFormat(".NET CLR Version: " + browser.ClrVersion + "<br>");
            sbText.AppendFormat("ECMA Script Version: " + browser.EcmaScriptVersion + "<br>");
            sbText.AppendFormat("JavaScript Support: " + browser.JavaScript + "<br>");
            sbText.AppendFormat("Microsoft HTML Document Object Model Version: " + browser.MSDomVersion + "<br>");
            sbText.AppendFormat("World Wide Web (W3C) XML Document " + " Object Model Version: " + browser.W3CDomVersion + "<br>");
            Label1.Text = sbText.ToString();

            StringBuilder sbText2 = new StringBuilder();
            HttpBrowserCapabilities browser2 = BusinessLayer.Page.GetBrowserInfo();
            DropDownList1.Items.Add("Browser : " + browser2.Browser);
            DropDownList1.Items.Add("Browser Version: " + browser2.Version);
            DropDownList1.Items.Add("Client's Platform: " + browser2.Platform);
            DropDownList1.Items.Add(".NET CLR Version: " + browser2.ClrVersion);
            DropDownList1.Items.Add("ECMA Script Version: " + browser2.EcmaScriptVersion);
            DropDownList1.Items.Add("JavaScript Support: " + browser2.JavaScript);
            DropDownList1.Items.Add("Microsoft HTML Document Object Model Version: " + browser2.MSDomVersion);
            DropDownList1.Items.Add("World Wide Web (W3C) XML Document " + " Object Model Version: " + browser2.W3CDomVersion);
        }
    }
}