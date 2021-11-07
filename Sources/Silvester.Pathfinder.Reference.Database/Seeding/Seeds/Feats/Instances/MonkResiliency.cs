using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonkResiliency : Template
    {
        public static readonly Guid ID = Guid.Parse("5d6a72f8-73e5-43a1-82e4-b1f54ec1ef9c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monk Resiliency",
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
            yield return new TextBlock { Id = Guid.Parse("2a956a5f-0fd4-4a1a-8e52-f0c9707d582b"), Type = TextBlockType.Text, Text = "You gain 3 additional Hit Points for each monk archetype class feat you have. As you continue selecting monk archetype class feats, you continue to gain additional Hit Points in this way." };
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
                Id = Guid.Parse("a87f156e-ad81-4397-aa0b-bf4565bb655e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
