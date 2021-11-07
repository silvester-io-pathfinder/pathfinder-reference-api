using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallOfElysium : Template
    {
        public static readonly Guid ID = Guid.Parse("dff4b085-c776-43cb-9314-46991835a8e1");

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
            yield return new TextBlock { Id = Guid.Parse("51e0b71a-3a63-4abd-9881-cdd9727a6c95"), Type = TextBlockType.Text, Text = "The wild wonder of Elysium harmonizes within you, and in dire straits, you can share its benefits with your allies. Your Speed increases by 5 feet; the Speed increase from this feat isn’t cumulative with any Speed increase from your ancestry feats (such as (feat: Nimble Elf)). Allies who begin their turn in combat adjacent to you gain a +5-foot status bonus to their Speed for the round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f2132cd3-25c4-4861-9ccb-fab3d7169143"), Feats.Instances.MuseTouched.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65092107-aa7e-4a20-81b1-2dc5882c0b2b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
