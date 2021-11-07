using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinWeakness : Template
    {
        public static readonly Guid ID = Guid.Parse("bd0f938e-fa6f-4d17-934c-69441084e452");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Weakness",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a88a0c89-663e-4c87-8c44-eade43a5bb20"), Type = TextBlockType.Text, Text = "As you make an attack augmented by your esoterica, you also press your implement against the creature to apply its weakness. Make a melee (action: Strike) against the subject of your (feat: Esoteric Antithesis). On any attack roll result but a critical failure, you also press your implement against the creature, applying its weakness from (feat: Esoteric Antithesis). This is in addition to any damage from your (action: Strike), including the weakness it applies. This counts as two attacks when calculating your multiple attack penalty." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dbf756f8-8652-4e6a-9641-24a4bec4cb6b"), Feats.Instances.EsotericAntithesis.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87e370cb-f975-4a28-af7e-74d20e2450bf"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
