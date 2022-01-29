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
    public class ElfAtavism : Template
    {
        public static readonly Guid ID = Guid.Parse("ad839b46-7286-4c48-9f15-77d4c8bbb3d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elf Atavism",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can take this feat only at 1st level, and you can't retrain out of this feat or into this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b42bf1e-f37c-4597-97ab-1b6bf79b7495"), Type = TextBlockType.Text, Text = $"Your elven blood runs particularly strong, granting you features far more elven than those of a typical half-elf. You may also have been raised among elves, steeped in your elven ancestors' heritage. You gain the benefits of the elf heritage of your elven parent or ancestors. You typically can't select a heritage that depends on or improves an elven feature you don't have. For example, you couldn't gain the cavern elf's darkvision ability if you didn't have low-light vision. In these cases, at the GM's discretion, you might gain a different benefit." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.HalfElf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c1f4860-af3e-4f1c-a1d8-ad356b0a9c00"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
