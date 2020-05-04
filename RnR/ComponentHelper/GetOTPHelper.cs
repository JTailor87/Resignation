using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RnR.ComponentHelper
{
    public static class GetOTPHelper
    {
        public static string GetOtpForUser(string username)
        {
            string url = "https://accesstokenapi-qa.azurewebsites.net/email2sv.txt";
                /*PropertiesCollection.Config.GetTokenDev();*/ 
            //@"https://accesstokenapi-dev.azurewebsites.net/email2sv.txt";
            var wc = new WebClient();
            var textFile = wc.DownloadString(url);
            var lines = textFile.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            var userOtp = lines.Last(x => x.Contains(username));
            return userOtp.Substring(userOtp.LastIndexOf(' ') + 1);
        }
    }
}
