using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkullCreeper : Template
    {
        public static readonly Guid ID = Guid.Parse("cc8c79aa-28b8-49f8-88c8-7361c835b8ee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skull Creeper",
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
            yield return new TextBlock { Id = Guid.Parse("ac1e4483-b73d-48ae-bf21-405c1a19c8a4"), Type = TextBlockType.Text, Text = "You wear skulls to demoralize foes. You become trained in Intimidation and gain the (feat: Intimidating Glare) skill feat. If you're already trained in Intimidation, you instead become trained in a skill of your choice. If you pay 50 gp for a splendid (item: skull mask | skull mask splendid), the mask grants you a +1 item bonus to Intimidation; its usage is worn (mask)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcd9cb91-14bc-4021-aaec-b2e51a47b94d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
