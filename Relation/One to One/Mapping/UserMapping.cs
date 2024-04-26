using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Relation.One_to_One.Mapping
{
    public class UserMapping:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(x => x.BankAccount)
                .WithOne(x => x.User);
        }
    }
}
