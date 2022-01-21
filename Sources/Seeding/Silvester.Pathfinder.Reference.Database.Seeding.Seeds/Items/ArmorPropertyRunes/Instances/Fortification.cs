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
    public class Fortification : Template
    {
        public static readonly Guid ID = Guid.Parse("010de771-6941-4a89-a142-c369c9fbdbd2");

        public static readonly Guid STANDARD_ID = Guid.Parse("b34ac828-abc6-4fdd-a309-78d87ea92417");
        public static readonly Guid GREATER_ID = Guid.Parse("94dfd0a1-3b85-4515-98f5-838b4071e110");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Fortification",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0e0f934f-3816-48c9-8ece-1e2da97d197a"), "A fortification rune wards against the most deadly attacks.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = STANDARD_ID, 
                Name = "Fortification",
                Usage = "Etched onto armor.",
                Level = 12,
                Price = 200000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c855389d-8d83-4878-97a2-646a50ac252f"), "Each time you're critically hit while wearing the etched armor, attempt a DC 17 flat check. On a success, it becomes a normal hit. This property thickens the armor, increasing its Bulk by 1 and the Strength required to reduce its penalties by 2.")
					.Build(),
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Fortification (Greater)",
                Usage = "Etched onto armor.",
                Level = 18,
                Price = 2400000,
                PotencyId = Potencies.Instances.Greater.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("ba3a9e94-8ef9-4146-8d93-5e2ca9f045d0"), "Each time you're critically hit while wearing the etched armor, attempt a DC 14 flat check. On a success, it becomes a normal hit. This property thickens the armor, increasing its Bulk by 1 and the Strength required to reduce its penalties by 2.")
					.Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5a92b011-faaf-47d3-aaa7-027f304a4a3a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("0f3a63be-f724-4136-b9d5-cc0797b64a5a"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42a06e50-9396-42ee-a2b1-85ab6a2b25e1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 582
            };
        }

    }
}
