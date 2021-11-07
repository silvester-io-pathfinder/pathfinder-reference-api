using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OldSoul : Template
    {
        public static readonly Guid ID = Guid.Parse("b1a22faf-b15a-4775-8596-b9efb18ee314");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Old Soul",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0549e703-ea33-4526-80ba-ad71d75ec9c4"), Type = TextBlockType.Text, Text = "Your immortal lineage has granted you a lifespan much longer than most mortals, and you’ve learned a lot along the way. You become trained in two skills of your choice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAge(Guid.Parse("fd91839f-24c1-4347-b178-77a16ab82ff3"), Comparators.GreaterThanOrEqualTo, years: 100);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82a8b7d2-1f82-4624-a15b-dff0277db5ed"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
