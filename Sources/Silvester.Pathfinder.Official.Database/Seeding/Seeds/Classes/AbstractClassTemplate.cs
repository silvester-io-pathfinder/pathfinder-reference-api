using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes
{
    public abstract class AbstractClassTemplate
    {
        public void Seed(ClassSeeder seeder)
        {
            Class @class = GetClass(seeder);

            foreach(Stat stat in GetKeyAbilities(seeder))
            {
                seeder.Builder.HasJoinData((@class, stat));
            }

            foreach (ClassMannerism mannerism in GetMannerisms(seeder))
            {
                mannerism.ClassId = @class.Id;
                seeder.Builder.AddData(mannerism);
            }

            foreach (ClassCharacteristic characteristic in GetCharacteristics(seeder))
            {
                characteristic.ClassId = @class.Id;
                seeder.Builder.AddData(characteristic);
            }

            /*foreach (ClassFeature feature in GetFeatures(seeder))
            {
                feature.ClassId = @class.Id;
                seeder.Builder.AddData(feature);
            }*/

            seeder.Builder.AddData(@class);
        }

        protected abstract Class GetClass(ClassSeeder seeder);
        protected abstract IEnumerable<Stat> GetKeyAbilities(ClassSeeder seeder);

        protected abstract IEnumerable<ClassMannerism> GetMannerisms(ClassSeeder seeder);
        protected abstract IEnumerable<ClassCharacteristic> GetCharacteristics(ClassSeeder seeder);
        //protected abstract IEnumerable<ClassFeature> GetFeatures(ClassSeeder seeder);
    }
}
