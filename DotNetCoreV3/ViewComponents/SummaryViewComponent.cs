using DotNetCoreV3.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotNetCoreV3.ViewComponents
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly IConferenceService conferenceService;

        public SummaryViewComponent(IConferenceService conferenceService)
        {
            this.conferenceService = conferenceService;
        }

        //Use this overload when you don't need to pass any parameter
        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    return View(await conferenceService.GetSummary());
        //}

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            ViewBag.ComponentId = id;
            return View(await conferenceService.GetSummary());
        }
    }
}
