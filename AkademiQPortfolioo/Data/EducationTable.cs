using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AkademiQPortfolioo.Data
{
    public class EducationTable
    {
       
        [Key] public int EducationId { get; set; }
        public string? EducationName { get; set; }
        public string? EducationYear { get; set; }
        public string? EducatIcon { get; set; }
        public string? EducationDescription { get; set; }
  

    }
}
