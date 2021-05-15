using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class SerratingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("9f59dddb-5e3b-4809-b14c-b2d31e002f50");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Serrating",
                Usage = "Etched onto a slashing melee weapon.",
                AccessRequirements = "A character who is a member of the Knights of Lastwall has access to this option."
            };
        }

        protected override IEnumerable<WeaponPropertyRuneAction> GetActions()
        {
            yield return new WeaponPropertyRuneAction
            {
                Id = Guid.Parse("237e2cf1-65b5-4fa2-9e60-175747d76c1f"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Interact",
                Effect = "You brandish the weapon and focus its power, causing the serrated shards to buzz as they spin at a dizzying speed. On your next hit with the weapon this turn that deals slashing damage, the serrating rune adds an additional 1d12 damage instead of the additional 1d4 damage, and then the shards return to their usual speed."
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("8b4e3b95-e474-4a3c-bad9-62f53d7371be"),
                ItemLevel = 10,
                Price = 100000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("3d0b5a29-2e4e-4e8e-b16a-123d6c947bb9"), Type = TextBlockType.Text, Text = "A serrating weapon’s bladed edge separates into jagged, swirling shards that spin along the blade. When dealing slashing damage, the weapon deals an additional 1d4 damage."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("311a7111-a152-4e74-9cfc-c157b64ec06b"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 93
            };
        }
    }
}
