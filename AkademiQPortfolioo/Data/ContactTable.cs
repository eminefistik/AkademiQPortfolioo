using System;
using System.Collections.Generic;

namespace AkademiQPortfolioo.Data
{
    public partial class ContactTable
    {
        public int ContactId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? İcon { get; set; }
        public string? Adress { get; set; }
        public string? Message { get; set; }
    }
}
