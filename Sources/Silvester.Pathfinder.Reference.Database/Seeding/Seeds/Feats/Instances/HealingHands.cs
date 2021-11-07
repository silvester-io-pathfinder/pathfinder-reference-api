using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealingHands : Template
    {
        public static readonly Guid ID = Guid.Parse("331f27b5-6c1a-48d9-b0d7-377924c4f5a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Healing Hands",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21bf5e11-1197-4978-afdd-8eec5394d918"), Type = TextBlockType.Text, Text = "Your positive energy is even more vibrant and restorative. When you cast (spell: heal), you roll d10s instead of d8s." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("f75dc0db-b181-4445-a104-098d57b0dd5f"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9ad29bd-0535-43b4-8e94-db71bb4effa5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
