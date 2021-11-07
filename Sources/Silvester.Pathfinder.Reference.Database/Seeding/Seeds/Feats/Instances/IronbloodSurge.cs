using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IronbloodSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("bde0917b-a945-426c-b492-2fc47a0f1558");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ironblood Surge",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f13f197d-c460-4202-a4a1-18070f49e34f"), Type = TextBlockType.Text, Text = "You steel yourself, preparing to resist oncoming attacks and using your muscles to absorb the impact. You gain the benefits of your iron sweep’s (trait: parry) trait (a +1 circumstance bonus to AC until the start of your next turn) and your resistance from (feat: Ironblood Stance) increases to your Strength modifier (if it’s higher) for the same duration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a5b0b17e-7d93-45b7-9612-de8b5e41fb8f"), Feats.Instances.IronbloodStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61806ec1-f1ca-42a4-b459-cbd7c7d9cadb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
