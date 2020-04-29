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
            postData = "login=" + login + "&password=" + password;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            user def = new user(); def.sex = 3;
            try
            {
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                using (dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    if (responseFromServer == "0") return def;
                    List<user> result = JsonConvert.DeserializeObject<List<user>>(responseFromServer);
                    return result[0];
                }
                response.Close();
            }
            catch (System.Net.WebException e) {
                def.sex = 404;return def;
            };
            return def;
        }
    }
}
