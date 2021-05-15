using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class BloodbaneRune : Template
    {
        public static readonly Guid ID = Guid.Parse("5bef5cb1-6cc2-4540-9224-6200bb40d217");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Bloodbane",
                Usage = "etched onto a clan dagger",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("5841519c-7f2e-4954-aa13-47b6fc1e7a62"),
                ItemLevel = 8,
                Price = 47500,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("0c77fc3d-b181-4975-ba10-cafbbfbadd37"), Type = TextBlockType.Text, Text = "A bloodbane clan dagger is especially vicious against the ancestral enemies of the clan. When you damage an appropriate type of creature with the weapon, that creature takes 1 persistent bleed damage. The type of creature depends on the clan that made the dagger, but is typically drow, duergar, giant, or orc."},
                    new TextBlock {Id = Guid.Parse("77e3597b-6ea4-4733-8920-04c4cebbd31a"), Type = TextBlockType.Text, Text = "In addition, whenever you inflict persistent bleed damage with a bloodbane weapon (whether from its innate ability or in some other way), the weapon leaves ragged wounds. The bleeding creature must succeed at a DC 25 Fortitude save or become sickened 1. The creature is then temporarily immune for 1 hour."},
                }
            };

            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("58601e5f-f93a-46fe-9e6e-2f4d63ed7f9f"),
                ItemLevel = 13,
                Price = 280000,
                PotencyId = Potencies.Instances.Greater.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("318feeb1-4c1a-4ee7-a9d9-0735d4a43c13"), Type = TextBlockType.Text, Text = "The weapon deals 1d4 bleed damage to creatures designated as the clan’s enemy, and the DC of the Fortitude save to avoid becoming sickened is 30."},
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Dwarf.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bfa28f4-acd9-4830-a73c-2269824febb8"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 75
            };
        }
    }
}
