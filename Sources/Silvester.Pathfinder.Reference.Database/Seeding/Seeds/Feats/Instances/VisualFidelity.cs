using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VisualFidelity : Template
    {
        public static readonly Guid ID = Guid.Parse("e979eed6-d522-48f6-afc3-4e3cf796f2f3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Visual Fidelity",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a02ac201-707e-4487-8265-5455177888ae"), Type = TextBlockType.Text, Text = "You’ve found a way to use a hodgepodge combination of devices to enhance your visual abilities in every situation. You gain darkvision and low-light vision, and you can see invisible creatures and objects as translucent shapes, though these shapes are indistinct enough to be concealed to you." };
            yield return new TextBlock { Id = Guid.Parse("13d21b35-45ef-4516-978b-5df00ab1002b"), Type = TextBlockType.Text, Text = "If an effect would give you the blinded condition, the effect must attempt a counteract check against your class DC, with your counteract level equaling half your level, rounded up. On a failed counteract check, you aren’t blinded—your various devices are able to compensate." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("890dc81c-5f51-4500-9020-c047db0fca17"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
