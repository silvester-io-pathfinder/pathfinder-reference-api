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
    public class HealingTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("ca44b850-3efe-4d5d-9596-ee043c1361bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Healing Transformation",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9507b9a6-b8d7-4367-a89d-fc41e3832234"), Type = TextBlockType.Text, Text = $"You can take advantage of shapechanging magic to close wounds and patch injuries. If your next action is to cast a non-cantrip {ToMarkdownLink<Models.Entities.Trait>("polymorph", Traits.Instances.Polymorph.ID)} spell that targets only one creature, your polymorph spell also restores 1d6 Hit Points per spell level to that creature. This is a {ToMarkdownLink<Models.Entities.Trait>("healing", Traits.Instances.Healing.ID)} effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7fc58a8a-7e0f-469d-96b7-0d63c7b315a6"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("0d8861af-0878-4873-ab3f-52814e623f24"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fbb09bf2-9e68-4aa8-ada0-fa072ddc247b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
