using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalflingLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("c633a090-46b8-4ca8-b6ce-fbf6dab01b25");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halfling Luck",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail a skill check or saving throw.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34e8944e-9833-432c-8e88-fd9a7cb08240"), Type = TextBlockType.Text, Text = "Your happy-go-lucky nature makes it seem like misfortune avoids you, and to an extent, that might even be true. You can reroll the triggering check, but you must use the new result, even if it’s worse than your first roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("139484f9-4c8a-43d0-8464-a96f1adfe35f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
