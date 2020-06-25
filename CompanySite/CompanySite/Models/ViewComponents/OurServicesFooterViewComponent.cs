using CompanySite.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CompanySite.Models.ViewComponents
{
    public class OurServicesFooterViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public OurServicesFooterViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult) View("Default", dataManager.ServiceItems.GetServiceItems()));
        }
    }
}
