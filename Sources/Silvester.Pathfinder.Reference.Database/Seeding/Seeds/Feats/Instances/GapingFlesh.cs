using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GapingFlesh : Template
    {
        public static readonly Guid ID = Guid.Parse("7cfb097d-9785-40fb-8ad3-52cc9765d534");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gaping Flesh",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature you are aware of damages you with a melee Strike.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f563bfe2-c8a6-4c7b-8ac7-c23563ebe9e9"), Type = TextBlockType.Text, Text = "Your wound yawns open, appalling your attacker. The attacker must succeed at a Fortitude saving throw against your class DC or spell DC, whichever is higher, or become sickened 1 (sickened 2 on a critical failure). It can’t recover from the sickened condition while it’s adjacent to you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15f39998-f049-4c89-8455-6ebd27adddc2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
