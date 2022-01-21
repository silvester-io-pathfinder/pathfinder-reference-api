using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Extensions;
using System;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Configurations
{
    public class BaseEntityConfiguration<TEntity> : IEntityConfiguration<TEntity>
        where TEntity : BaseEntity
    {
        public void Configure(ModelBuilder builder)
        {
            builder.Entity<TEntity>();

            Type? highestIncludedParent = typeof(TEntity)
                .GetParents()
                .LastOrDefault(e => IsIncludedInModel(e, builder));

            if(highestIncludedParent == null)
            {
                ConfigureKeyOn(typeof(TEntity), builder);
            }
            else
            {
                ConfigureKeyOn(highestIncludedParent, builder);
            }
        }

        private bool IsIncludedInModel(Type type, ModelBuilder builder)
        {
            return builder
                .Model
                .GetEntityTypes()
                .Any(t => t.ClrType == type);
        }

        private void ConfigureKeyOn(Type entityType, ModelBuilder builder)
        {
            EntityTypeBuilder entityTypeBuilder = builder.Entity(entityType);
            entityTypeBuilder.HasKey(nameof(BaseEntity.Id));
            entityTypeBuilder.Property(nameof(BaseEntity.Id)).ValueGeneratedOnAdd();
        }
    }
}
