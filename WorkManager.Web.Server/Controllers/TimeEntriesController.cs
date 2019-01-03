namespace WorkManager.Web.Server.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    using WorkManager.Web.Models;

    [Route("api/[controller]")]
    public class TimeEntriesController : Controller
    {
        [HttpGet]
        public IEnumerable<TimeEntry> GetTimeEntries()
        {
            return Enumerable
                .Range(1, 20)
                .Select(index => new TimeEntry
                {
                    Description = $"Test Time Entry {index}",
                    StartDateTime = DateTime.Now.Date.AddDays(index),
                    EndDateTime = DateTime.Now.Date.AddDays(index),
                    Id = Guid.NewGuid().ToString(),
                })
                .ToArray();
        }
    }
}
