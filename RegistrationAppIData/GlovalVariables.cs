using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;

namespace RegistrationUserInterface
{
    public class GlovalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

        static GlovalVariables()
        {
            string AppKey = ConfigurationManager.AppSettings["BaseURL"].ToString().Trim();
            WebApiClient.BaseAddress = new Uri(AppKey);
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}