using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FamiliarMasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("210f3d58-9e26-4026-9119-4bae80feeb34");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Familiar Master Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the familiar master archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06e04ea8-2f46-4c31-af4f-f7d22348a1df"), Type = TextBlockType.Text, Text = "You have forged a mystical bond with a creature. This might have involved complex rituals and invocations, such as meditating under the moon until something crept out of the forest. Or maybe you just did each other a good turn, such as rescuing the beast from a trap or a foe, and then being rescued in turn. Whatever the details, you are now comrades until the end. You gain a familiar (page 198). If you already have a familiar, you gain the (feat: Enhanced Familiar) feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa0f4aec-1053-4c13-8a0e-9d4a40d3ecc1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
