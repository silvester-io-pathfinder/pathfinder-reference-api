using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BarbarianResiliency : Template
    {
        public static readonly Guid ID = Guid.Parse("c4ecdb68-e454-465b-83b0-2b25225560ba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Barbarian Resiliency",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c24ee667-0937-4e72-9f7a-3ddfc4924cc2"), Type = TextBlockType.Text, Text = "You gain 3 additional Hit Points for each barbarian archetype class feat you have. As you continue selecting barbarian archetype class feats, you continue to gain additional Hit Points in this way." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ae53211-7934-4785-9114-5d4b01af5857"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
