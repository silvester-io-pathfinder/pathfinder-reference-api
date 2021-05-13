using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Bulwark : Template
    {
        public static readonly Guid ID = Guid.Parse("78a8fe42-f559-4386-af44-cc49e8525378");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Bulwark",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be5a0147-c65d-4b4b-a89e-0ed0ba4d03a0"), Type = TextBlockType.Text, Text = "The armor covers you so completely that it provides benefits against some damaging effects. On Reflex saves to avoid a damaging effect, such as a fireball, you add a +3 modifier instead of your Dexterity modifier." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13ce22a6-e6eb-4f45-bf4f-61c9370ee424"),
                SourceId = CoreRulebook.ID,
                Page = 274
            };
        }
    }
}
