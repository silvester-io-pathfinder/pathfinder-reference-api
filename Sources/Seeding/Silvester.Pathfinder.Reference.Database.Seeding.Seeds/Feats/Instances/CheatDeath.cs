using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CheatDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("5bdcfc3d-45d1-4ca1-9e58-44213b49506e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cheat Death",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You take damage that would reduce you to 0 Hit Points.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ebfe3ead-534e-4645-8586-c10a9b2147b2"), Type = TextBlockType.Text, Text = $"Somehow you always escape the reaper by a hair's breadth. You avoid being knocked out or killed and remain at 1 Hit Point, but you become doomed 1 (or increase your doomed value by 1 if you were already doomed). You can't reduce or ignore the doomed condition from Cheating Death. The doomed condition from Cheating Death lasts for 10 minutes, though this doesn't affect the duration of any other doomed condition you have." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("458e7903-857d-4e80-978e-6dba0c1ba2a4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
