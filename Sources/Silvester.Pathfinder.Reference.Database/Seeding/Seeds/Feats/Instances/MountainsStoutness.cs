using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MountainsStoutness : Template
    {
        public static readonly Guid ID = Guid.Parse("1bdf18b3-5aa9-47a3-aa57-34ff9c101731");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mountain's Stoutness",
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
            yield return new TextBlock { Id = Guid.Parse("e8752d39-f3d1-4f02-aeee-38a70839f8cb"), Type = TextBlockType.Text, Text = "Your hardiness lets you withstand more punishment than most before going down. Increase your maximum Hit Points by your level. When you have the dying condition, the DC of your recovery checks is equal to 9 + your dying value (instead of 10 + your dying value)." };
            yield return new TextBlock { Id = Guid.Parse("af04b360-1a37-4289-acea-a4df0d369836"), Type = TextBlockType.Text, Text = "If you also have the (feat: Toughness) feat, the Hit Points gained from it and this feat are cumulative, and the DC of your recovery checks is equal to 6 + your dying value." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95a40b3e-7fdd-4f34-a437-ccfe15eaba33"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
