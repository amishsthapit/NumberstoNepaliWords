using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NumberstoNepaliWords.Models;

namespace NumberstoNepaliWords.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Index()
        {
            ConversionModel obj = new ConversionModel();
            obj.Number = 1;
            obj.NumberNepali = "चौध";
            return View(obj);
        }

        [HttpPost]
        public IActionResult Index(ConversionModel obj)
        {
            obj.NumberNepali = NumbertoNepaliWord.Class1.NepaliConversion(obj.Number);
            return View(obj);
        }
    }
}