using System;
using System.IO;
using CompanySite.Domain.Entities;
using CompanySite.Domain.Repository;
using CompanySite.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanySite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;

        public ServiceItemsController(DataManager dataManager, IWebHostEnvironment webHostEnvironment)
        {
            this.dataManager = dataManager;
            hostEnvironment = webHostEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var serviceItem = (id == default) ? new ServiceItem() : dataManager.ServiceItems.GetServiceItem(id);
            return View(serviceItem);
        }

        [HttpPost]
        public IActionResult Edit(ServiceItem serviceItem, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    serviceItem.TitleImage = titleImageFile.FileName;
                    using (var fs = new FileStream(Path.Combine(hostEnvironment.WebRootPath, "images/serviceImages/",
                        titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(fs);
                    }

                    dataManager.ServiceItems.SaveServiceItem(serviceItem);
                    return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
                }
            }

            return View(serviceItem);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.ServiceItems.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
