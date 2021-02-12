using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class ClassSeeder : IEntitySeeder<Class>
    {
        public IEnumerable<Class> GetSeedEntities()
        {
            yield return new Class { Id = Guid.Parse("df6b0137-7082-470f-939f-5d241ef7d651"), Name = "Alchemist", BaseHealth  = 8};
            yield return new Class { Id = Guid.Parse("a171edb5-59c0-4468-b710-a6b9df2f4497"), Name = "Barbarian", BaseHealth  = 12};
            yield return new Class { Id = Guid.Parse("9c08f598-a180-4a59-984a-a26a67607054"), Name = "Bard", BaseHealth  = 8};
            yield return new Class { Id = Guid.Parse("3f3362c2-09a1-47da-8945-cea25e313f80"), Name = "Champion", BaseHealth  = 10};
            yield return new Class { Id = Guid.Parse("f7cb4156-4ec7-4c78-bd28-4db83a0f5ade"), Name = "Cleric", BaseHealth  = 8};
            yield return new Class { Id = Guid.Parse("73f7051c-8eff-4337-a87c-183deb7a998c"), Name = "Druid", BaseHealth  = 8};
            yield return new Class { Id = Guid.Parse("9cace213-82ff-4751-a438-8afd87d433e4"), Name = "Fighter", BaseHealth  = 10};
            yield return new Class { Id = Guid.Parse("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91"), Name = "Monk", BaseHealth  = 10};
            yield return new Class { Id = Guid.Parse("ceb15fca-8288-456e-9769-98cce79bb104"), Name = "Ranger", BaseHealth  = 10};
            yield return new Class { Id = Guid.Parse("4087e406-d324-45af-b9b9-9adf0283a17c"), Name = "Rogue", BaseHealth  = 8};
            yield return new Class { Id = Guid.Parse("05d42777-0744-4a72-85ad-d27186c96deb"), Name = "Sorcerer", BaseHealth  = 6};
            yield return new Class { Id = Guid.Parse("0e53c45a-9ab8-4d4a-bb5b-51af257c56bc"), Name = "Wizard", BaseHealth  = 6};
            yield return new Class { Id = Guid.Parse("2483fb2b-b7cc-4eab-9c4e-0118477e46ed"), Name = "Investigator", BaseHealth  = 8};
            yield return new Class { Id = Guid.Parse("bc25beea-18e8-4417-8ada-a0f58bc79585"), Name = "Oracle", BaseHealth  = 8};
            yield return new Class { Id = Guid.Parse("deb62736-af71-4600-bd4b-59e55961b74d"), Name = "Swashbuckler", BaseHealth  = 10};
            yield return new Class { Id = Guid.Parse("de966e73-2c40-40b4-956f-57e326f7ce8e"), Name = "Witch", BaseHealth  = 6};
        }
    }
}
