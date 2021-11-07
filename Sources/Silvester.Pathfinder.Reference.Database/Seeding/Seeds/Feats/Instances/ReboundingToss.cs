using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReboundingToss : Template
    {
        public static readonly Guid ID = Guid.Parse("a40c8cd8-f4e2-47c1-8668-64eb75f5d21a");

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
            yield return new TextBlock { Id = Guid.Parse("eb99fb84-9056-4518-ad2b-140805a30f0a"), Type = TextBlockType.Text, Text = "You bounce your weapon off one foe to strike another. Make a ranged (action: Strike) with a thrown weapon. If this (action: Strike) hits, the weapon rebounds toward an enemy within 10 feet of the original target. Make an additional (action: Strike) against this second target. Both attacks count toward your multiple attack penalty, but the penalty doesn’t increase until after you’ve made both attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3d73e17-28fa-45e4-a630-9736feb14d93"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
