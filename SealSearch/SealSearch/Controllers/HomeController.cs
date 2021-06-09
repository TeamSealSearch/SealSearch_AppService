using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SealSearch.IService;
using SealSearch.Models;

namespace SealSearch.Controllers
{
    public class HomeController : Controller
    {
        ICandidateService _candidateService = null;
        public HomeController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public string SaveFile(FileUpload fileObj)
        {
            Candidate oCandidate = JsonConvert.DeserializeObject<Candidate>(fileObj.Candidate);
            if (fileObj.file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    fileObj.file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    oCandidate.photo = fileBytes;

                    oCandidate = _candidateService.Save(oCandidate);
                    if (oCandidate.userName.Length > 0)
                    {
                        return "Saved";
                    }
                }
            }
            return "Failed";
        }

        [HttpGet]
        public JsonResult GetSavedCandidate()
        {
            var candidate = _candidateService.GetSavedCandidate();
            candidate.photo = this.GetImage(Convert.ToBase64String(candidate.photo));
            return Json(candidate);
        }

        public byte[] GetImage(string sBase64String)
        {
            byte[] bytes = null;
            if (!string.IsNullOrEmpty(sBase64String))
            {
                bytes = Convert.FromBase64String(sBase64String);
            }
            return bytes;
        }
    }
}
