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
    public class BloodInTheAir : Template
    {
        public static readonly Guid ID = Guid.Parse("979c8c0a-f7a3-4e67-a76b-303ac7a6ca1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blood in the Air",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f83e1342-21a1-46ab-83b4-b3e5e01d4220"), Type = TextBlockType.Text, Text = $"Once you've locked on to a target, little can obscure your aim. Make a ranged weapon {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the required target. This {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} ignores the target's concealed condition and reduces the flat check for the hidden condition from 11 to 5." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("be19a390-23fd-4edd-b607-4469bf3c4228"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("f7a10b9d-1ff4-43ac-91d9-10ca31469ea1"), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("546367f9-f220-461e-8108-5239f8f4e6fc"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
