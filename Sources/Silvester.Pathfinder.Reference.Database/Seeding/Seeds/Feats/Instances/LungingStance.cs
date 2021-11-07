using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LungingStance : Template
    {
        public static readonly Guid ID = Guid.Parse("ec5c9da7-73a6-4c19-8d9b-89f6428f6b23");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lunging Stance",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc8bb418-f7ed-47a1-87c4-c4ae934a64cd"), Type = TextBlockType.Text, Text = "Your body coiled to strike, you can lash out at distant enemies." };
            yield return new TextBlock { Id = Guid.Parse("bdd9bc2f-ed98-48fc-b89a-b7d1f47f9c13"), Type = TextBlockType.Text, Text = "While you are in this stance, you can use (Feat: Attack of Opportunity) against a creature that is outside your reach but within the reach you would have with a (Feat: Lunge). If you do, you increase your range with the (Action: Strike) by 5 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("82c8ddb9-2028-4a8c-9d05-b9ad49de39e4"), Feats.Instances.AttackOfOpportunity.ID);
            builder.HaveSpecificFeat(Guid.Parse("a033b25f-c007-4c39-8aab-9a64a5d36db9"), Feats.Instances.Lunge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("700d1049-33f6-4e1f-ab7e-86c71608405f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
