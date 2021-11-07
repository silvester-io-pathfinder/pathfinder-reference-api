using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResoundingFinale : Template
    {
        public static readonly Guid ID = Guid.Parse("1dc1b7e9-7371-4ee9-a795-1a806b1096cd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resounding Finale",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You or an ally benefiting from your composition spell would take sonic damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f03c3317-bf5a-4d25-86e3-979b5b69987f"), Type = TextBlockType.Text, Text = "You bring your performance to a sudden, dramatic finish, drowning out other sounds. Your composition spell ends immediately, and all allies that had been benefiting from the spell’s effects gain sonic resistance against the triggering damage equal to twice the composition spell’s level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("1450aea9-1b9c-47ce-aa89-16f51a387914"), Muses.Instances.Maestro.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59675f39-e781-4519-ac6c-7d7a0016b1c1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
