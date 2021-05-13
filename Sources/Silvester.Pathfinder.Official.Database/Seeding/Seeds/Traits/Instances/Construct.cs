using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Construct : Template
    {
        public static readonly Guid ID = Guid.Parse("261df933-0961-4973-a77a-09d708186f88");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Construct",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1b6b421-acaf-4ae3-a5cd-f5863183ac05"), Type = TextBlockType.Text, Text = "A construct is an artificial creature empowered by a force other than necromancy. Constructs are often mindless; they are immune to bleed damage, death effects, disease, healing, necromancy, nonlethal attacks, poison, and the doomed, drained, fatigued, paralyzed, sickened, and unconscious conditions; and they may have Hardness based on the materials used to construct their bodies. Constructs are not living creatures, nor are they undead. When reduced to 0 Hit Points, a construct creature is destroyed." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed165c70-d25c-4813-ba64-addc7d59843b"),
                SourceId = Bestiary2.ID,
                Page = 346
            };
        }
    }
}
