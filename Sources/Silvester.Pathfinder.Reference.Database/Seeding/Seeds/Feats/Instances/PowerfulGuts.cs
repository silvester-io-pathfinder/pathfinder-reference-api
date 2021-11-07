using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PowerfulGuts : Template
    {
        public static readonly Guid ID = Guid.Parse("b33fe0a2-8986-463f-ae82-a5788a3a376e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Powerful Guts",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7169624d-da0e-4727-8e02-f74ad8979008"), Type = TextBlockType.Text, Text = "Your stomach is particularly durable. When you succeed at a Fortitude save to reduce your sickened value, you reduce it by 2 (or by 3 on a critical success)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f13a0e79-4949-4704-8ee1-423278d85a07"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
