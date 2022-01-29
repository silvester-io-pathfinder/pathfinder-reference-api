using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShrinkDown : Template
    {
        public static readonly Guid ID = Guid.Parse("0dbc08d3-a0bb-4fbc-8fd1-1867c52158fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shrink Down",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a65751e9-eb53-4c03-906b-c09b507ed885"), Type = TextBlockType.Text, Text = $"Your eidolon can shrink to fit into small spaces. Your eidolon reduces in size, to a minimum of size Small. It can use this action again while shrunk to return to its normal size." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("dcf1927c-048c-459d-a331-8c211246e1ae"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("13c21c9d-36ab-4b33-b45d-3de8eb977491"), Traits.Instances.Eidolon.ID);
            builder.Add(Guid.Parse("60deea70-aa52-4926-a188-3e31a3a14375"), Traits.Instances.Evolution.ID);
            builder.Add(Guid.Parse("90b4aa19-c379-4ed5-84af-aaa2a7095506"), Traits.Instances.Summoner.ID);
            builder.Add(Guid.Parse("f8764ab5-96e1-447b-b2ea-b17fba47d87a"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22a274f3-2f47-40b4-ba30-c26a81ad0266"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
