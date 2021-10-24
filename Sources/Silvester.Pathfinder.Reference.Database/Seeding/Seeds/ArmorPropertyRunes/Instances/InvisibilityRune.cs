using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class InvisibilityRune : Template
    {
        public static readonly Guid ID = Guid.Parse("a33f6f32-1aa6-4d14-a352-4ef60956d7d0");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Invisibility",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bc6af7f1-4d9c-4333-948b-c1fbf8fef334"), Type = TextBlockType.Text, Text = "Light seems to partially penetrate this armor." };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("f3b0b720-b5f8-47af-8d61-ab0ac61eb3f7"),
                Benefits = "You can activate the armor once per day.",
                ItemLevel = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };

            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("223467d2-6082-4c7d-9081-dfa4080ab3df"),
                Benefits = "You can activate the armor up to three times per day.",
                ItemLevel = 10,
                Price = 100000,
                PotencyId = Potencies.Instances.Greater.ID,
            };
        }

        protected override ArmorPropertyRuneAction? GetAction()
        {
            return new ArmorPropertyRuneAction
            {
                Id = Guid.Parse("d8bf69be-6855-44de-b527-917446bee16a"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Command",
                Effect = "Whispering the command word, you become invisible for 1 minute, gaining the effects of a 2nd-level invisibility spell.",
                Frequency = "Depends on rune potency."
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa3b80f7-0a69-4b1d-ab02-ab4cfc0a04e9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }

    }
}
