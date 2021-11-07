using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FighterResiliency : Template
    {
        public static readonly Guid ID = Guid.Parse("a9e0a617-df62-4d3f-b9b0-d7205cdedff9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fighter Resiliency",
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
            yield return new TextBlock { Id = Guid.Parse("b2070a72-ee4c-44a6-a6c4-2cb4fadb5eca"), Type = TextBlockType.Text, Text = "You gain 3 additional Hit Points for each fighter archetype class feat you have. As you continue selecting fighter archetype class feats, you continue to gain additional Hit Points in this way." };
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
                Id = Guid.Parse("b4de28b8-f8c0-4a80-8f25-766056a89ebb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
