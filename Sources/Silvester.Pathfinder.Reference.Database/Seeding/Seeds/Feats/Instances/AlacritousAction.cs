using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlacritousAction : Template
    {
        public static readonly Guid ID = Guid.Parse("bbc9d568-692b-4e0b-b02b-9e5de36d31eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alacritous Action",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60dfa970-f574-4e17-81c2-e059bc3cd6a8"), Type = TextBlockType.Text, Text = "Your eidolon moves more quickly. It gains a +10-foot status bonus to its Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8c48e79-e68f-4431-b7ce-59921217cec8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
