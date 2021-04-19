using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Construct : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait(TraitSeeder seeder)
        {
            return new Trait
            {
                Id = ID,
                Name = "Construct",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A construct is an artificial creature empowered by a force other than necromancy. Constructs are often mindless; they are immune to bleed damage, death effects, disease, healing, necromancy, nonlethal attacks, poison, and the doomed, drained, fatigued, paralyzed, sickened, and unconscious conditions; and they may have Hardness based on the materials used to construct their bodies. Constructs are not living creatures, nor are they undead. When reduced to 0 Hit Points, a construct creature is destroyed." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Bestiary2.ID,
                Page = 346
            };
        }
    }
}
