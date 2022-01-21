using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Silvester.Pathfinder.Reference.Database.Extensions;
using System;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Configurations
{
    public class OwnedPropertyConfiguration<TEntity> : IEntityConfiguration<TEntity>
        where TEntity : BaseEntity
    {
        public void Configure(ModelBuilder builder)
        {
            EntityTypeBuilder<TEntity> entity = builder.Entity<TEntity>();
            foreach (PropertyInfo property in typeof(TEntity).GetProperties())
            {
                if (property.PropertyType.IsOwnedEntity())
                {
                    entity.OwnsOne(property.PropertyType, property.Name, accessor =>
                    {
                        accessor.HasKey(nameof(IOwnedEntity.OwnerId));
                        accessor.Property(nameof(BaseEntity.Id)).ValueGeneratedOnAdd();
                        accessor.Property<Guid>(nameof(IOwnedEntity.OwnerId)).ValueGeneratedOnAdd();
                        accessor.WithOwner().HasForeignKey(nameof(IOwnedEntity.OwnerId));
                    });
                }
                else if (property.PropertyType.IsOwnedEntityCollection())
                {
                    Type actualEntityType = property.PropertyType.GetGenericArguments()[0];
                    entity.OwnsMany(actualEntityType, property.Name, accessor =>
                    {
                        accessor.HasKey(nameof(BaseEntity.Id));
                        accessor.Property(nameof(BaseEntity.Id)).ValueGeneratedOnAdd();
                        accessor.Property<Guid>(nameof(IOwnedEntity.OwnerId)).ValueGeneratedOnAdd();
                        accessor.WithOwner().HasForeignKey(nameof(IOwnedEntity.OwnerId));
                    });
                }
            }
        }
    }
}
