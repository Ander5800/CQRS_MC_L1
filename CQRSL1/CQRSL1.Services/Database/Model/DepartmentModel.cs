using CQRSL1.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace CQRSL1.Services
{
    public class DepartmentModel : EntityTypeConfiguration<Department>
    {
        public DepartmentModel()
        {
            this.ToTable("departments");
        }
    }
}
