using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class EnergyResistantRune : Template
    {
        public static readonly Guid ID = Guid.Parse("d21ec6e1-b491-49e8-ba45-64abfdce9da8");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Energy-Resistant",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("575329d6-6e3b-4bf0-af7c-a2f4f2598a35"), Type = TextBlockType.Text, Text = "These symbols convey protective forces from the Elemental Planes. You gain resistance 5 to acid, cold, electricity, or fire. The crafter chooses the damage type when creating the rune. Multiple energy-resistant runes can be etched onto a suit of armor; rather than using only the highest-level effect, each must provide resistance to a different damage type. For instance, a +2 acid-resistant greater fire-resistant breastplate would give you acid resistance 5 and fire resistance 10." };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("f3bec9a8-a25f-4e83-8dd6-5d212c127061"),
                Benefits = "You gain resistance 5 to acid, cold, electricity, or fire. The crafter chooses the damage type when creating the rune.",
                ItemLevel = 8,
                Price = 42000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };

            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("eeb0552c-c6e5-4e0d-a8e2-0720dc5ad38a"),
                Benefits = "You gain resistance 10 to acid, cold, electricity, or fire. The crafter chooses the damage type when creating the rune.",
                ItemLevel = 12,
                Price = 165000,
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
                Id = Guid.Parse("bff406f0-ce06-4661-b2a1-df203edd2f19"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 582
            };
        }

    }
}
