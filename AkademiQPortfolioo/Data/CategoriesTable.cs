using System;
using System.Collections.Generic;

namespace AkademiQPortfolioo.Data
{
    public partial class CategoriesTable
    {
        public CategoriesTable()
        {
            ProjectTables = new HashSet<ProjectTable>();
        }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public virtual ICollection<ProjectTable> ProjectTables { get; set; }
    }
}
