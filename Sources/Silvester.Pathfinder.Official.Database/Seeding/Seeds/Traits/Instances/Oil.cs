using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Oil : Template
    {
        public static readonly Guid ID = Guid.Parse("449de570-dc89-488e-9b56-415dcb96ed40");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Oil",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("52e4b93a-b726-44a8-aec3-e762131e9dcb"), Type = TextBlockType.Text, Text = "Oils are magical gels, ointments, pastes, or salves that are typically applied to an object and are used up in the process." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb9d6685-54a5-4bcb-bde6-55e621a18fbd"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
