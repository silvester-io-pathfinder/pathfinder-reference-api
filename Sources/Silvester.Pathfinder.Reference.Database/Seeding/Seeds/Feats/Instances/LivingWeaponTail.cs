using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingWeaponTail : Template
    {
        public static readonly Guid ID = Guid.Parse("d2639690-cd86-4710-b70f-bc57ae0f8af2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Living Weapon - Tail",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4271b98b-a3ff-45b7-98c2-0eb3ea38150d"), Type = TextBlockType.Text, Text = "You gain a tail unarmed attack that deals 1d6 bludgeoning damage and has the (trait: backswing) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9aaae3b3-83d8-47c0-8317-d054a7c83fef"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
