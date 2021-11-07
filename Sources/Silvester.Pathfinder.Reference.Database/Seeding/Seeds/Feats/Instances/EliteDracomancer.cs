using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EliteDracomancer : Template
    {
        public static readonly Guid ID = Guid.Parse("a57fcfea-f331-4fa8-9bad-3f9063230d07");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elite Dracomancer",
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
            yield return new TextBlock { Id = Guid.Parse("9b99336b-24ca-4536-94c0-f8ecc61a0d67"), Type = TextBlockType.Text, Text = "Your magic rivals that of lesser dragons. Choose one 3rd-level spell and one 4th-level spell from those listed for a dragon spellcaster of your draconic exemplar&#39;s type (such as (spell: paralyze) and (spell: stinking cloud) for a black dragon exemplar). You can cast each of these spells once per day as arcane innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("512c7226-9b26-4fbd-997b-f4ac173c8b9d"), Feats.Instances.Dracomancer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea1f310b-d955-4d44-9b57-d6e0d3e8336a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
