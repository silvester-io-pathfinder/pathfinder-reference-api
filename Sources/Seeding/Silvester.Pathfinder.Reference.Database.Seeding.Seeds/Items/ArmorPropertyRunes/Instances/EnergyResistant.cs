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
    public class EnergyResistant : Template
    {
        public static readonly Guid ID = Guid.Parse("d21ec6e1-b491-49e8-ba45-64abfdce9da8");
        
        public static readonly Guid STANDARD_ID = Guid.Parse("f3bec9a8-a25f-4e83-8dd6-5d212c127061");
        public static readonly Guid GREATER_ID = Guid.Parse("eeb0552c-c6e5-4e0d-a8e2-0720dc5ad38a");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Energy-Resistant",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("575329d6-6e3b-4bf0-af7c-a2f4f2598a35"), "These symbols convey protective forces from the Elemental Planes. You gain resistance 5 to acid, cold, electricity, or fire. The crafter chooses the damage type when creating the rune. Multiple energy-resistant runes can be etched onto a suit of armor; rather than using only the highest-level effect, each must provide resistance to a different damage type. For instance, a +2 acid-resistant greater fire-resistant breastplate would give you acid resistance 5 and fire resistance 10.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Energy-Resistant",
                Usage = "Etched onto armor.",
                Level = 8,
                Price = 42000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("0460c299-15bd-49e5-9cad-d09f1826e1ad"), "You gain resistance 5 to acid, cold, electricity, or fire. The crafter chooses the damage type when creating the rune.")
					.Build(),
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Energy-Resistant (Greater)",
                Usage = "Etched onto armor.",
                Level = 12,
                Price = 165000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("7a39a205-9357-484e-b94e-abbe7b92fff8"), "You gain resistance 10 to acid, cold, electricity, or fire. The crafter chooses the damage type when creating the rune.")
					.Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ebadfaff-78f3-4ab3-baa0-70867fdd4c03"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("91d09676-3600-4bc8-a0b4-d0efdcbd1548"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bff406f0-ce06-4661-b2a1-df203edd2f19"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 582
            };
        }
    }
}
