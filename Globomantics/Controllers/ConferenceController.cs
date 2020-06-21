using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Globomantics.Controllers
{
    public class ConferenceController : Controller
    {
        public ConferenceController(IConferenceService conferenceService)
        {

        }
    }
}
