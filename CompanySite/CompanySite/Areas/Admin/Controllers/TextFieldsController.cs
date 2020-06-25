using CompanySite.Domain.Entities;
using CompanySite.Domain.Repository;
using CompanySite.Services;
using Microsoft.AspNetCore.Mvc;

namespace CompanySite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;

        public TextFieldsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Edit(string codeWord)
        {
            var textField = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
            return View(textField);
        }

        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid)
            {
                dataManager.TextFields.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }

            return View(model);
        }
    }
}
