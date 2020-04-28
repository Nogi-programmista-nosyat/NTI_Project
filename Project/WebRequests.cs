using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace window3
{
    class WebRequests
    {
        System.Net.WebRequest request;
        string postData;
        int permissionLevel = 0;
        
        public WebRequests()
        {
        }
        public user login(string login, string password)
        {
            request = WebRequest.Create("http://nogy.onlinehacktomsk.ru/login.php");
            postData = "login="+ login + "&password=" + password;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            using (dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                List<user> result = JsonConvert.DeserializeObject<List<user>>(responseFromServer);
                foreach (user us in result) { return us; }
            }
            response.Close();user def = new user();
            return def;
        }
    }
}
