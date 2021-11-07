using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrategicBypass : Template
    {
        public static readonly Guid ID = Guid.Parse("273e0f67-39aa-4b89-9c5c-c3391f0b29dd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strategic Bypass",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8110bd6-9e82-47ed-b885-db545d03df78"), Type = TextBlockType.Text, Text = "Your plans account for your foes&#39; resistances, enabling you to strike a telling blow. When you hit with a (action: Strike) on which you substituted your attack roll due to (feat: Devising a Stratagem | Devise a Stratagem), you ignore an amount of resistance equal to your Intelligence modifier for each resistance that applies against your attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c067dd3-eb67-4e09-b6c1-8742b90f1e56"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
