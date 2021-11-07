using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodlettingFangs : Template
    {
        public static readonly Guid ID = Guid.Parse("fbeacb16-6a34-4766-8057-5596136a3e61");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bloodletting Fangs",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0494988f-c388-428f-a926-c12a86ee8f4e"), Type = TextBlockType.Text, Text = "You emulate your vampiric parent&#39;s techniques for drawing blood from a victim. Your fangs (action: Strikes | Strike) deal an additional 1d4 persistent bleed damage on a critical hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificUnarmedAttack(Guid.Parse("7aeda62d-2ade-47e3-8395-8c9ff3869a6a"), UnarmedAttack.Fangs);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd8a6cc9-d9d3-4055-845e-11b7302a0754"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
