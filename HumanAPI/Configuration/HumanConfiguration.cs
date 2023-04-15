using HumanAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanAPI.Configuration
{
    public class HumanConfiguration : IEntityTypeConfiguration<HumanModel>
    {
        public void Configure(EntityTypeBuilder<HumanModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.FirstName).HasColumnName("firstName").IsRequired();
            builder.Property(x => x.LastName).HasColumnName("lastName").IsRequired();
            builder.Property(x => x.Age).HasColumnName("age").IsRequired();
            builder.Property(x => x.Sex).HasColumnName("sex").IsRequired();
            builder.Property(x => x.FamilyStatus).HasColumnName("familyStatus").IsRequired();
            builder.Property(x => x.Company).HasColumnName("company").IsRequired();
            builder.Property(x => x.DateRegistration).HasColumnName("dateRegistration").IsRequired();
            builder.Property(x => x.BirthDate).HasColumnName("birthDate").IsRequired();
        }
    }
}

