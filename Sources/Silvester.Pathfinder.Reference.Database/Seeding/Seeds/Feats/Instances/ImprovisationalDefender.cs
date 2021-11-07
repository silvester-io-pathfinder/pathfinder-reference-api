using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovisationalDefender : Template
    {
        public static readonly Guid ID = Guid.Parse("4392c2d9-0652-43ce-802b-66c0163784f8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improvisational Defender",
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
            yield return new TextBlock { Id = Guid.Parse("077bf8f4-9366-4726-9bb5-6df4396a4f6d"), Type = TextBlockType.Text, Text = "You are always prepared for fights that frequently disrupt seemingly peaceful times. When you use an improvised weapon or a shoddy weapon, you don’t take the -2 item penalty to attack rolls." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f7a27fd-509b-421e-8900-c9cdf07e3f1a"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
