using System;
using System.Collections.Generic;

namespace AkademiQPortfolioo.Data
{
    public partial class AboutTable
    {
        public int AboutId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Education { get; set; }
        public string? EducationTitle { get; set; }
        public string? EducationDescription { get; set; }
        public string? Awards { get; set; }
        public string? AwardsTitle { get; set; }
        public string? AwardsDecription { get; set; }
    }
}
