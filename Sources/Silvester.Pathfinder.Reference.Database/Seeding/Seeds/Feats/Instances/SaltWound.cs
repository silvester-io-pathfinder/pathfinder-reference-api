using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SaltWound : Template
    {
        public static readonly Guid ID = Guid.Parse("ce67bbee-d9fc-4900-8f1e-0a920becb3e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Salt Wound",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature that has blood and is not at its maximum Hit Points hits you with a melee Strike.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd7ed21c-cefa-4420-9878-8284fc981e90"), Type = TextBlockType.Text, Text = "You channel salt and brine from your blood into the creature’s wounds. The creature must attempt a Fortitude save using your class DC or spell DC, whichever is higher. On a failure, the creature takes 1d6 persistent acid damage and is sickened 1 by the pain. On a critical failure, it instead takes 2d6 persistent acid damage and is sickened 2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4d273c0-4211-4f90-a294-18ab5453ec23"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
