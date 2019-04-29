using CQRSL1.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace CQRSL1.Services
{
    public class TeacherModel : EntityTypeConfiguration<Teacher>
    {
        public TeacherModel()
        {
            this.ToTable("teachers");

            this.Property(t => t.Address.PostalAddress).HasColumnName("address");
            this.Property(t => t.Address.City).HasColumnName("city");
            this.Property(t => t.Address.State).HasColumnName("state");
            this.Property(t => t.Address.PostalCode).HasColumnName("postalCode");
        }
    }
}
