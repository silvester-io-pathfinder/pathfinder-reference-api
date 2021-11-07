using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellDevourer : Template
    {
        public static readonly Guid ID = Guid.Parse("b1675e67-9aac-4906-8632-1538254b5417");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spell Devourer",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e89a4cdf-69b1-4c2a-b1bf-80c1f4452291"), Type = TextBlockType.Text, Text = "You don&#39;t just resist magic; you devour it. Whenever you succeed at a saving throw against a spell or magical effect, you gain temporary Hit Points equal to double the spell&#39;s level, or equal to the level if the magical effect isn&#39;t a spell. These temporary Hit Points last until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cb015ff1-4edd-4ff6-a4ae-b7629575148c"), Feats.Instances.PervasiveSuperstition.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c6ef0c1-2d35-4811-8f59-f6eab4fb561d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
