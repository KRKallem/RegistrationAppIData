using RegistrationUserInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using RegistrationAppIData;


namespace RegistrationUserInterface.Controllers
{

    public class RegistrationController : Controller
    {
        string ServiceUrl = string.Empty;
        public static readonly JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddNewRegistration()
        {

            return View();
        }
        [HttpGet]
        public ActionResult GetuserRegistrationList()
        {
            List<UserDetails> userDetails = null;
            string data = string.Empty;
            ServiceUrl = "UserRegistration/GetUserInfo";
            HttpResponseMessage response = GlovalVariables.WebApiClient.GetAsync(ServiceUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                var resultData = response.Content.ReadAsStringAsync().Result;
                
                var resultContent = jsonSerializer.Deserialize<List<UserDetails>>(resultData);
                data = response.Content.ReadAsStringAsync().Result;

                
            }

            return Json(data, JsonRequestBehavior.AllowGet);


        }


        [HttpPost]
        public ActionResult SaveuserRegistrationDetails(UserDetails Modeldata)
        {

            string res = "";
            var objlstMake = string.Empty;
            var objlstCategory = string.Empty;
            ServiceUrl = "UserRegistration/SaveUserData";
           
            HttpResponseMessage response = GlovalVariables.WebApiClient.PostAsJsonAsync(ServiceUrl, Modeldata).Result;
            if (response.IsSuccessStatusCode)
            {
                return Json("Items Saved Success", JsonRequestBehavior.AllowGet);
            }
            return Json("Items Saving Failed", JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public async Task<JsonResult> DeleteUser(int ID)
        {
            ServiceUrl = "UserRegistration/DeleteUser?ID=" + ID;
            HttpResponseMessage response = GlovalVariables.WebApiClient.GetAsync(ServiceUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var flag = JsonConvert.DeserializeObject<bool>(data);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public async Task<ActionResult> EditUserinfobyID(int ID)
        {

         
            ServiceUrl = "UserRegistration/EditUserInfobyList?ID=" + ID;
            HttpResponseMessage response = GlovalVariables.WebApiClient.GetAsync(ServiceUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var Result = JsonConvert.DeserializeObject<UserDetails>(data);
                return View(Result);
            }
            return Json("", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateuserdetailsByID(UserDetails Modeldata)
        {

            string res = "";
            var objlstMake = string.Empty;
            var objlstCategory = string.Empty;
            ServiceUrl = "UserRegistration/UpdateUserData";

            HttpResponseMessage response = GlovalVariables.WebApiClient.PutAsJsonAsync(ServiceUrl, Modeldata).Result;
            if (response.IsSuccessStatusCode)
            {
                return Json("Items Saved Success", JsonRequestBehavior.AllowGet);
            }
            return Json("Items Saving Failed", JsonRequestBehavior.AllowGet);
        }
               
    }
}