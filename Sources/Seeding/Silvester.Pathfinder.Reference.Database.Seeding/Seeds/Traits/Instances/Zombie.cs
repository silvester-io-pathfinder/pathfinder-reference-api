using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Zombie : Template
    {
        public static readonly Guid ID = Guid.Parse("605865dd-e4f9-487c-828d-47ee526c8605");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Zombie",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2191f5ae-706e-4079-9660-6d66e29dabe3"), Type = TextBlockType.Text, Text = "These undead are mindless rotting corpses that hunger for living flesh." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5195bcd-0c04-4940-a0d1-fed9328e51ba"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
