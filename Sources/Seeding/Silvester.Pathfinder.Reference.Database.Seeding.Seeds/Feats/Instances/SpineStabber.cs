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
    public class SpineStabber : Template
    {
        public static readonly Guid ID = Guid.Parse("7770d638-3dc6-49b3-af0b-8ba474c6f59b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spine Stabber",
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
            yield return new TextBlock { Id = Guid.Parse("ba01d14e-c563-44cf-8e80-14cb0e00d7f5"), Type = TextBlockType.Text, Text = $"The quills on your arms are particularly sharp and sturdy. You gain a quills unarmed attack that deals 1d6 piercing damage. Your quills are in the knife weapon group and have the {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} and {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} traits." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e163054-3a2b-4632-b359-fe206bd3c029"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
