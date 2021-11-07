using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallOfElysium : Template
    {
        public static readonly Guid ID = Guid.Parse("97455e63-a607-406b-ac9f-77a42c592dab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call of Elysium",
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
            yield return new TextBlock { Id = Guid.Parse("2d98129e-8e77-4e50-8ba2-d14c8da4e16f"), Type = TextBlockType.Text, Text = "The wild wonder of Elysium harmonizes within you, and in dire straits, you can share its benefits with your allies. Your Speed increases by 5 feet; the Speed increase from this feat isn’t cumulative with any Speed increase from your ancestry feats (such as (feat: Nimble Elf)). Allies who begin their turn in combat adjacent to you gain a +5-foot status bonus to their Speed for the round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6ce7f16a-dfc8-46b5-a1e9-763d1628bd06"), Feats.Instances.Musetouched.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0dd47f0a-f20c-42b2-9618-8f2cb16b1274"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
