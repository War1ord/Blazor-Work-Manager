namespace WorkManager.Web.Models
{
    using System;

    /// <summary>
    /// The Time Entry
    /// </summary>
    public class TimeEntry
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>Gets or sets the description.</summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>Gets or sets the start date time.</summary>
        /// <value>The start date time.</value>
        public DateTime StartDateTime { get; set; }

        /// <summary>Gets or sets the end date time.</summary>
        /// <value>The end date time.</value>
        public DateTime? EndDateTime { get; set; }
    }
}
