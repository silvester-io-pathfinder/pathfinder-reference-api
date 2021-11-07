using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedKnockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("5c3ad104-5559-4f3d-bf31-760492761498");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Knockdown",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd985e1e-174f-4820-8f74-1fc9ff729039"), Type = TextBlockType.Text, Text = "You can dash your foe to the ground with a single blow. When you use (feat: Knockdown), instead of making a (action: Strike) followed by a (action: Trip), you can attempt a single (action: Strike). If you do and your (action: Strike) hits, you also apply the critical success effect of a (action: Trip). If you used a two-handed melee weapon for the (action: Strike), you can use the weapon’s damage die size instead of the regular die size for the damage from a critical (action: Trip)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fe920063-c45c-4d22-a526-08735aa5546f"), Feats.Instances.Knockdown.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c214ea79-245e-4aac-ab60-106fe2fe6870"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
