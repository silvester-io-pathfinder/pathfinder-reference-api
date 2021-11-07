using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AmbushingKnockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("8f8b5cbf-abe9-4f42-ae26-8e822dd44ee1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ambushing Knockdown",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07170519-e4ec-4293-8f71-750f4561f19b"), Type = TextBlockType.Text, Text = "~ Access: Side with the Washboard Dogs in the gang conflict." };
            yield return new TextBlock { Id = Guid.Parse("b1673472-6445-404b-8b95-250cdd649b23"), Type = TextBlockType.Text, Text = "You emerge from hiding and deliver a blow that can knock an enemy sprawling to the ground. You (action: Stride) up to half your Speed, but you must end your movement next to a foe you&#39;re hidden from or undetected by. You then (action: Strike) that enemy with the required weapon; if you hit, the target is knocked prone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("2f4e9e80-68c0-43e0-8b46-9223d6360893"), Rackets.Instances.Ruffian.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ef4d4fd-2d4b-475f-be49-74527792bd12"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
