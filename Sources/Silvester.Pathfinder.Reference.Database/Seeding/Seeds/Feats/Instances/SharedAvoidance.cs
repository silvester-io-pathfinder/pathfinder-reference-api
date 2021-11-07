using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedAvoidance : Template
    {
        public static readonly Guid ID = Guid.Parse("0ab8fe2d-1ff5-4c0b-8794-86c8b468cc99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Avoidance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("777bcdaf-2ff4-47c6-be9b-009cec268bb0"), Type = TextBlockType.Text, Text = "You can project your premonitions of danger to your allies. When you use (feat: Premonition of Avoidance), allies within 15 feet of you who are rolling the same saving throw against the same hazard also gain a +2 circumstance bonus to their saving throws." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("29d9b924-3ccd-4ce6-9555-9652bce70303"), Feats.Instances.PremonitionOfAvoidance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c6e7478-002e-4550-9eb4-9c463c2dde27"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
