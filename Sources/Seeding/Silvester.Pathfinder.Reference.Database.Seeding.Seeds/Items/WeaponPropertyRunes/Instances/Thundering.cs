using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Thundering : Template
    {
        public static readonly Guid ID = Guid.Parse("796898b3-9662-411f-ac5e-7a40a8008976");

        public static readonly Guid STANDARD_ID = Guid.Parse("f5847e4b-aea8-4e00-911f-f010b728daed");
        public static readonly Guid GREATER_ID = Guid.Parse("72606c00-caaf-4ac6-9fed-e8cc51c39593");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Thundering",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bd8d112c-ce81-483f-89d8-108e4dcfa522"), "This weapon lets out a peal of thunder when it hits.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Thundering",
                Usage = "Etched onto a weapon.",
                Level = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5d42cd08-c0ce-4e2d-9853-af20869429f2"), "The peal of thunder deals an extra 1d6 sonic damage on a successful Strike. On a critical hit, the target has to succeed at a DC 24 Fortitude save or be deafened for 1 minute (or 1 hour on a critical failure).")
                    .Build()
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Thundering (Greater)",
                Usage = "Etched onto a weapon.",
                Level = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("43a36fa8-f7a4-4c49-8cf7-0bd08378d2f9"), "The peal of thunder deals an extra 1d6 sonic damage on a successful Strike. On a critical hit, the target has to succeed at a DC 34 Fortitude save or be deafened for 1 minute (or 1 hour on a critical failure). Sonic damage dealt by this weapon ignores the target's sonic resistance.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("48e5ccfb-58c7-4656-9437-1683c3e4eaa4"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("ffc0dfdf-92fe-4921-a312-70ca3f15c791"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("e639f989-80e8-4e03-8860-ed090cd2b769"), Traits.Instances.Sonic.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd84a129-2cd1-4780-b420-e9d7b9bcab0d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
