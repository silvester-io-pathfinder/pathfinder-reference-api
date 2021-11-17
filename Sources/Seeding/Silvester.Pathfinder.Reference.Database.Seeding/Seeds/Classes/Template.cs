using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes
{
    public abstract class Template : EntityTemplate<Class>
    {
        protected override Class GetEntity(ISeedBuilder builder)
        {
            Class @class = GetClass();

            builder.AddJoinData<Class, Stat>(@class, GetKeyAbilities());

            foreach (ClassMannerism mannerism in GetMannerisms())
            {
                mannerism.ClassId = @class.Id;
                builder.AddData(mannerism);
            }

            foreach (ClassCharacteristic characteristic in GetCharacteristics())
            {
                characteristic.ClassId = @class.Id;
                builder.AddData(characteristic);
            }

            SeedClassFeaturesUsingReflection(builder, @class);

            return @class;
        }

        private void SeedClassFeaturesUsingReflection(ISeedBuilder builder, Class @class)
        {
            Type classFeatureNamespaceType = GetClassFeaturesNamespace();
            IEnumerable<Type> classFeatureTypes = classFeatureNamespaceType
                .GetType()
                .Assembly
                .GetTypes()
                .Where(e => classFeatureNamespaceType.Namespace!.Equals(e.Namespace, StringComparison.OrdinalIgnoreCase));


            foreach (Type classFeatureType in classFeatureTypes)
            {
                FieldInfo idField = classFeatureType.GetField(nameof(ClassFeatures.Swashbucklers.AbilityBoosts.ID), BindingFlags.Public | BindingFlags.Static | BindingFlags.GetField)!;
                Guid classFeatureId = (Guid) idField.GetValue(null)!;
                builder.AddData(new ClassFeatureBinding { Id = classFeatureId, ClassFeatureId = classFeatureId, ClassId = @class.Id });
            }
        }

        protected abstract Class GetClass();
        protected abstract IEnumerable<Guid> GetKeyAbilities();
        protected abstract Type GetClassFeaturesNamespace();

        protected abstract IEnumerable<ClassMannerism> GetMannerisms();
        protected abstract IEnumerable<ClassCharacteristic> GetCharacteristics();
    }
}
