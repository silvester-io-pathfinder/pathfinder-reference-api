using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReboundingToss : Template
    {
        public static readonly Guid ID = Guid.Parse("4c913ab9-fdbc-4333-80da-0bf2caea9adb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rebounding Toss",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e9d5759-538f-44c1-85df-3f61be56c9b6"), Type = TextBlockType.Text, Text = "You bounce your weapon off one foe to strike another. Make a ranged (action: Strike) with a thrown weapon. If this (action: Strike) hits, the weapon rebounds toward an enemy within 10 feet of the original target. Make an additional (action: Strike) against this second target. Both attacks count toward your multiple attack penalty, but the penalty doesn’t increase until after you’ve made both attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0f0adea-ba70-48ce-aa74-1b1fcd3355bc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
