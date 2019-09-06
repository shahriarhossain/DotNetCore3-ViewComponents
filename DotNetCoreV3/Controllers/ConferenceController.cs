using DotNetCoreV3.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotNetCoreV3.Controllers
{
    [Route("[Controller]")]
    public class ConferenceController : Controller
    {
        private readonly IConferenceService _conferenceService;

        public ConferenceController(IConferenceService conferenceService)
        {
            _conferenceService = conferenceService;
        }

        [Route("Index2")]
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Conference List";
            var x = await _conferenceService.GetAll();
            return View(x);
        }
    }
}
