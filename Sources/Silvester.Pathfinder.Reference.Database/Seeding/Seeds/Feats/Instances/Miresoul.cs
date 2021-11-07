using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Miresoul : Template
    {
        public static readonly Guid ID = Guid.Parse("c033906f-fb67-48a5-b5f4-5cc46f953163");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Miresoul",
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
            yield return new TextBlock { Id = Guid.Parse("505528a3-2d37-422e-a5fa-2972c2d9f738"), Type = TextBlockType.Text, Text = "You have a connection to the muddier denizens of the Plane of Earth from its border with the Plane of Water, and your elemental lineage manifests as clay or mud, reflecting that bond. Your body’s mudlike quality makes it easy for you to compress and squeeze yourself through smaller areas. You gain the trained proficiency rank in Acrobatics. If you would automatically become trained in Acrobatics (from your background or class, for example), you instead become trained in a skill of your choice. You gain the (feat: Quick Squeeze) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5617e376-b38f-4705-9ca5-f96c265f98c8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
