using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LieDetector : Template
    {
        public static readonly Guid ID = Guid.Parse("f52854f2-1057-4061-b524-9a820cde41b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lie Detector",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d9b3c5e2-b813-4103-8c22-e6dad62d0667"), Type = TextBlockType.Text, Text = "You&#39;re adept at noticing the tells of a liar – sweat, flushing, a quavering voice, a quickening pulse. You gain a +1 circumstance bonus to Perception checks to (action: Sense Motive) and to Perception DCs against attempts to (action: Lie) to you. When you determine someone is lying to you, you can use their deceit to your advantage to gain a +1 circumstance bonus to the next Deception, Diplomacy, Intimidation, or Performance check you attempt against that creature within the next minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("eecb1059-8be0-4ce5-b6d2-f5ebc10d6987"), or => 
            {
                or.HaveSpecificMethodology(Guid.Parse("fa41e90d-5a31-4742-a46d-e43ccd078d96"), Methodologies.Instances.Empiricism.ID);
                or.HaveSpecificMethodology(Guid.Parse("afdbbe7c-ab3e-46d8-8c00-36920705fffc"), Methodologies.Instances.Interrogation.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea7619a6-1607-480d-90ed-88a06d70ecf5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
