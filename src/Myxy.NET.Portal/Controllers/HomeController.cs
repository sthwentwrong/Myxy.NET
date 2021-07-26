using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Myxy.NET.Portal.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;

namespace Myxy.NET.Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> getApi()
        {
            var client = new HttpClient();
            var accessToken = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken);
            if (string.IsNullOrEmpty(accessToken))
            {
                return Json(new { msg = "accesstoken fetch failed." });
            }

            // client.SetBearerToken(accesstoken);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            //var httpResponse = await client.GetAsync("http://localhost:6002/api/identity/GetUserClaims");
            //var result = await httpResponse.Content.ReadAsStringAsync();
            //if (!httpResponse.IsSuccessStatusCode)
            //{
            //    return Json(new { msg = "请求 api1 失败。", error = result });
            //}
            //return Json(new
            //{
            //    msg = "成功",
            //    data = JsonConvert.DeserializeObject(result)
            //});
            var content = await client.GetStringAsync("http://localhost:6002/api/identity/GetUserClaims");

            ViewBag.Json = JArray.Parse(content).ToString();
            return View("json");
        }
    }
}
