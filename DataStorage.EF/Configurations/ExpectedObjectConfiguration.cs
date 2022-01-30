using DataStorage.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataStorage.EF.Configurations
{
    public class ExpectedObjectConfiguration :IEntityTypeConfiguration<ExpectedObject>
    {
        public void Configure(EntityTypeBuilder<ExpectedObject> builder)
        {
            builder.HasKey(e => e.ObjectId);
        }
    }
}
