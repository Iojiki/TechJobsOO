using System;
using System.Collections.Generic;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        // View title
        public string Title { get; set; } = "";

        // All columns, for display
        public List<JobFieldType> Columns { get; set; }

        // Populate the list of all columns

        public BaseViewModel()
        {
            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }

        }

    }
    
}
