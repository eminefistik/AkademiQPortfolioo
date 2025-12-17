using System;
using System.Collections.Generic;

namespace AkademiQPortfolioo.Data
{
    public partial class ExperienceTable
    {
        public int ExperienceId { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public string? DescriptionTitle { get; set; }
        public string? Year { get; set; }

        public string? Icon { get; set; }
    }
}
