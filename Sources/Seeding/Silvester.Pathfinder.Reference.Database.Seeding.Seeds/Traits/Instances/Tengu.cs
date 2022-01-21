using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Tengu : Template
    {
        public static readonly Guid ID = Guid.Parse("9c1ee79b-60f9-453a-9a8a-bfa60ee51196");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Tengu",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("371481c2-afb7-40f2-8e9e-a83ffa574466"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the tengu ancestry. Tengus are humanoids who resemble birds. An ability with this trait can be used or selected only by tengus. An item with this trait is created and used by tengus." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56f5e3d7-67bd-437b-8224-ed33f0d81291"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 270
            };
        }
    }
}
