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
    public class Fumesoul : Template
    {
        public static readonly Guid ID = Guid.Parse("385b8990-86c7-433c-bc23-c8b3dbcc4abf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fumesoul",
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
            yield return new TextBlock { Id = Guid.Parse("58ff9bda-d596-478d-8e88-a0fc1cdecc31"), Type = TextBlockType.Text, Text = $"The air inside you asserts itself as a toxic miasma, inuring you to most poisons. You gain resistance to poison equal to half your level (minimum 1)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("15d9d34f-8b53-4684-bbbe-24c25c39dc2b"), Traits.Instances.Lineage.ID);
            builder.Add(Guid.Parse("aeabb4a7-9b32-4317-bd58-510c280dbe33"), Traits.Instances.Sylph.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a78b4da-e08f-4af5-804b-f09915e92564"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
