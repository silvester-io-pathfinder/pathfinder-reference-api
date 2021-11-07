using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpassableWallStance : Template
    {
        public static readonly Guid ID = Guid.Parse("f820bdd9-0098-4b40-b132-83571567d89c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impassable Wall Stance",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14d5d7bf-42dc-416c-9a51-81bcf94608d3"), Type = TextBlockType.Text, Text = "~ Access: The following class feat is available to Knights of Lastwall." };
            yield return new TextBlock { Id = Guid.Parse("aef1813b-21a4-4926-8473-53f9aab32e5c"), Type = TextBlockType.Text, Text = "You refuse to let foes past your guard. As long as you are in this stance, when you critically hit with an (feat: Attack of Opportunity) triggered by a (trait: move) action, you disrupt that action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e055148b-9c01-4212-9d23-afd321b9ac64"), Feats.Instances.AttackOfOpportunity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e730333f-e9e5-483f-b36c-3e6f47b76df0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
