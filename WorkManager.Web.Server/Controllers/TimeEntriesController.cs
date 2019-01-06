namespace WorkManager.Web.Server.Controllers
{
    using System;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    using WorkManager.Web.Models;

    [Route("api/[controller]")]
    public class TimeEntriesController : Controller
    {
        [HttpGet]
        public IActionResult GetTimeEntries()
        {
            var now = DateTime.Now;
            var results = Enumerable
                .Range(1, 20)
                .Select(index => new TimeEntry
                {
                    Description = $"Test Time Entry {index}",
                    StartDateTime = now.Date.AddDays(index),
                    EndDateTime = now.Date.AddDays(index),
                    Id = Guid.NewGuid().ToString(),
                })
                .ToList();
            results.Add(new TimeEntry
            {
                Description = "Current time entry",
                StartDateTime = now.AddHours(-2),
                Id = Guid.NewGuid().ToString(),
            });

            if (results == null || results.Count < 1)
            {
                return this.NotFound();
            }
            return this.Ok(results.ToArray());
        }
    }
}
