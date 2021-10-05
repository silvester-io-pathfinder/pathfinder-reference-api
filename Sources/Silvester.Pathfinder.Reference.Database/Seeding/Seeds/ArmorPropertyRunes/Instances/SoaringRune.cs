using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class SoaringRune : Template
    {
        public static readonly Guid ID = Guid.Parse("a3e92834-573a-417f-9ffa-710c6ac73bff");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Soaring",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cdcf5422-2d5d-4724-a17b-f09f6094bc65"), Type = TextBlockType.Text, Text = "A set of soaring armor helps you fly faster and protects you and nearby allies from falling." };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("47be5207-8598-4900-99bb-ffe41368b1e5"),
                Benefits = "While wearing soaring armor, you gain a +10-foot item bonus to your fly Speed, if you have one. As normal, if your fly Speed is based on your land Speed and you already have an item bonus to your land Speed, these bonuses aren't cumulative.",
                ItemLevel = 14,
                Price = 375000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4dc7607b-00e0-400d-bf86-5acb21368509"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 139
            };
        }
    }
}
