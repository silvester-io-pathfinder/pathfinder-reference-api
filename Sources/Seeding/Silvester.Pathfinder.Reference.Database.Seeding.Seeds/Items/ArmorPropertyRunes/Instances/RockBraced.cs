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
    public class RockBraced : Template
    {
        public static readonly Guid ID = Guid.Parse("1add97fa-232b-4aed-a710-d41d42352ae1");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Rock-Braced",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d27ca5bd-e42f-4d6b-8432-838373be0fa3"), "Rock-braced armor makes you as hard to move as a boulder. ");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = Guid.Parse("a42afb26-c1df-4f95-acc5-bd3c1a58a58b"),
                Name = "Rock-Braced",
                Usage = "Etched onto medium or heavy armor.",
                Level = 13,
                Price = 300000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("485f49dc-a8dc-48da-a3a4-d396f206f1cd"), "Whenever another creature attempts to forcibly move you from your space, you gain a +4 item bonus to your Fortitude DC against the check to move you. If the creature would not normally need to attempt a check to move you, then the creature must succeed at an Athletics check against your Fortitude DC (including the +4 item bonus) or you are unmoved.")
					.Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("05685603-c1c8-4471-b366-4744afe2db98"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("0d8da623-495f-49b8-b917-70264ebbf074"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("918982ff-1d20-4f4f-8a32-6f87e003f94d"), Traits.Instances.Dwarf.ID);
            builder.Add(Guid.Parse("3e3207d2-96d2-4d1e-8035-b377944be4be"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("7c6f8358-b7ad-461d-83df-ebb7840c935f"), Traits.Instances.Saggorak.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3541d89b-6928-49a6-902e-f05be310dcb3"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 75
            };
        }
    }
}
