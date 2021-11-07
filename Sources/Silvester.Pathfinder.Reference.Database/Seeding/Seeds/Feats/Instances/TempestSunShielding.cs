using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TempestSunShielding : Template
    {
        public static readonly Guid ID = Guid.Parse("f18fe7ec-66f6-428f-b863-0e4f982900ea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tempest-Sun Shielding",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You or an ally within 30 feet takes damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff8df6bc-a55a-49f4-9682-f1689316ea24"), Type = TextBlockType.Text, Text = "You transform unrealized spell energy into a protective shield. If you’re a spontaneous spellcaster, expend a spell slot; if you’re a prepared spellcaster, expend a spell prepared in a spell slot. Reduce the triggering damage by an amount equal to four times the level of the expended slot or spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0f970009-c705-461f-a319-8f26ddbd121b"), Feats.Instances.TempestSunRedirection.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccf27ab7-5794-41e0-aefc-75fac0842f38"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
