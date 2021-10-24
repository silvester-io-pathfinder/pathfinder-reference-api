using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class HalfElf : Template
    {
        public static readonly Guid ID = Guid.Parse("a3b12707-a7f5-41f0-9f49-f41d1839d5f7");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Half-Elf", 
                Description = "Either one of your parents was an elf, or one or both were half-elves. You have pointed ears and other telltale signs of elf heritage. You gain the elf trait, the half-elf trait, and low-light vision. In addition, you can select elf, half-elf, and human feats whenever you gain an ancestry feat." 
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Human.ID;
            yield return Elf.ID;
        }
    }
}
