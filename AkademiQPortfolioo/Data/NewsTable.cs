using System;
using System.Collections.Generic;

namespace AkademiQPortfolioo.Data
{
    public partial class NewsTable
    {
        public int NewsId { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public DateTime? Date { get; set; }
        public string? DescriptionTitle { get; set; }
        public string? Description { get; set; }
    }
}
