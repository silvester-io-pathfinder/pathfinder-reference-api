using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeroicPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("f5795794-ddfe-473d-9b64-13536955112f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heroic Presence",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3cd0893b-2dc2-4a04-a17d-3377828a754d"), Type = TextBlockType.Text, Text = "The blood of heroes courses through your veins, and you inspire your allies to dig deep and find a new level of resolve. You grant up to 10 willing creatures within 30 feet the effects of a 6th-level (spell: zealous conviction), though the effect automatically ends on a target if you give that target a command they would normally find repugnant. This action has the (trait: auditory) trait or (trait: visual) trait, depending on how you inspire your allies." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ce774b9-d07c-4a8c-8e1d-3198fbf85438"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
