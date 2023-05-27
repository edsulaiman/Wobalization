using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Shared.Entities.Configurations;

public class TranslationKeyConfiguration : IEntityTypeConfiguration<TranslationKey>
{
    public void Configure(EntityTypeBuilder<TranslationKey> builder)
    {
        builder
            .Property(e => e.Id)
            .IsRequired();

        builder
            .Property(e => e.AppId)
            .IsRequired();

        builder
            .Property(e => e.Key)
            .IsRequired();

        builder
            .Property(e => e.CreatedAt)
            .IsRequired();
    }
}