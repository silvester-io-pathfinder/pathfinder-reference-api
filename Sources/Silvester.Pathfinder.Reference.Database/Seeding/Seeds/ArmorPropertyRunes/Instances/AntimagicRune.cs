using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class AntimagicRune : Template
    {
        public static readonly Guid ID = Guid.Parse("aaaa1bfc-1a6f-4a5a-b2e7-3b9c779aa014");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Antimagic",
                RarityId = Rarities.Instances.Uncommon.ID,
                CraftingRequirements = "Supply one casting of dispel magic."
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8f63efb2-6386-411c-999e-d0344722aae9"), Type = TextBlockType.Text, Text = "This intricate rune displaces spell energy." };
        }

        protected override ArmorPropertyRuneAction? GetAction()
        {
            return new ArmorPropertyRuneAction
            {
                Id = Guid.Parse("750c0b06-8779-4b81-a4f2-0c00e93afe0e"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Command",
                Trigger = "A spell targets you or includes you in its area.",
                Effect = "The armor attempts to counteract the triggering spell with the effect of a 7th-level dispel magic spell and a counteract modifier of +26.",
                Frequency = "Once per day."
            };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("0df7fbff-c4fd-4d0b-b113-347130169eac"),
                Benefits = "You gain a +1 status bonus to saving throws against magical effects.",
                ItemLevel = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("336109a6-8dc4-47ec-921a-188bb51582e3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 582
            };
        }
    }
}
