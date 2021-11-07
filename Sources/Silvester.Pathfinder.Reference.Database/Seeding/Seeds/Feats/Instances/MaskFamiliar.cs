using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaskFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("7aab848d-df35-4a09-9a41-15ddc1e7fdb1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mask Familiar",
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
            yield return new TextBlock { Id = Guid.Parse("9b0eb9f8-1716-4a67-b92e-f063bda1a25d"), Type = TextBlockType.Text, Text = "Your mask takes on a personality of its own, allowing it to serve as your familiar. Though you can still wear it as a mask, you can detach it from your face to grant it a bodily form of colored light that allows it to move around; usually, this is a miniature form of the animal the mask represents. Detaching or reattaching the familiar to transform it is a two-action activity. Even in mask form, the familiar can move around on its master’s face and speaks in a distinct voice (if it can talk). It is easily recognized as more than a simple mask unless the familiar succeeds at a Deception check to (action: Impersonate) a mask. Other than its appearance and the fact that it can be worn, it functions as other familiars. Your mask familiar has access to the mask freeze familiar ability." };
            yield return new TextBlock { Id = Guid.Parse("f4fedb2a-cd53-43fb-a342-a41925a0cfd5"), Type = TextBlockType.Text, Text = "~ Mask Freeze:: When in mask form, your familiar can hide its obvious supernatural qualities to pass as a simple, unassuming mask. It doesn’t need to (action: Impersonate) to fool a passing glance, and it gains a +4 circumstance bonus to its Deception DC against an active observer (action: Seeking | Seek) or otherwise studying it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("06596f74-ed8b-4795-a877-9c6b32d86aab"), Feats.Instances.MagaambyanAttendantDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b2ef260-5894-41c5-90a5-50faf9033c04"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
