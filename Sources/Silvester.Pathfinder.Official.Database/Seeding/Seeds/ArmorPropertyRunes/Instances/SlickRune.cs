using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class SlickRune : Template
    {
        public static readonly Guid ID = Guid.Parse("42cd3663-a683-4549-90f5-8d5d24195060");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Slick",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("425f1a21-6e3b-4422-8ba5-a4011936a40f"), Type = TextBlockType.Text, Text = "This property makes armor slippery, as though it were coated with a thin film of oil." };
        }

        protected override ArmorPropertyRuneAction? GetAction()
        {
            return new ArmorPropertyRuneAction
            {
                Id = Guid.Parse("7f1657f4-a464-4c34-b89e-bcec1dd2fe1f"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Command",
                Effect = "You cast feather fall on the triggering creature.",
                Trigger = "You or a creature within 60 feet of you is falling.",
            };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("ce68539b-be99-45c2-b16d-65df7d390fe5"),
                Benefits = "You gain a +1 item bonus to Acrobatics checks to Escape and Squeeze",
                ItemLevel = 5,
                Price = 4500,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };

            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("b7c7d5c6-20b0-4ef0-803f-f8ba775d350b"),
                Benefits = "You gain a +2 item bonus to Acrobatics checks to Escape and Squeeze",
                ItemLevel = 8,
                Price = 45000,
                PotencyId = Potencies.Instances.Greater.ID,
            };

            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("65dbe0f1-8a2a-434b-a96c-725df73e7ef0"),
                Benefits = "You gain a +3 item bonus to Acrobatics checks to Escape and Squeeze",
                ItemLevel = 16,
                Price = 900000,
                PotencyId = Potencies.Instances.Major.ID,
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29dc57f2-7c63-4b53-ad42-4fe7abced5c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
