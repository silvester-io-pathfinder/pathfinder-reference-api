using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlackCatCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("f61fd1b1-3ff5-48b0-a428-f2b42d206832");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Black Cat Curse",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within 30 feet you can see would succeed at a save.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1361c916-3b0a-4df0-a60d-1c347fba50d8"), Type = TextBlockType.Text, Text = "You hiss a spiteful curse at the creature. The target must reroll the triggering saving throw and use the worse result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee5372eb-cf9d-428b-a69d-782f27392cf3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
