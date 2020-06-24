using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globomantics.ViewComponents
{
    public class StatisticsViewComponent : ViewComponent
    {
        private readonly IConferenceService service;

        public StatisticsViewComponent(IConferenceService service)
        {
            this.service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync (string statsCaption)
        {
            ViewBag.Caption = statsCaption;
            return View(await service.GetStatistics());
        }
    }
}
