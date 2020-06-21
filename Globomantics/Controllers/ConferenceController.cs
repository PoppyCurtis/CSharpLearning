
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;

namespace Globomantics.Controllers
{
    public class ConferenceController : Controller
    {
        public ConferenceController(IConferenceService conferenceService)
        {

        }
    }
}