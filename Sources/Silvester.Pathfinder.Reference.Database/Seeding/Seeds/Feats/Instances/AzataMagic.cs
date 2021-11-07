using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AzataMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("8ceaa7f9-650e-4327-b919-faed651c9cd6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Azata Magic",
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
            yield return new TextBlock { Id = Guid.Parse("ac44b023-3d32-4010-be82-85fba35e6228"), Type = TextBlockType.Text, Text = "Your lineage traces back to the realm of Elysium, and you can harness its magic using this connection. You can cast (spell: glitterdust) and (spell: remove paralysis) each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5f879934-da43-465f-b843-85b3175527fb"), Feats.Instances.Musetouched.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9340450e-e95b-44b0-bfcd-8457f3a39409"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
