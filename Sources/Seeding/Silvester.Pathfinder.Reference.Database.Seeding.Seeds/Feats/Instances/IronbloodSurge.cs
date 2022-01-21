using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IronbloodSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("5e74ed31-df13-448d-bc08-1886348d4710");

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
            yield return new TextBlock { Id = Guid.Parse("aa179a5b-34d9-47cf-92f8-b65838d7a178"), Type = TextBlockType.Text, Text = "You steel yourself, preparing to resist oncoming attacks and using your muscles to absorb the impact. You gain the benefits of your iron sweep's (trait: parry) trait (a +1 circumstance bonus to AC until the start of your next turn) and your resistance from (feat: Ironblood Stance) increases to your Strength modifier (if it's higher) for the same duration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0b75cf6e-8b73-48dc-93f4-f13d8a517e3f"), Feats.Instances.IronbloodStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c05e2c60-bc37-480e-81f3-b36763ff55d3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
