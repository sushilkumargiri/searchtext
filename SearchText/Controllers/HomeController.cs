using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchText.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public JsonResult searchText(string text, string subtext)
        {
            char[] textArray = text.ToLower().ToArray();
            char[] subTextArray = subtext.ToLower().ToArray();
            string output = "OUTPUT: ";
            for (int i = 0; i < textArray.Length; i++)
            {
                int foundCount = 0;
                for (int j = 0; j < subtext.Length && i+j<textArray.Length; j++)
                {
                    if (textArray[i + j] == subTextArray[j])
                    {
                        foundCount++;
                    }
                }
                if (foundCount == subTextArray.Length)
                {
                    output += i + 1 + ",";
                }
            }
            return Json(output, JsonRequestBehavior.AllowGet);
        }
    }
}
