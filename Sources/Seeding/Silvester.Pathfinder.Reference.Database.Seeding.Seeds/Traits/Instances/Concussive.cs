using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Concussive : Template
    {
        public static readonly Guid ID = Guid.Parse("91c87751-19f2-4ffd-b165-6db6154ff900");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Concussive",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c22f4d6-63fa-45e4-ae1b-350096a2deae"), Type = TextBlockType.Text, Text = "These weapons smash as much as puncture. When determining a creature's resistance or immunity to damage from this weapon, use the weaker of the target's resistance or immunity to piercing or bludgeoning. For instance, if the creature were immune to piercing and had no resistance or immunity to bludgeoning damage, it would take full damage from a concussive weapon. Resistance or immunity to all physical damage, or all damage, applies as normal." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("470fca18-9bcf-4f35-8550-113929d351d6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
