using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedWeaponTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("74f58186-0c8d-441b-b10b-f2347d0a0261");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Weapon Training",
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
            yield return new TextBlock { Id = Guid.Parse("360a952b-e3d8-498a-bac6-b83045099338"), Type = TextBlockType.Text, Text = "You’ve studied the art of wielding an advanced weapon. Choose a weapon group. You gain proficiency with all advanced weapons in that group as if they were martial weapons of their weapon group." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7e23f3d-4f15-46dd-8d25-bc76f632d1e8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
