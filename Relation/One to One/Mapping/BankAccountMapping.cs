using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Relation.One_to_One.Mapping
{
    public class BankAccountMapping : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.Property(x => x.AccountNumber).HasMaxLength(16);

            builder.HasOne(x => x.User)
                .WithOne(x => x.BankAccount)
                .HasForeignKey<BankAccount>(x => x.UserId);
        }
    }
}
