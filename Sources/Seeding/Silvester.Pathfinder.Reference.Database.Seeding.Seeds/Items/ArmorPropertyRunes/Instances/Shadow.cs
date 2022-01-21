using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.ArmorPropertyRunes.Instances
{
    public class Shadow : Template
    {
        public static readonly Guid ID = Guid.Parse("5bbaaa06-0e1b-4418-acd3-8b16548ac945");

        public static readonly Guid STANDARD_ID = Guid.Parse("de50faa8-b8e8-42c3-8599-5364a5e14508");
        public static readonly Guid GREATER_ID = Guid.Parse("e98665b6-0191-4089-a300-05b800d482d7");
        public static readonly Guid MAJOR_ID = Guid.Parse("74d3a787-2cf5-4833-a7c6-26c700233510");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Shadow",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f9c96673-ed3c-491c-96e1-52de805aefdc"), "Armor with this rune becomes hazy black.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Shadow",
                Usage = "Etched onto light or medium nonmetallic armor.",
                Level = 5,
                Price = 5500,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("04edee5a-92fd-4b7d-9e18-641c230efb65"), "You gain a +1 item bonus to Stealth checks while wearing the armor.")
					.Build(),
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Shadow (Greater)",
                Usage = "Etched onto light or medium nonmetallic armor.",
                Level = 9,
                Price = 65000,
                PotencyId = Potencies.Instances.Greater.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("0c356a31-b815-4d1e-9a34-9b6e376c6de3"), "You gain a +2 item bonus to Stealth checks while wearing the armor.")
					.Build(),
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = MAJOR_ID, 
                Name = "Shadow (Major)",
                Usage = "Etched onto light or medium nonmetallic armor.",
                Level = 17,
                Price = 1400000,
                PotencyId = Potencies.Instances.Major.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("80265164-7d3c-4b82-ad03-11d0a29b624e"), "You gain a +3 item bonus to Stealth checks while wearing the armor.")
					.Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("90ee3c65-dc3c-4bc5-8f16-b295e67a4036"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("8b4e0d87-0f23-4936-b5e8-7c81ad1fa7cf"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d3bb1bb-092d-4e4e-8ef7-3bcb435cff87"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
