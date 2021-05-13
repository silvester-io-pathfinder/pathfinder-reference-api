using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes
{
    public abstract class Template : EntityTemplate<Class>
    {
        protected override Class GetEntity(ModelBuilder builder)
        {
            Class @class = GetClass();

            foreach(Guid statId in GetKeyAbilities())
            {
                builder.HasJoinData<Stat, Class>((statId, @class.Id));
            }

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

            /*foreach (ClassFeature feature in GetFeatures(seeder))
            {
                feature.ClassId = @class.Id;
                builder.AddData(feature);
            }*/

            return @class;
        }

        protected abstract Class GetClass();
        protected abstract IEnumerable<Guid> GetKeyAbilities();

        protected abstract IEnumerable<ClassMannerism> GetMannerisms();
        protected abstract IEnumerable<ClassCharacteristic> GetCharacteristics();
        //protected abstract IEnumerable<ClassFeature> GetFeatures(ClassSeeder seeder);
    }
}
