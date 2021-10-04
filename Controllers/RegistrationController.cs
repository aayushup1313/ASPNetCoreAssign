using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreAssign.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult SignUpUser()
        {
            CityDropDown(); 
            return View();
        }

        [HttpPost]
        public IActionResult SignUpUser(Models.RegistrationModel model)
        {
            if (ModelState.IsValid)
            {

                if (Convert.ToInt32(model.City.ToString()) == 0)
                {
                    ModelState.AddModelError("", "Please Select City");
                }
                else
                {

                    ViewBag.Message = "User information successfully submitted.";

                }
               
            }
            CityDropDown();

            return View();
        }

        private void CityDropDown()
        {

            List<SelectListItem> cities = new()
            {
                new SelectListItem { Value = "1", Text = "Atlanta" },
                new SelectListItem { Value = "2", Text = "Duluth" },
                new SelectListItem { Value = "3", Text = "Gwinnette" },
                new SelectListItem { Value = "4", Text = "Fulton" },
               

            };
            //assigning SelectListItem to view Bag
            cities.Insert(0, (new SelectListItem { Text = "Select City", Value = "0" }));
            ViewBag.cities = cities;
        }


    }
}
